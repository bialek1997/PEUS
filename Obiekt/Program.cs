using Kvaser.CanLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Obiekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] wartoscZadanaByte = new byte[8];
            byte[] wartoscAktualnaByte = new byte[8];

            int id = 0;
            int dlc = 0;
            int flag = 0;
            long time = 0;

            double wartoscZadana = 0;
            double wartoscAktualna = 0;
            double sterowanie = 0;

            Canlib.canInitializeLibrary();
            int Channel0 = Canlib.canOpenChannel(0, Canlib.canOPEN_ACCEPT_VIRTUAL);
            Canlib.canBusOn(Channel0);

            Canlib.canReadWait(Channel0, out id, wartoscZadanaByte, out dlc, out flag, out time, long .MaxValue);

            Silnik silnik = new Silnik()
            {
                H = 0.2
            };

            while (!Encoding.ASCII.GetString(wartoscZadanaByte).Contains("STOP"))
            {
                Canlib.canRead(Channel0, out id, wartoscZadanaByte, out dlc, out flag, out time);

                sterowanie = BitConverter.ToDouble(wartoscZadanaByte, 0);
                if(sterowanie != -1)
                {
                    wartoscZadana = sterowanie;
                }
                if(sterowanie > 300)
                {
                    wartoscZadana = 300;
                }

                wartoscAktualna = silnik.WyznaczWyjscie(wartoscZadana - wartoscAktualna);
                wartoscAktualnaByte = BitConverter.GetBytes(wartoscAktualna);
                Canlib.canWrite(Channel0, 20, wartoscAktualnaByte, 8, 0);

                Console.WriteLine(wartoscAktualna);
                Thread.Sleep(100);                
            }
            Environment.Exit(0);
        }
    }
}
