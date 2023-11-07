using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet
{
    public class Internet
    {
        private double speed;
        private double latency;
        private String provider;

        public Internet() { }
        public Internet(double speed,double latency, String provider)
        {
            this.speed = speed;
            this.latency = latency;
            this.provider = provider;
        }
        public double TimeCalc( double fileSize)
        {
            return fileSize / this.speed;
        }
        public static double StaticTimeCalc(double fileSize, double speed)
        {
            return fileSize / speed;
        }
        public string toString()
        {
            return $"{nameof(provider)}({nameof(speed)})";
        }
    }
}
