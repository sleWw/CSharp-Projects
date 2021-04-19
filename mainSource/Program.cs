﻿using System;
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
        //WORKING SPACE=======================================================================

            string[] factorArray = FindFactors(87);
            for(int i = 0; i < factorArray.Length; i++)
            {
                Console.WriteLine(factorArray[i]);
            }

            Console.WriteLine("Repository Test From Laptop");
            Console.WriteLine("Commit From Laptop");

            Console.WriteLine("Repository Test from PC");
            Console.WriteLine("Repository Test Complete");
            
        //WORKING SPACE=======================================================================
            end:
            returnTo = EndingCode(); //Console Automatically closes this keeps it open until "space" is pressed
            if(!returnTo) goto end;
        }
    }
}
