//Author:   William Tye Hartanovich
//Date:     11/10/2020

using static System.Console; //reduce clutter of read/write statements

namespace InvoiceCloud_ScreeningChallenge
{
    /// <summary>
    /// Prints the numbers 1 through 100.  
    /// Multiples of 3 are replaced with "Invoice".  
    /// Multiples of 5 are replaced with "Cloud".  
    /// Multiples of both are replaced with "InvoiceCloud"
    /// </summary>
    class NumberPrinterWithTextReplacement
    {

        //main method
        static void Main(string[] args)
        {
            //define an inclusive range of numbers to print
            int lowerBound = 1; //this is the starting number
            int upperBound = 100; //this is the ending number

            //multiples of these numbers will be replaced with text.
            int firstMultiple = 3; 
            int secondMultiple = 5;

            string firstMultipleText = "Invoice"; //replace the first multiple with this
            string secondMultipleText = "Cloud"; //replace the second multiple with this
            string currentOutput = ""; //this text will be modified if a multiple was detected


            //loop through all the numbers in range, replacing multiples with text and printing to the console
            for (int number = lowerBound; number <= upperBound; number++)
            {
                //check if the number is a multiple and concatenate the text if true
                if(number % firstMultiple == 0)
                {
                    currentOutput += firstMultipleText;
                }
                if (number % secondMultiple == 0)
                {
                    currentOutput += secondMultipleText;
                }
                //NOTE: multiples of both are accounted for


                //if currentOutput was not modified, print the number
                if(currentOutput == "")
                {
                    WriteLine( number.ToString() ); //convert the integer to a string
                }

                //the currentOutput string was modified so print it
                else
                {
                    WriteLine( currentOutput );
                }
                
                currentOutput = "";  //nullify the string before the next loop iteration
            }

            ReadKey(); //keep the console window open until a key is pressed.
        }
    }
}