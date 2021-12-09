using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekt
{
    public class Silnik
    {
        public double H { get; set; }

        private double sygnalWyjsciowy, time, wartoscAktualna = 0;
        DateTime newTime, oldTime = DateTime.Now;
        public double WyznaczWyjscie(double error)
        {
            newTime = DateTime.Now;
            time = Convert.ToDouble((newTime - oldTime).TotalSeconds);

            sygnalWyjsciowy = wartoscAktualna + time * H * error;

            wartoscAktualna = sygnalWyjsciowy;
            oldTime = newTime;

            return sygnalWyjsciowy;
        }
    }
}
