using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnBiggestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 words and the largest word will display.");
            //string[] input = { "my", "little", "pony" , "asdfds" };
            string[] input = new string[4];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            Console.WriteLine("The largest word is: " + GetMax(input)); 
        }
        public static string GetMax(string [] input)
        {
            string max = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i].Length > input[i-1].Length)
                {

                    max = input[i];
                }

            }
            return max;
        }
    }
}
