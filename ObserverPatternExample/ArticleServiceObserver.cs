//------------------------------------------------------------------------
// <copyright file="ArticleServiceObserver.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace ObserverPatternExample
{
    public class ArticleServiceObserver
    {
        /// <summary>
        /// The publish
        /// </summary>
        public Publisher publish;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleServiceObserver"/> class.
        /// </summary>
        /// <param name="publish">The publish.</param>
        public ArticleServiceObserver(Publisher publish)
        {
            this.publish = publish;
        }

        /// <summary>
        /// Adds the new article.
        /// </summary>
        /// <param name="articleName">Name of the article.</param>
        public void AddNewArticle(string articleName)
        {
            publish.SendMessgae("nuevo artículo disponible: " + articleName);
        }
    }
}
