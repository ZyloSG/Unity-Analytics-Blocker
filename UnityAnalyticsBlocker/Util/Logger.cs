using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityAnalyticsBlocker.Util
{
    public class Logger
    {
        public static readonly Logger Instance = new Logger();
        public void Log(string message, Enums.LogType mode)
        {
            switch (mode)
            {
                case Enums.LogType.Log:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"\n{GetCurrentDate()} ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"[Analytics Blocker] {message}");
                    Console.ResetColor();
                    break;
                case Enums.LogType.Error:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"\n{GetCurrentDate()} ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"[Analytics Blocker] {message}");
                    Console.ResetColor();
                    break;
                case Enums.LogType.Warn:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"\n{GetCurrentDate()} ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"[Analytics Blocker] {message}");
                    Console.ResetColor();
                    break;
            }
        }

        public string GetCurrentDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
