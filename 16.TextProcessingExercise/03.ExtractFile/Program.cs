using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int filePathLength = filePath.Length;
            string fileExtension = string.Empty;
            string fileName = string.Empty;

           
                int indexOfDot = filePath.IndexOf(".");
                int fileExtensionLenght = filePathLength - indexOfDot;
                fileExtension = filePath.Substring(indexOfDot+1, fileExtensionLenght-1);
            

            int indexOfLastSlash = filePath.LastIndexOf((char)92);
            int filenameLength = filePathLength - indexOfLastSlash - fileExtensionLenght;

            fileName = filePath.Substring(indexOfLastSlash+1, filenameLength-1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
