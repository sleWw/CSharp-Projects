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
            double result;
            result = firstNumber / secondNumber;
            return result;
        }
        public static double UnitPrice (double price, double quantity)
        {
            double result;
            result = price / quantity;
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
