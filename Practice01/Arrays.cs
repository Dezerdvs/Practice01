using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    internal class Arrays

    {
        static void Main(string[] args)
        {
            string[] windDirections = { "north", "south", "east", "west" };
            int[] windSpeeds = { 10, 12, 8, 9, 7, 11, 13, 14, 6, 8 };
            int count = 0;
            for (int i = 0; i < windDirections.Length; i++)
            {
                for (int j = 0; j < windSpeeds.Length; j++)
                {
                    if (windDirections[i] == "south" && windSpeeds[j] > 8)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("The number of days when the southern wind blew with a speed exceeding 8 m/s is: " + count);
        }
    }
}

