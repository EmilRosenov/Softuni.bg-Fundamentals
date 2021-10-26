using System;

namespace _01.ImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string[] inputString = Console.ReadLine().Split('|');
            while (inputString[0]!= "Decode")
            {
                if (inputString[0] == "Decode")
                {
                    Console.WriteLine($"The decrypted message is: {encryptedMessage}");
                    return;
                }

                string command = inputString[0];
                if (command=="Move")
                {
                    int numberLetters = int.Parse(inputString[1]);
                    string substring = encryptedMessage.Substring(0, numberLetters);
                    encryptedMessage = encryptedMessage.Replace(substring, "");
                    encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length, substring);
                }
                else if (command == "Insert")
                {
                    int idex = int.Parse(inputString[1]);
                    string value = inputString[2];
                    encryptedMessage = encryptedMessage.Insert(idex, value);

                }
                else if (command == "ChangeAll")
                {
                    string substring = inputString[1];
                    string replacement = inputString[2];

                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
                inputString = Console.ReadLine().Split('|');
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
