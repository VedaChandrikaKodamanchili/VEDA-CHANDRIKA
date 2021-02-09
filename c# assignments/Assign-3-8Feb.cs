using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Assign_3_8Feb
    {
        static void Main()
        {

            //--------1.  To count a total number of duplicate elements in an array

            int[] num = new int[5];
            int count = 0;
            Console.WriteLine("Enter Numbers");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        break;

                    }
                }
            }
            Console.WriteLine("Duplicate Elements are " + count);


            //-------------------2.  find the eligibility of admission for a professional course based on the following criteria:

            int Maths, Phy, Chem, Total_3, Tot_Mat_Phy;
            Console.WriteLine("Input the marks obtained in Mathematics :");
            Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Physics :");
            Phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            Chem = Convert.ToInt32(Console.ReadLine());
            Total_3 = Maths + Phy + Chem;
            Tot_Mat_Phy = Maths + Phy;

            if ((Maths >= 65) && (Phy >= 55) && (Chem >= 50))
            {
                if ((Total_3 >= 180) || (Tot_Mat_Phy >= 140))
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }



            //-----------3.    


            string cs_Id, cs_Name;
            double units, charges = 0, surchage = 0, net_amt;
            Console.Write("Customer ID :");
            cs_Id = Console.ReadLine();
            Console.Write("Customer Name :");
            cs_Name = Console.ReadLine();
            Console.Write("unit Consumed :");
            units = Convert.ToDouble(Console.ReadLine());

            if (units <= 199)
            {
                charges = units * 1.20;
                Console.WriteLine("\nAmount Charges @Rs. 1.20 per unit : "+ charges);
            }
            else if (units >= 200 && units <= 400)
            {
                charges = units * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit : "+ charges);
            }
            else if (units >= 400 && units <= 600)
            {
                charges = units * 1.80;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit : "+  charges);
            }
            else if (units >= 600)
            {
                charges = units * 2.00;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit : "+ charges);
            }

            if (charges > 400)
            {
                surchage = ((15 * charges) / 100);
            }

            Console.WriteLine("Surchage Amount : "+ surchage);

            net_amt = charges + surchage;

            if (net_amt < 100)
                net_amt = 100;
            Console.WriteLine("Net Amount Paid By the Customer : " + net_amt);
        }
    }
}
   