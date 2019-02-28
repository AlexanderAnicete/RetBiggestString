using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetBiggestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "my", "little", "pony" , "asdfds" };
            Console.WriteLine(GetMax(input)); 
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
