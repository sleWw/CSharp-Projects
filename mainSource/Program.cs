using System;
using System.Collections.Generic;

namespace mainSource
{
    class Program
    {
        public static void ConsoleEditor()
        {
            Console.Title = "ConsoleProject";
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WindowHeight = 35;
            //Console.WindowWidth = 150;
        }
        public static bool EndingCode()
        {
            bool returnTo;
            ConsoleKeyInfo clientAnswer;
            Console.WriteLine("Press 'Space' to End Program");            
            clientAnswer = Console.ReadKey();
            if(clientAnswer.Key != ConsoleKey.Spacebar){
            Console.WriteLine();  
            returnTo = false;
            } else returnTo = true;
            return returnTo;
        } 
        public static double UnitRate (double firstNumber, double secondNumber)
        {
            /*
            A unit rate is defined as a ratio that compares the first quantity to one unit of the second quantity.
             The two quantities being compared have different units.

            Example: A Pottery Factory Produces 176 Pots in 8 Hours How many Pots do they make an Hour?
            Formula: AmountOfItems / Unit (in this case hours)
            176 / 8 = 22
            the Rate is 22/1
            so They make 22 Pots an Hour

            */
            double result;
            result = firstNumber / secondNumber;
            return result;
        }
        public static double UnitPrice (double totalPrice, double quantity)
        {
            /*
            A unit price is the price for one item or measurement, such as a pound, a kilogram, or a pint,
             which can be used to compare the same type of goods sold in varying weights and amounts

            Example: 55 Bananas Cost $132 how much does one banana cost?
            Formula TotalPrice / TotalItems
            $132 / 55 = $2.4
            Each banana cost $2.4
            */
            double result;
            result = totalPrice / quantity;
            return result;
        }
        public static double FindQuantity(double firstNumurator, double firstDenominator, double secondDenominator)
        {
            double multipliedNumbers = firstNumurator * secondDenominator;
            double unknownQuantity = multipliedNumbers / firstDenominator;
            return unknownQuantity;
        }

        public static int FindGreatestFactor(int number)
        {

            int greatestFactor = 5;
            return greatestFactor;
        }

        public static string[] FindFactors(int findFactor)
        {
            List<string> factorList = new List<string>();

            int sum = 0;
            int multiplier = 1;
            int multiplyee = 0;
            int lastMultiplier = multiplier;
            int lastMultiplyee = multiplyee;
            for(int i = 0; i < 101; i++)
            {
               sum = multiplyee * multiplier;
               if(lastMultiplier == multiplyee && lastMultiplyee == multiplier) 
               { //This statement ends the Method once all Factors have been found
                   goto exit;
               }
  
               if(sum == findFactor)
                {
                    string factorFound = multiplier.ToString() + " x " + multiplyee.ToString() + " = " + sum.ToString();
                    factorList.Add(factorFound);

                    if(multiplier == multiplyee & sum == findFactor)
                    {
                        goto exit;
                    }
                    lastMultiplier = multiplier;
                    lastMultiplyee = multiplyee;
                    multiplier++;
                    multiplyee = 1;
                    sum = 0;
                    i = 0;
                }
               else if(sum > findFactor)
                {
                    multiplier++;
                    multiplyee = 1;
                    i = 0;
                }
               else
                {
                   multiplyee++;
                }
            }
            
            exit:
            string[] factorArray = factorList.ToArray();
            return factorArray;
        }   
        
        static void Main(string[] args)
        {
            ConsoleEditor();
            bool returnTo; // variable for checking if "space" is pressed

            /*TO DO
            Middle School Math Book
            Make a Function that finds the Greatest Factor
            Make a Function that finds the Common Factors between 2 ints
            Make a Function that finds the LCM
            Make a Function that finds the GCM 

            */

        //WORKING SPACE=======================================================================
            
            string[] factorArray = FindFactors(87);
            for(int i = 0; i < factorArray.Length; i++)
            {
                Console.WriteLine(factorArray[i]);
            }

            Console.WriteLine(UnitRate(300,15));
            Console.WriteLine(FindQuantity(8, 5, 19));
                        

            
        //WORKING SPACE=======================================================================
            end:
            returnTo = EndingCode(); //Console Automatically closes this keeps it open until "space" is pressed
            if(!returnTo) goto end;
        }
    }
}
