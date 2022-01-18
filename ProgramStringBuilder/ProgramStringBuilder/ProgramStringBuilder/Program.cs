using ProgramStringBuilder.Entitites;
using System;

namespace ProgramStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Faça uma boa Viagem!");
            Comment c2 = new Comment("Ual que incrivel!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para Nova Zelandia",
                "Eu estou visitando este país maravilhoso",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa Noite");
            Comment c4 = new Comment("Que a força esteja com você");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
