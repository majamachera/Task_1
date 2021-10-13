using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary
{
    public class Ounce : BaseClass
    {
        public double unit;
        private string unitTo;

        public Ounce(double unit, string unitTo)
        {
            this.unit = unit;
            this.unitTo = unitTo;
        }
        public override void ConvertToGram(double unit)
        {
            unit *= 28.349523125;
            this.unit = unit;
        }
        public override void ConvertToMiliGram(double unit)
        {
            unit *= 28349.523125;
            this.unit = unit;
        }

        public override void ConvertToOunce(double unit)
        {
            this.unit = unit;
        }
        public override void ConvertToPound(double unit)
        {
            unit /= 16;
            this.unit = unit;
        }
    }
}
