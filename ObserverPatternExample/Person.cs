//------------------------------------------------------------------------
// <copyright file="Person.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace ObserverPatternExample
{
    using System;

    public class Person
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Person(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gots the article.
        /// </summary>
        /// <param name="message">The message.</param>
        public void GotArticle(string message)
        {
            Console.WriteLine(string.Format("Hola {0}, {1}", name, message));
        }
    }
}
