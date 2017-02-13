using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample
{
    public class Publisher
    {
        /// <summary>
        /// delegate
        /// </summary>
        /// <param name="message">The message.</param>
        public delegate void Notifier(string message);

        /// <summary>
        /// The notifier
        /// </summary>
        Notifier notifier;

        /// <summary>
        /// Attaches the specified notifier.
        /// </summary>
        /// <param name="notifier">The notifier.</param>
        public void Attach(Notifier notifier)
        {
            this.notifier += notifier;
        }

        /// <summary>
        /// Removes the specified notifier.
        /// </summary>
        /// <param name="notifier">The notifier.</param>
        public void Remove(Notifier notifier)
        {
            this.notifier -= notifier;
        }

        /// <summary>
        /// Sends the messgae.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SendMessgae(string message)
        {
            if (this.notifier != null)
                notifier(message);
        }
    }
}
