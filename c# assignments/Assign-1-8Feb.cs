﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Assign_1_8Feb
    {
        

        //static void Add(int x, int y)
        //{
        //    Console.WriteLine("Result of Sum is " + (x + y));
        //}

        //static void Subtract(int x, int y)
        //{
        //    Console.WriteLine("Result of Subtraction is " + (x - y));
        //}
        //static void Product(int x, int y)
        //{
        //    Console.WriteLine("Result of Product is " + (x * y));
        //}
        //static void Divide(int x, int y)
        //{
        //    Console.WriteLine("Result of Division is " + (x / y));
        //}
        //static void Main()
        //{
        //    int choice;
        //    Console.WriteLine("Enter Choice");
        //    choice = Convert.ToInt32(Console.ReadLine());

        //    if (choice == 1)
        //    {
        //        Add(10, 20);

        //    }
        //    else if (choice == 2)
        //    {
        //        Subtract(10, 20);


        //    }
        //    else if (choice == 3)
        //    {
        //        Product(10, 20);

        //    }
        //    else if (choice == 4)
        //    {
        //        Divide(20, 10);
        //    }

        //    else
        //        Console.WriteLine("Invalid choice");
        //}


        //SWITCH----------------------

        static void Add(int x, int y)
        {
            Console.WriteLine("Result of Sum is " + (x + y));
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine("Result of Subtraction is " + (x - y));
        }

        static void Product(int x, int y)
        {
            Console.WriteLine("Result of Product is " + (x * y));
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine("Result of Division is " + (x / y));
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Add(10, 20);
                    break;
                case 2:
                    Subtract(20, 10);
                    break;
                case 3:
                    Product(10, 20);
                    break;
                case 4:
                    Divide(20, 10);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

    }

}

