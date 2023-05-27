using MyApp.Services.Factories.Implementations;
using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MyApp.Services.Factories;

// Logging levels
//    "DEBUG",
//    "INFO",
//    "WARNING",
//    "ERROR",
//    "FATAL"

namespace MyApp.WinForm
{
    public class Logger
    {
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        
        public Logger(Main main, IServiceFactory serviceFactory) 
        {
            ServiceFactory = serviceFactory;
            Main = main;
        }
        public void WriteFileLog(string severity, string message)
        {

            // Log path
            string logFilePath = "C:\\Logs\\log.txt";

            using(StreamWriter logger = new StreamWriter(logFilePath, true)) // append argument true to add to log.txt
            {
                logger.WriteLine(
                    $"{DateTime.Now}: {severity.ToUpper()}: {message}");
            }
        }

        public string GetLogFilePath()
        {
            return "C:\\Logs\\log.txt";
        }
    }
}
