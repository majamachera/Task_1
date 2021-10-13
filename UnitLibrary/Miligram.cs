using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary
{
    public class Miligram : BaseClass
    {


        public double unit;
        private string unitTo;

        public Miligram(double unit, string unitTo)
        {
            this.unit = unit;
            this.unitTo = unitTo;
        }
        public override void ConvertToGram(double unit)
        {
            unit /= 1000;
            this.unit = unit;
        }
        public override void ConvertToMiliGram(double unit)
        {
            this.unit = unit;
        }

        public override void ConvertToOunce(double unit)
        {
            unit *= 3.5274E-5;
            this.unit = unit;
        }
        public override void ConvertToPound(double unit)
        {
            unit *= 2.2046226218488E-6;
            this.unit = unit;
        }
    }
}
