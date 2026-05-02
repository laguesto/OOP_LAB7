using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLib
{
    public class ExceptionClass
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;

        public ExceptionClass(double a, double b, double c, double d)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
        }

        public double Calculate()
        {
            double numerator = _a * _b / 4.0 - 1;
            double underRoot = 41 - _d - _b * _a + _c;

            if (underRoot < 0)
            {
                throw new Exception("underroot < 0");
            }

            double denominator = Math.Sqrt(underRoot);

            if (denominator == 0)
            {
                throw new Exception("dividing by 0");
            }

            return numerator / denominator;
        }
    }
}
