using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTutorial.Tutorial
{

    public interface ILogger
    {
        /// <summary>
        /// Defines the log level
        /// </summary>
        LogLevel LogLevel { get; set; }

        /// <summary>
        /// The event fired if a message is about to be fired
        /// </summary>
        event Action<string, LogLevel> OnLogMessage;

        /// <summary>
        /// Logs the specified message
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="level">The log level of message</param>
        void LogMesage(string message, LogLevel level = LogLevel.Verbose);
    }


    public enum LogLevel
    {
        Verbose = 0,

        Debug = 1,

        Critical = 2
    }

}
