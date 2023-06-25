using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class triangl
    {
        private double x;
        private double y;
        private double teta;
        public double X
        {
            get { return x; } 
            set
            {
                if (value > 0)
                {
                    x = value;
                }
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
            }
        }
        public double Teta
        {
            get { return teta; }
            set
            {
                if (value > 0)
                {
                    teta = value;
                }
            }
        }
        public triangl() { }
        public triangl (double n1, double n2, double n3)
        {
            x=n1;
            y=n2;
            teta=n3;
        }
        public double calc()
        {
            return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)-(2*x*y*Math.Cos(teta)));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            triangl tr = new triangl(n1,n2,n3);
            Console.WriteLine(tr.calc());
        }
    }
}
