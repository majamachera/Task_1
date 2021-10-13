using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary
{
    public class Pound : BaseClass
    {
        public double unit;
        public string unitTo;

        public Pound(double unit, string unitTo)
        {
            this.unit = unit;
            this.unitTo = unitTo;
        }

        public override void ConvertToGram(double unit)
        {
            unit *= 453.59237;
            this.unit = unit;
        }
        public override void ConvertToMiliGram(double unit)
        {
            unit *= 453592.37;
            this.unit = unit;
        }
        public override void ConvertToOunce(double unit)
        {
            unit *= 16;
            this.unit = unit;
        }
        public override void ConvertToPound(double unit)
        {
            this.unit = unit;
        }
    }
}
