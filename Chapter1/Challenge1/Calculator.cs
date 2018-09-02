using System;
using System.Collections.Generic;
using Chapter1.Challenge2;

namespace Chapter1.Challenge1
{
    class Calculator
    {
        public void CalculatorProgram()
        {            
            WriteCalculatorInformationMessage();

            string userInput = Console.ReadLine();                       

            while(userInput != "N")
            {
                if(userInput == "Y" || userInput == "y")
                {
                    WriteCalculatorInformationMessage();
                    userInput = Console.ReadLine();
                }

                switch (userInput)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Substraction();
                        break;
                    case "3":
                        Multiplication();
                        break;
                    case "4":
                        Division();
                        break;
                    default:
                        WriteCalculatorInformationMessage();
                        break;
                }
                Console.WriteLine("Do you want to continue (Y/N): ");
                userInput = Console.ReadLine();
            }                        
        }
    
        private static void Addition()
        {         
            List<int> listWithIntegers = GetUserInputValues();
            int result = listWithIntegers[0] + listWithIntegers[1];
            Console.WriteLine($@"{listWithIntegers[0]} + {listWithIntegers[1]} = {result}");
        }    

        private static void Substraction()
        {
            List<int> listWithIntegers = GetUserInputValues();
            int result = listWithIntegers[0] - listWithIntegers[1];
            Console.WriteLine($@"{listWithIntegers[0]} - {listWithIntegers[1]} = {result}");
        }

        private static void Multiplication()
        {
            List<int> listWithIntegers = GetUserInputValues();
            int result = listWithIntegers[0] * listWithIntegers[1];
            Console.WriteLine($@"{listWithIntegers[0]} * {listWithIntegers[1]} = {result}");
        }

        private static void Division()
        {
            List<int> listWithIntegers = GetUserInputValues();
            int result = listWithIntegers[0] / listWithIntegers[1];
            Console.WriteLine($@"{listWithIntegers[0]} / {listWithIntegers[1]} = {result}");
        }

        private static List<int> GetUserInputValues()
        {
            List<int> listWithValuesToAdd = new List<int>();
            Console.Write("Enter Value 1: ");
            string valueOne = Console.ReadLine();            
            listWithValuesToAdd.Add(Int32.Parse(valueOne));
            Console.Write("Enter Value 2: ");
            string valueTwo = Console.ReadLine();            
            listWithValuesToAdd.Add(Int32.Parse(valueTwo));
            return listWithValuesToAdd;
        }

        private static void WriteCalculatorInformationMessage()
        {
            Console.WriteLine("Press any key to perform an aritmetic operation: ");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division\n\n");
        }
    }
}
