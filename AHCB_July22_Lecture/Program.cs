using System;
using System.Text.RegularExpressions;

namespace AHCB_July22_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now we're going to enter a list of integers.");

            int[] integersList = GetIntegers();
            int sumOfIntegers = GetSumOfIntegers(integersList);
            int productOfIntegers = GetProductOfIntegers(integersList);

            Console.WriteLine($"Sum of all integers in list: {sumOfIntegers}");
            Console.WriteLine($"Product of all integers in list: {productOfIntegers}");

            int hopefullySomeVowels = GetNumberOfVowels();

            Console.WriteLine($"You entered this many vowels: {hopefullySomeVowels}");
        }

        static int ValidateIntegerInput(string messageToUser, string errorMessage)
        {
            while(true) {

                Console.WriteLine(messageToUser);
                bool userInput = int.TryParse(Console.ReadLine(), out int result);

                if (userInput)
                {
                    return result;
                }

                Console.WriteLine(errorMessage);
            }
        }

        static int[] GetIntegers()
        {
            int[] integersList = new int[5];
            for(int i = 0; i < integersList.Length; i++)
            {
                integersList[i] = ValidateIntegerInput(
                    "Enter an integer.",
                    "That's not an integer.");
            }

            return integersList;
        }

        static int GetSumOfIntegers(int[] listOfIntegers)
        {
            int sum = 0;

            for (int i = 0; i < listOfIntegers.Length; i++)
            {
                sum += listOfIntegers[i];
            }

            return sum;
        }

        static int GetProductOfIntegers(int[] listOfIntegers)
        {
            int product = 1;

            for (int i = 0; i < listOfIntegers.Length; i++)
            {
                product *= listOfIntegers[i];
            }

            return product;
        }

        static int GetNumberOfVowels()
        {
            Console.WriteLine("Enter a string, preferably including some letters.");
            string userInput = Console.ReadLine();
            int numberOfVowels = 0;

            foreach(char letter in userInput)
            {
                if(letter.Equals('a') ||
                    letter.Equals('A') ||
                    letter.Equals('e') ||
                    letter.Equals('E') ||
                    letter.Equals('i') ||
                    letter.Equals('I') ||
                    letter.Equals('o') ||
                    letter.Equals('O') ||
                    letter.Equals('u') ||
                    letter.Equals('U'))
                {
                    numberOfVowels++;
                }
            }

            return numberOfVowels;
        }
    }
}
