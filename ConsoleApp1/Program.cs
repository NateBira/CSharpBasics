using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables//
            byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            int choice = 2;
            int age = 0;
            double deposits = 135002796;
            double distance = 129.763001;
            float acceleration = 9.800F;
            float mass = 14.6F;
            bool lost = true;
            bool expensive = true;
            char integral = '\u222B';
            String greeting = "Hello";
            String name = "Karen";
            //if else statements//
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples aren not equal.");
            }
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            double force = mass * acceleration;
            Console.WriteLine("Force = " + force.ToString("2.345"));
            Console.WriteLine(distance + " is the distance.");
            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }
            switch (choice) //switch/case//
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
            Console.WriteLine(integral + " is an integral.");
            //for loop//
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }
            //while loop//
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }
            Console.WriteLine(greeting + " " + name);
            Console.ReadLine();
        }
    }
}