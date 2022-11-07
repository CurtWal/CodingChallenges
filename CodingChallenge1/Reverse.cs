using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge1
{
    internal class Reverse
    {
        public static void rev(int[] ray)
        {
            // 3 different ways
            int[] revray = new int[ray.Length];
            int counter = 0;

            for (int i = ray.Length - 1; i >= 0; i--)
            {
                revray[counter] = ray[i];
                counter++
            }

            foreach (int i in revray)
            {
                Console.WriteLine(i);
            }
            // can't use this for the challenge but just adding it
            int[] reverse = Enumerable.Reverse(ray).ToArray();
            Console.WriteLine(String.Join(',', reverse));


            for (int i = 0; i < ray.Length / 2; i++)
            {
                int tmp = ray[i];
                ray[i] = ray[ray.Length - i - 1];
                ray[ray.Length - i - 1] = tmp;
            }
            Console.WriteLine(string.Join(",", ray));
        }
    }
}
