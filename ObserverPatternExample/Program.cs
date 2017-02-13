//------------------------------------------------------------------------
// <copyright file="Program.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace ObserverPatternExample
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Publisher pub = new Publisher();

            Person per1 = new Person("Antonio");
            pub.Attach(per1.GotArticle);

            Person per2 = new Person("Manuel");
            pub.Attach(per2.GotArticle);

            ArticleServiceObserver observer = new ArticleServiceObserver(pub);
            observer.AddNewArticle("Delegados en C#");

            pub.Remove(per2.GotArticle);

            observer.AddNewArticle("Observer pattern");

            Console.Read();
        }
    }
}
