using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Assign_2_8FEb
    {
        static void Main()
        {
            //-------------------1. Print sum and average of elements of an Array

            int[] num = new int[] { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            float avg;
            for (int i = 0; i < 5; i++)
            {
                sum += num[i];
            }

            avg = (float)sum / 9;
            Console.WriteLine("Sum " + sum);
            Console.WriteLine("Average " + avg);


            //----------------------------2.  WAP to display sum of 3 by 3 matrices

            int[,] num = new int[3, 3];
            int sum = 0;

            Console.WriteLine("Enter Numbers");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num[i, j] = Convert.ToInt16(Console.ReadLine());
                    sum += num[i, j];
                }

            }
            Console.WriteLine("Sum of matrix is " + sum);




            //-------------- 3.   WAP to find the maximum element of an integer Array

            int[] num = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            int max = num[0];

            for (int i = 0; i < 10; i++)
            {
                if (num[i] > max)
                    max = num[i];
            }
            Console.WriteLine("Maximum Element of this Array is " + max);


            //----------------- 4.  WAP to print column wise sum of elements of 2 D Array



            int[,] num = new int[3, 3];
            int sum = 0;
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += num[j, i];
                }
                Console.WriteLine("Sum of the column " + i + 1 + " is " + sum);
                sum = 0;
            }

            //----------------5.    WAP to print row wise sum of elements of 2 D Array


            int[,] num = new int[3, 3];
            int sum = 0;
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += num[i, j];
                }
                Console.WriteLine("Sum of the Row " + i + 1 + " is " + sum);
                sum = 0;
            }
         }
    }
  }
