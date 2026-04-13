using System;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    public static class AsciiArt
    {
        static string logo = @"

 _____       _                 _____                      _ _          ______       _   
/  __ \     | |               /  ___|                    (_) |         | ___ \     | |  
| /  \/_   _| |__   ___ _ __  \ `--.  ___  ___ _   _ _ __ _| |_ _   _  | |_/ / ___ | |_ 
| |   | | | | '_ \ / _ \ '__|  `--. \/ _ \/ __| | | | '__| | __| | | | | ___ \/ _ \| __|
| \__/\ |_| | |_) |  __/ |    /\__/ /  __/ (__| |_| | |  | | |_| |_| | | |_/ / (_) | |_ 
 \____/\__, |_.__/ \___|_|    \____/ \___|\___|\__,_|_|  |_|\__|\__, | \____/ \___/ \__|
        __/ |                                                    __/ |                  
       |___/                                                    |___/                   

";

        public static void ShowCentered()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] lines = logo.Split('\n');

            foreach (string line in lines)
            {
                int padding = (Console.WindowWidth - line.Length) / 2;
                if (padding > 0)
                    Console.WriteLine(new string(' ', padding) + line);
                else
                    Console.WriteLine(line);
            }

            Console.ResetColor();

            Thread.Sleep(5000);
        }

        public static void ShowTop()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(logo);
            Console.ResetColor();
        }
    }
}