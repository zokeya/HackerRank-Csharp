using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    internal class Program
    {

        public static int findDigits(int n)
        {
            string nInput = n.ToString();
            string[] nArray = new string[nInput.Length];

            int nInputAsInteger = Int32.Parse(nInput);
            int c = 0;

            for (int i = 0; i < nInput.Length; i++)
            {
                nArray[i] = nInput.Substring(i, 1);

                if (Int32.Parse(nArray[i]) != 0)
                {
                    if (nInputAsInteger % Int32.Parse(nArray[i]) == 0)
                    {
                        c++;
                    }
                }
                else
                {
                    c += 0;
                }
            }

            return c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("input some numbers");

            string nInput = Console.ReadLine().Trim();
            string[] nArray = new string[nInput.Length];

            int nInputAsInteger;

            while (!Int32.TryParse(nInput,out nInputAsInteger))
            {
                Console.WriteLine("Not a valid Number. Please input numbers only");
                nInput = Console.ReadLine().Trim();
            }

            if(Int32.Parse(nInput) < 0 || Int32.Parse(nInput) > Math.Pow(10.00, 9.00))
            {
                Console.WriteLine("You should enter a number that is greater than 0 and less than 10^9");
                nInput = Console.ReadLine().Trim();
            }

            nInputAsInteger = Int32.Parse(nInput);

            int result = findDigits(nInputAsInteger);

            Console.WriteLine($"The outcome of find digits is {result}");

            //int c = 0;

            //for (int i = 0; i < nInput.Length; i++)
            //{
            //    nArray[i] = nInput.Substring(i, 1);

            //    if (Int32.Parse(nArray[i]) != 0)
            //    {
            //        if (nInputAsInteger % Int32.Parse(nArray[i]) == 0)
            //        {
            //            c++;
            //        }
            //    }
            //    else
            //    {
            //        c += 0;
            //    }

            //    Console.WriteLine($"{nArray[i]}");
            //}

            //Console.WriteLine($"{c}");
        }
    }
}
