#region
using System;
#endregion

namespace LogWriter
{

    /// <summary>
    /// Log container object
    /// </summary>
    public class Log
    {

        /// <summary>
        /// Content of log
        /// </summary>
        private string LogMessage;

        /// <summary>
        /// Log timestamp
        /// </summary>
        private DateTime LogTime;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Logged message</param>
        public Log(string message)
        {
            LogMessage = message;
            LogTime = DateTime.Now;
        }

        /// <summary>
        /// Log message accessor
        /// </summary>
        /// <returns>Log message</returns>
        public string GetMessage()
        {
            return LogMessage;
        }

        /// <summary>
        /// Get the time from log timestamp
        /// </summary>
        /// <returns>Time</returns>
        public string GetTime()
        {
            return LogTime.ToString("hh:mm:ss.fff tt");
        }

        /// <summary>
        /// Get the date from log timestamp
        /// </summary>
        /// <returns>Date</returns>
        public string GetDate()
        {
            return LogTime.ToString("yyyy-MM-dd");
        }

    }

}