using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    internal class Add
    {
        public static void Added(int[] ray)
        {
            // adds the new vaule to the array
            int[] NewArray = new int[ray.Length + 1];
            int i;
            for (i = 0; i < ray.Length; i++)
            {
                NewArray[i] = ray[i];
            }
            NewArray[i] = 10;
            Console.WriteLine(string.Join(",", NewArray));

            // built in method to remove
            int item = 4;
            ray = ray.Where(e => e != item).ToArray();
            Console.WriteLine(String.Join(",", ray));

            // written way
            int j = 0;
            int pos;
            pos = 4;
            // Shifting elements
            for (j = pos - 1; j < 0; j++)
            {
                ray[j] = ray[j + 1];
            }
            Console.WriteLine(String.Join(",", ray));

        }
    }
}
