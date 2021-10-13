using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary
{
    public abstract class Unit
    {
        public abstract void ConvertToGram(double unit);
        public abstract void ConvertToPound(double unit);
        public abstract void ConvertToOunce(double unit);
        public abstract void ConvertToMiliGram(double unit);
    }
}
