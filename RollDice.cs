using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// break down the logic
// need to use an array

// allow user to choose the number of rolls

// *second class
// receive the number of rolls

// for that number of rolls
// simulate the roll of die1
// simulate the roll of die2
// get the total
// for that total, add 1 to the results

//return the results to the first class

//*first class
//for each possible number
// print the number
// calculate what percentage that number was rolled

// print astericks for each percentage



namespace Mission_2
{
    internal class RollDice
    {
        public RollDice()
        {

        }

        public void PrintResult(int roll_req)
        {

            // call the random number generator class
            Random r = new Random();

            // this is my code to run through until the number of rolls is reached
            int die1 = 0;
            int die2 = 0;

            int[] results = new int[13];

            // simulate the roll for the number of times the user specified. save the number rolled in an array.
            for (int count = 0; count < roll_req; count++)
            {
                die1 = r.Next(1, 7);
                die2 = r.Next(1, 7);

                results[die1 + die2]++;
            }

            // Write the printed code per assignment criteria
            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS" + "\n" +
                "Each '*' represents 1% of the total number of rolls." + "\n" +
                "Total number of rolls = " + roll_req + "." + "\n");

            // Print results
            for (int i = 2; i < 13; i++)
            {

                // calculate what percentage that number was rolled. print astericks for each percentage
                int percentage = results[i] * 100 / roll_req;
        
                Console.WriteLine(i + ": " + new string('*', percentage));
            }

            Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
