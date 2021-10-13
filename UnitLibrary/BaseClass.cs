using System;

namespace UnitLibrary
{
    public abstract class BaseClass : Unit
    {

        public virtual void ChooseUnitTo(string unitTo, double unit)
        {

            switch (unitTo)
            {
                case "g":
                    ConvertToGram(unit);
                    break;
                case "mg":
                    ConvertToMiliGram(unit);
                    break;
                case "lbs":
                    ConvertToPound(unit);
                    break;
                case "oz":
                    ConvertToOunce(unit);
                    break;
                default:
                    throw new ArgumentException(message: "invalid unitTo value", paramName: nameof(unitTo));
            }
        }

    }
}
