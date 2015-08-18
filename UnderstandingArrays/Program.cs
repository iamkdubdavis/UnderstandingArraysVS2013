using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 16;
            //numbers[3] = 32;
            //numbers[4] = 64;
            //numbers[5] = 128;

            //Console.WriteLine(numbers.Length);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = new int[] { 4, 8, 16, 32, 64, 128 };

            //Console.WriteLine(numbers[1].ToString());
            //Console.ReadLine();

            //string[] names = new string[] { "Sterling", "Malory", "Lana", "Pam", "Cheryl", "Ray" };
            
            //foreach (string name in names) {
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            string archer = "Bloody Mary, full of vodka, blessed are you among cocktails. " +
                "Pray for me now, and at the hour of my death, which I hope is soon.  Amen.";

            char[] charArray = archer.ToCharArray();
            Array.Reverse(charArray);

            foreach (char archerChar in charArray)
                Console.Write(archerChar);

            Console.ReadLine();
        }
    }
}
