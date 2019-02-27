using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wed_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Hello");
            Console.WriteLine("Amber Cook");

            //Task 2
            Console.WriteLine(74 + 36);

            //Task 3
            Console.WriteLine(50/3);

            //Task 4
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 * num2);

            //Task 5
            Console.WriteLine("Please enter a number");
            int input = int.Parse(Console.ReadLine());
            
            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
               
            }
            Console.ReadLine();

            //Task 6
            Console.WriteLine("Please enter the Radius: ");
            double radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter of a circle with the radius of {radius} is: " + Perimeter(radius));
            Console.WriteLine($"Area of a circle with the radius of {radius} is: " + Area(radius));
        }

        public static double Perimeter(double radius)
        {
            return 2 * 3.14 * radius;
        }

        public static double Area(double radius)
        {
            return 3.14 * (radius*radius);
        }

        public static void task7()
        {
            //Task 7
            int a = 10;
            int b = 20;
            Console.WriteLine($"Num1: {a}\nNum2: {b}");

            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Num1: {a}\nNum2: {b}");

            //Task 8
            int[] Array1 = new int[100];
            Random rand = new Random();

            for (int i = 0; i<100; i++)
            {
                Array1[i]= rand.Next(1000, 9999);
            }

            //Task 9
            Animal a1 = new Animal();
            Console.WriteLine("Please enter animal species: ");
            a1.Species = Console.ReadLine();
            Console.WriteLine("Please enter animal name: ");
            a1.Name = Console.ReadLine();
            Console.WriteLine("Please enter animal age: ");
            a1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter animal ID number: ");
            a1.IdNum = int.Parse(Console.ReadLine());

           
        }

      



    }

    class Animal
    {
        public string species;
        public string name;
        public int age;
        public int idNum;

        public string Species { get { return species; } set { species = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int IdNum { get { return idNum; } set { idNum = value; } }
        
        public Animal(string _species, string _name, int _age, int _idNum)
        {
            Species = _species;
            Console.WriteLine("Species: " + spec);
        }
    }

}
