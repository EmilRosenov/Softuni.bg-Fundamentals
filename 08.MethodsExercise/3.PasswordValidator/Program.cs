using System;

namespace _04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isValidLenght = PasswordHasBetweenSixAndTenChars(input);
            bool isConsistingOnlyLettersAndDigits = PasswordConsistsOnlyLettersAndDigits(input);
            bool isConsistingMinOfTwoDigits = PasswordMustHaveMinTwoDigits(input);


            if (isValidLenght == true &&
                isConsistingOnlyLettersAndDigits == true  &&
                isConsistingMinOfTwoDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!isValidLenght)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    
                }
                if (!isConsistingOnlyLettersAndDigits) 
                {
                   
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!isConsistingMinOfTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    
                }
            }
        }

        private static bool PasswordMustHaveMinTwoDigits(string input)
        {
           int counter = 0;
            foreach (char element in input)
            {
                if (char.IsDigit(element))
                {
                    counter++;
                }
                if (counter >= 2)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool PasswordConsistsOnlyLettersAndDigits(string input)
        {
            foreach  (char index in input)
            {
                if (!char.IsLetterOrDigit(index))
                {
                    return false;
                }    
            }
            return true;


        }

        private static bool PasswordHasBetweenSixAndTenChars(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
