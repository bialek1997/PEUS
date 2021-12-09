using Kvaser.CanLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sterowanie
{
    public partial class SterowanieForm : Form
    {
        Thread aktualizujPolaDlaNowejPredkosci;
        byte[] zadanaPredkosc = new byte[8];
        byte[] aktualnaPredkosc = new byte[8];
        ulong xSeries = 0;
        int Channel0 = Canlib.canOpenChannel(0, Canlib.canOPEN_ACCEPT_VIRTUAL);

        public SterowanieForm()
        {
            InitializeComponent();
            Canlib.canBusOn(Channel0);
            Canlib.canWrite(Channel0, 10, Encoding.ASCII.GetBytes("START"), 8, 0);

            Wykres.ChartAreas[0].AxisX.Minimum = 0;
            Wykres.ChartAreas[0].AxisX.Maximum = 500;
            Wykres.ChartAreas[0].AxisX2.Minimum = 0;
            Wykres.ChartAreas[0].AxisX2.Maximum = 500;

            aktualizujPolaDlaNowejPredkosci = new Thread(AktualizujPolaDlaNowejPredkosci);
            aktualizujPolaDlaNowejPredkosci.Start();
        }

        private void WyslijButton_Click(object sender, EventArgs e)
        {
            bool isZadanaPredkosc = Double.TryParse(ZadanaPredkoscValue.Text, out double zadanaPredkoscDouble);
            if (isZadanaPredkosc)
            {
                zadanaPredkosc = BitConverter.GetBytes(zadanaPredkoscDouble);
                Canlib.canWrite(Channel0, 10, zadanaPredkosc, 8, 0);
            }
        }

        private void ZadanaPredkoscValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(ZadanaPredkoscValue.Text, "[^[0-9]"))
            {
                MessageBox.Show("Zadana Prędkość może być tylko liczbą naturalną!");
                ZadanaPredkoscValue.Text = ZadanaPredkoscValue.Text.Remove(ZadanaPredkoscValue.Text.Length - 1);
            }
        }

        public void AktualizujPolaDlaNowejPredkosci()
        {
            int id;
            int dlc;
            int flag;
            long time;

            while (true)
            {
                Thread.Sleep(10);

                Canlib.canRead(Channel0, out id, aktualnaPredkosc, out dlc, out flag, out time);

                AktualizujTextBox(aktualnaPredkosc);
                AktualizujGauge(aktualnaPredkosc);
                AktualizujWykres(aktualnaPredkosc);
            }
        }

        public void AktualizujTextBox(byte[] aktualnaPredkosc)
        {
            AktualnaPredkoscValue.BeginInvoke(new Action(() => {
                AktualnaPredkoscValue.Text = Math.Round(BitConverter.ToDouble(aktualnaPredkosc, 0)).ToString();
            }));
        }

        public void AktualizujGauge(byte[] aktualnaPredkosc)
        {
            Gauge.BeginInvoke(new Action(() =>
            {
                Gauge.Value = Convert.ToSingle(BitConverter.ToDouble(aktualnaPredkosc, 0));
            }));
        }

        public void AktualizujWykres(byte[] aktualnaPredkosc)
        {
            xSeries += 1;
            Wykres.BeginInvoke(new Action(() =>
            {
                if (xSeries > 500)
                {
                    Wykres.Series["ZadanaPredkoscSeries"].Points.Clear();
                    Wykres.Series["AktualnaPredkoscSeries"].Points.Clear();
                    xSeries = 0;
                }
                Wykres.Series["ZadanaPredkoscSeries"].Points.AddXY(xSeries, BitConverter.ToDouble(zadanaPredkosc, 0));
                Wykres.Series["AktualnaPredkoscSeries"].Points.AddXY(xSeries, BitConverter.ToDouble(aktualnaPredkosc, 0));
            }));
        }

        private void SterowanieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aktualizujPolaDlaNowejPredkosci.Abort();
            Canlib.canWrite(Channel0, 10, Encoding.ASCII.GetBytes("STOP"), 8, 0);
            Canlib.canBusOff(Channel0);
        }
    }

}
