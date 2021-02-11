using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Assgn_1_Feb5
    {
        //       WAP to add three numbers

        //static void Main()
        //{
        //    int x = 5;
        //    int y = 10;
        //    int z = 15;
        //    int sum = x + y+z;
        //    Console.WriteLine("The sum of {0},{1},{2} is {3}", x, y,z, sum);
        //}



        //  WAP to multiple 3 numbers


        //static void Main()
        //{
        //    int x = 5;
        //    int y = 10;
        //    int z = 10;
        //    int Product = x * y * z;
        //    Console.WriteLine("The Product of {0},{1},{2} is {3}", x, y, z, Product);
        //}




        //     WAP to declare string and integer variables to hold id, name , address , salary
        //    Display it in
        //    Welcome Ajay, Your Details are as follows:
        //    Your ID : 101
        //    Your Address is : ABC , Delhi
        //    Your Salary is :  25000


        static void Main()
        {
            int id = 101;
            string name = "Ajay";
            string address = "ABC , Delhi";
            int salary = 25000;
            Console.WriteLine("Welcome {0} , Your Details are as follows:", name);
            Console.WriteLine("Your ID : {0}", id);
            Console.WriteLine("Your Address is : {0}", address);
            Console.WriteLine("Your Salary is : {0}", salary);
        }
    }
}
