using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            

            List<Article> listOfArticles = new List<Article>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article newArticle = new Article(title, content, author);
                listOfArticles.Add(newArticle);
            }

            string givenCriteria = Console.ReadLine();

            if (givenCriteria == "title")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Title).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
            }
            else if (givenCriteria == "content")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Content).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
            }
            else if (givenCriteria == "author")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Author).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
            }
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

           public override string ToString()
           {
               return $"{Title} - {Content}: {Author}";
           }
        }
    }
}
