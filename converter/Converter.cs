using System;

namespace converter
{
    public class Converter
    {
        public static double Convert(string unitFrom, string unitTo, double unit)
        {

            switch (unitFrom)
            {
                case "g":

                    Gram ConvertG = new Gram(unit, unitTo);
                    ConvertG.ChooseUnitTo(unitTo, unit);
                    return ConvertG.unit;


                case "mg":

                    Miligram ConvertM = new Miligram(unit, unitTo);
                    ConvertM.ChooseUnitTo(unitTo, unit);
                    return ConvertM.unit;

                case "lbs":

                    Pound ConvertP = new Pound(unit, unitTo);
                    ConvertP.ChooseUnitTo(unitTo, unit);
                    return ConvertP.unit;

                case "oz":

                    Ounce ConvertO = new Ounce(unit, unitTo);
                    ConvertO.ChooseUnitTo(unitTo, unit);
                    return ConvertO.unit;


                default:
                    throw new ArgumentException(message: "invalid unitFrom value", paramName: nameof(unitFrom));
            }


        }
    }
}
