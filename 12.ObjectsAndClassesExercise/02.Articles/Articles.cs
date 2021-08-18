using System;
using System.Linq;

namespace Articles
{
    class exercisse2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

            Article article = new Article(input[0], input[1], input[2]);

            int numberCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommands; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();



                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article.ToString());
        }

        public class Article
        {
            public string Title;
            public string Content;
            public string Author;



            public Article(string title, string content, string author)
            {

                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public string Edit(string content)
            {
                this.Content = content;
                return Content;
            }
            public string ChangeAuthor(string author)
            {
                this.Author = author;
                return Author;
            }
            public string Rename(string title)
            {
                this.Title = title;
                return Title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
