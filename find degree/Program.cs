using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_degree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int range = 100;
            int numberToCompare = random.Next(range);
            int numberToExponentiate = 2;
            int degree = 2;
            double result = float.MinValue;
            bool isFound = false;

            while (isFound == false)
            {
                if(result <= numberToCompare)
                {
                    degree++;
                    result = Math.Pow(numberToExponentiate, degree);
                }
                else
                {
                    isFound = true;
                }
            }

            Console.WriteLine("Число: " + numberToCompare + "\nСтепень: " + degree + "\n" + numberToExponentiate + " в степени " + degree + ": " + result);
            Console.ReadKey();
        }
    }
}
