using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfacesTutorial.Tutorial
{
    public class FileLogger : ILogger
    {
        private readonly string mLogPath;

        /// <summary>
        /// Defines the log output level
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// The event thats fired when a message is about to be logged
        /// </summary>
        public event Action<string, LogLevel> OnLogMessage = (message, level) => { };


        public FileLogger(string logPath)
        {
            mLogPath = logPath;

            var directory = Path.GetDirectoryName(mLogPath);

            Directory.CreateDirectory(directory);
        }



        /// <summary>
        /// Writes a message to the end of file
        /// </summary>
        /// <param name="message"></param>
        public void LogMesage(string message, LogLevel level)
        {
            // If this message is important
            if (level >= LogLevel)
            {
                // Open log file
                using (var fileStream = new StreamWriter(File.OpenWrite(mLogPath)))
                {
                    // Move to the end of file
                    fileStream.BaseStream.Seek(0, SeekOrigin.End);

                    // Write the new Line in the file
                    fileStream.WriteLine(message);
                }
            }
        }


    }
}
