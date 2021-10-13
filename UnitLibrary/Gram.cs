using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary
{
    public class Gram : BaseClass
    {
        public double unit;
        private string unitTo;

        public Gram(double unit, string unitTo)
        {
            this.unit = unit;
            this.unitTo = unitTo;
        }
        public override void ConvertToGram(double unit)
        {
            this.unit = unit;
        }
        public override void ConvertToMiliGram(double unit)
        {
            unit *= 1000;
            this.unit = unit;
        }
        public override void ConvertToOunce(double unit)
        {
            unit /= 453.59237 / 16;
            this.unit = unit;
        }
        public override void ConvertToPound(double unit)
        {
            unit /= 453.59237;
            this.unit = unit;
        }
    }
}
