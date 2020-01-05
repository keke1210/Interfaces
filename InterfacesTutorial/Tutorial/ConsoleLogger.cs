using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTutorial.Tutorial
{
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Defines the log output level
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// The event thats fired when a message is about to be logged
        /// </summary>
        public event Action<string, LogLevel> OnLogMessage = (message, level) => { };

        /// <summary>
        /// Logs the message to the console
        /// </summary>
        /// <param name="message">The message</param>
        public void LogMesage(string message, LogLevel level)
        {
            // If this message is important
            if(level >= LogLevel)
            {
                //Inform listeners
                OnLogMessage(message, LogLevel);

                //Log it
                Console.WriteLine($"Console logger says: {message}");
            }
               
        }
    }
}
