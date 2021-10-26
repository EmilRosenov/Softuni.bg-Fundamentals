using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ProgFundFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listPieceComposerKey = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input1 = Console.ReadLine().Split('|');
                string piece = input1[0];
                string composer = input1[1];
                string key = input1[2];

                if (!listPieceComposerKey.ContainsKey(piece))
                {
                    listPieceComposerKey.Add(piece, new List<string>());
                    listPieceComposerKey[piece].Add(composer);
                    listPieceComposerKey[piece].Add(key);
                }

            }
            string[] input = Console.ReadLine().Split('|');
            while (input[0]!="Stop")
            {
                string command = input[0];
                if (command == "Add")
                {
                    string songName = input[1];
                    string composerName = input[2];
                    string key = input[3];
                    if (!listPieceComposerKey.ContainsKey(songName))
                    {
                        listPieceComposerKey.Add(songName, new List<string>());
                        listPieceComposerKey[songName].Add(composerName);
                        listPieceComposerKey[songName].Add(key);
                        Console.WriteLine($"{songName} by {composerName} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already in the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    string songName = input[1];
                    if (!listPieceComposerKey.ContainsKey(songName))
                    {
                        Console.WriteLine($"Invalid operation! {songName} does not exist in the collection.");
                    }
                    else
                    {
                        listPieceComposerKey.Remove(songName);
                        Console.WriteLine($"Successfully removed {songName}!");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string songName = input[1];
                    string newKey = input[2];
                    if (!listPieceComposerKey.ContainsKey(songName))
                    {
                        Console.WriteLine($"Invalid operation! {songName} does not exist in the collection.");
                    }
                    else
                    {
                        listPieceComposerKey[songName][1] = newKey;
                        Console.WriteLine($"Changed the key of {songName} to {newKey}!");
                        
                    }
                }




                input = Console.ReadLine().Split('|');
            }

            listPieceComposerKey = listPieceComposerKey.OrderBy(x => x.Key).ThenBy(y => y.Value[0]).ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in listPieceComposerKey)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
