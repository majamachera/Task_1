using System;
using System.Collections.Generic;
using System.Linq;
using UnitLibrary;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string unitFrom = "g";
            string unitTo = "mg";
            Console.WriteLine("Enter the value, the unit from you want to convert and the unit to you want to convert according to the example:");
            Console.WriteLine($"5{unitFrom}, {unitTo}");
            string fromUser = Console.ReadLine();
            TransformatingDataFromUser(fromUser, ref unitFrom,
            ref unitTo, out double unit);
            var result = Math.Round(Converter.Convert(unitFrom, unitTo, unit), 10);
            decimal resultDecimal = (decimal)result;
            System.Console.WriteLine($"{resultDecimal}{unitTo}");
        }
        static void TransformatingDataFromUser(string fromUser, ref string unitFrom,
            ref string unitTo, out double unit)
        {
            List<string> unitList = new List<string> { "g", "mg", "lbs", "oz" };
            string[] fromUserList = fromUser.Split(' ');
            string toDouble = fromUserList.First().TrimEnd(',');
            foreach (var item in unitList)
            {
                if ((fromUserList.First().Contains(item)))
                {
                    if ((fromUserList.First().Contains("mg")))
                    {
                        unitFrom = "mg";
                        for (int i = 0; i < unitFrom.Length; i++)
                        {
                            toDouble = toDouble.Remove(toDouble.Length - 1);

                        }
                        System.Console.WriteLine(toDouble);

                        break;
                    }
                    else
                    {
                        unitFrom = item;
                        for (int i = 0; i < item.Length; i++)
                        {
                            toDouble = toDouble.Remove(toDouble.Length - 1);
                        }
                    }

                }

            }
            foreach (var item in unitList)
            {
                if ((fromUserList.Last()) == item)
                {
                    unitTo = item;
                }

            }
            unit = Convert.ToDouble(toDouble);
        }
    }
}
