using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Processes
{
    public class CalculateSkiLength
    {
        public static string Calculate(Skiier skiier)
        {
            if (ChildFourOrYounger(skiier.Age))
            {
                return LengthForFourOrYounger(skiier.Length);
            }

            if (ChildBetweenFiveAndEight(skiier.Age))
            {
                return LengthForFiveToEight(skiier.Length);
            }

            if (skiier.Style == Style.Classic)
            {
                return CalculateClassic(skiier.Length);
            }

            if (skiier.Style == Style.Freestyle)
            {
                return CalculateFreestyle(skiier.Length);
            }

            return "0";
        }

        public static bool ChildFourOrYounger(int age)
        {
            bool correctAge = false;

            if (age <= 4)
            {
                correctAge = true;
            }
            return correctAge;
        }

        public static string LengthForFourOrYounger(int length)
        {
            return length.ToString();
        }

        public static bool ChildBetweenFiveAndEight(int age)
        {
            bool correctAge = false;

            if (age >= 5 && age <= 8)
            {
                correctAge = true;
            }
            return correctAge;
        }

        public static string LengthForFiveToEight(int length)
        {
            return $"{length + 10} - {length + 20}";
        }

        public static string CalculateClassic(int length)
        {
            length += 20;
            return length <= 207 ? length.ToString() : "207";
        }

        public static string CalculateFreestyle(int length)
        {
            return $"{length + 10} - {length + 15}";
        }
    }
}
