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
using System.Diagnostics;
using System.ServiceModel.Channels;
using MyApp.Models;
using Microsoft.VisualBasic.Logging;


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
        public readonly Dictionary<int, List<string>> Logs;
        public Logger(Main main, IServiceFactory serviceFactory)
        {
            ServiceFactory = serviceFactory;
            Main = main;
            Logs = new Dictionary<int, List<string>>();
        }
        public void Log(string severity, string message, User user)
        {
            // Add to file log.txt
            string logFilePath = "C:\\Logs\\log.txt";

            using (StreamWriter logger = new StreamWriter(logFilePath, true)) // append argument true to add to log.txt
            {
                logger.WriteLine(
                    $"{DateTime.Now}: {severity.ToUpper()}: User Id {user.Id}: {user.Forename} {user.Surname}: {message}");
            }

            // Add to Logs dictionary
            int length = Logs.Count;
            List<string> entry = new List<string> { DateTime.Now.ToString(), $"[{severity.ToUpper()}]", user.Id.ToString(), message };
            Logs.Add(length, entry);
        }

        public string GetLogFilePath()
        {
            return "C:\\Logs\\log.txt";
        }
    }
}
