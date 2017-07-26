using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(String[] args)
        {
            
            

            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            var listOfApples = apple.ToList();
            var listOfOranges = orange.ToList();

            var appleCount = 0;
            var orangeCount = 0;

            foreach (var item in listOfApples)
            {
                if (a + item >= s && a + item <= t)
                {
                    appleCount++;
                }

            }

            foreach (var item in listOfOranges)
            {
                if (b + item >= s && b + item <= t)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}
