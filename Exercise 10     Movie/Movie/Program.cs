/* Anh-Tu Ngoc Chapter 8 Exercise 10 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Program                                                                                  // Too Easy
    {
        static void Main()
        {
            string MovieName;                                                                        
            int RunTime;

            System.Console.Write("Enter the name of the movie:   ");                               // User enters the name of the movie
            MovieName = System.Console.ReadLine();                                                 // and it is stored as a string in the 'MovieName' variable. 

            System.Console.WriteLine("");  
            System.Console.WriteLine("Do you want to enter the running time?");                    // Asks user if they want to enter the movie runing time
            System.Console.Write("Enter 'Y' for yes, 'N' for no. :   ");
            string Switch = System.Console.ReadLine().ToLower();                                   // Whatever the user inputs, convert it to lowercase, store it as a string in the 'Switch' variable.

            if (Switch == "y")                                                                     // If the user enters 'Y' for yes, then...
            {
                System.Console.Write("Enter the total running time:   ");                                  // The program would promt the user for the running time
                RunTime = Convert.ToInt32(System.Console.ReadLine());                                      // Whatever the user inputs, it will convert it to an Int, and store it in the 'RunTime' variable.
                Display(ref MovieName, RunTime);                                                           // Then the program would pass both the 'MovieName' and 'RunTime' variables to the Display Method. 
            }                                                                                              // However, 'Runtime' cannot be passed by reference, because default values cannot be assigned to a variable passed by reference. 
            else                                                                                   // If the user enters anything else besides 'Y'...
            {
                Display(ref MovieName);                                                                    // Only pass the 'MovieName' variable to the Display Method.  
            }

            


            System.Console.ReadLine();
        }

        static void Display(ref string MovieName, int Time = 90)                                   // This method accepts the 'MovieName' variable by reference; and the 'RunningTime variable if passed. This is called the "Optional Parameter"
        {                                                                                          // 'Time' has a default value of 90, just in case this method is called without the 'RunTime' arguement, like line 33.
                                                                                                   // But if this method is called on by line 29, then 'Time' would have the same value as 'RunTime'. 
            System.Console.WriteLine("");
            System.Console.WriteLine("'{0}'", MovieName);
            System.Console.WriteLine("{0} minutes ", Time);
        
        }
    }
}
