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
            if (skiier.Age <= 4)
            {
                return skiier.Length.ToString();
            }

            if (skiier.Age >= 5 && skiier.Age <= 8)
            {
                return $"{skiier.Length + 10} - {skiier.Length + 20}";
            }

            if (skiier.Style == Style.Classic)
            {
                skiier.Length += 20;
                if (skiier.Length <= 207)
                {
                    return skiier.Length.ToString();
                }
                else
                {
                    return "207";
                }
            }

            if (skiier.Style == Style.Freestyle)
            {
                return $"{skiier.Length + 10} - {skiier.Length + 15}";
            }

            return "0";
        }
    }
}
