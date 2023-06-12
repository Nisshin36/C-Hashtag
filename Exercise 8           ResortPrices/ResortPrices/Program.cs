/* Anh-Tu Ngoc Chapter 6 Exercise 8 ResortPrices */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {

            int Index;                                                                                               // Increment 
            int[] LowerDiscountsRangesArray = { 1, 3, 5, 8};                                                         // Lowest days that qualify for certain discounts. 
            double[] PricesArray = { 200, 180, 160, 145 };                                                           // Price for certain day range. 
            double Cost = 0;                                                                                         // Cost initialized at 0

            string UserInput;                                                                                           
            int NumofNights;

            System.Console.WriteLine("Nightly rates are $200 for 1 or 2 nights, $180 for 3 to 4 nights,");
            System.Console.WriteLine("$160 for five to seven nights, and $145 for eight nights or more."); 
            System.Console.WriteLine("");
            System.Console.Write("Enter the number of nights you wish to stay:   ");
            UserInput = System.Console.ReadLine();                                                                  // Information entered by user will be stored in this variable as a string
            NumofNights = Convert.ToInt32(UserInput);                                                               // That variable will be converted to an integer and stored in this variable                

            for (Index = 3; Index >= 0; --Index)                                                                    // Starting from largest index to smallest
            {
                if (NumofNights >= LowerDiscountsRangesArray[Index])                                                // If the nights stayed is larger or equal to  certain index in the LowerDiscountRanges array...
                {
                    Cost = NumofNights * PricesArray[Index];                                                        // Calculate the cost
                    break;                                                                                          // Break out of loop
                }                                                                                                   // If not, then continue the loop until the if statement proves true. 
            }

            System.Console.WriteLine("You are staying for {0} nights at {1} per night for a total of {2}", NumofNights, PricesArray[Index].ToString("C"), Cost.ToString("C"));             // Display Summary.

            System.Console.ReadLine();



        }
    }
}
