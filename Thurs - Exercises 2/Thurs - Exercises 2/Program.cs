using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thurs___Exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises 2
            //Task 1
            //Asking user for a number and creating a new array the size of the number entered by the user. 
            Console.WriteLine("Please enter a number for the size of the array");
            int[] num = new int[int.Parse(Console.ReadLine())];

            //Creating a new random number genterator.
            Random rand = new Random();

            //Loop to fill array with random numbers
            for (int i = 0; i <num.Length; i++)
            {
                num[i] = rand.Next(1,100);
            }

            //Display array in ascending order to console
            //Console.WriteLine(num.Sort); ??


        }
    }
}
