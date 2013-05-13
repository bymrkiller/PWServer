namespace PWServer.Core.Utils
{
    using System;
    using System.Runtime.InteropServices;

    internal class Printer
    {
        public static void AddStatus(string s, string Status, ConsoleColor Color = 10)
        {
            if ((Status.ToUpper() == "ERROR") && (Color == ConsoleColor.Green))
            {
                Color = ConsoleColor.Red;
            }
            while (((s.Length + Status.Length) + 4) < 0x4f)
            {
                s = s + " ";
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(s + "[ ");
            Console.ForegroundColor = Color;
            Console.Write(Status);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ]");
        }

        public static void Error(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ERROR] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(DateTime.Now + "> " + s);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void Fatal(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[FATAL] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Concat(new object[] { DateTime.Now, "> ", s, "\n\nНажмите любую кнопку для выхода..." }));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void InCenter(string text, string background_symbol = " ")
        {
            bool flag = false;
            while (text.Length < 0x4f)
            {
                if (flag)
                {
                    text = background_symbol + text;
                    flag = false;
                }
                else
                {
                    text = text + background_symbol;
                    flag = true;
                }
            }
            Console.WriteLine(text);
        }

        public static void Info(string s, ConsoleColor Background = 0)
        {
            if (Background != ConsoleColor.Black)
            {
                Console.BackgroundColor = Background;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            string str = "[INFO] ";
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
            string str2 = DateTime.Now + "> " + s;
            if (Background != ConsoleColor.Black)
            {
                while (str2.Length < (0x4f - str.Length))
                {
                    str2 = str2 + " ";
                }
            }
            Console.WriteLine(str2);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void Line(string symbol = "-")
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string str = symbol;
            while (str.Length < 0x4f)
            {
                str = str + symbol;
            }
            Console.WriteLine(str);
        }

        public static void Log(string s)
        {
            Console.WriteLine(string.Concat(new object[] { "[LOG] ", DateTime.Now, "> ", s }));
        }

        public static void RedLine(string text)
        {
            while (text.Length < 0x4f)
            {
                text = text + " ";
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void Section(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            s = "[ " + s + " ]";
            while (s.Length < 0x4f)
            {
                s = '-' + s;
            }
            Console.WriteLine(s);
        }

        public static void Warn(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[WARN] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(DateTime.Now + "> " + s);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void WhiteLine(string text)
        {
            while (text.Length < 0x4f)
            {
                text = text + " ";
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void YellowLine(string text)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

