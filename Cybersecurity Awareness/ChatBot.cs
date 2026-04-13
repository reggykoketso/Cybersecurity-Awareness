using System;
using System.Threading;

namespace Cyber_Security_Awareness_Bot
{
    public class ChatBot
    {
        public string UserName { get; set; }

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPlease enter your name: ");
            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                UserName = Console.ReadLine();
            }

            Console.Clear();

            TypeEffect($"Hello {UserName.ToUpper()}! Welcome to the Cybersecurity Awareness Bot.\n");
            TypeEffect("You can ask me about passwords, phishing, safe browsing, malware, scams, or cybersecurity.\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Type 'exit' anytime to close the program.\n");

            ChatLoop();
        }

        private void ChatLoop()
        {
            string input;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{UserName.ToUpper()}: ");

                input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                if (input == "exit" || input == "quit" || input == "bye")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nStay safe online, Goodbye ");

                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            if (input.Contains("how are you"))
            {
                TypeEffect("I'm doing great! Thanks for asking. I'm here to help you stay safe online.");
            }
            else if (input.Contains("purpose") || input.Contains("why are you here"))
            {
                TypeEffect("My purpose is to educate people about cybersecurity awareness and how to stay safe online.");
            }
            else if (input.Contains("what can i ask") || input.Contains("what can you do") || input.Contains("help"))
            {
                TypeEffect("You can ask me about cybersecurity topics like passwords, phishing, malware, scams, or safe browsing.");
            }
            else if (input.Contains("password"))
            {
                TypeEffect("Use strong passwords with uppercase letters, lowercase letters, numbers, and symbols. Avoid using personal information and never reuse passwords.");
            }
            else if (input.Contains("phishing"))
            {
                TypeEffect("Phishing is when attackers trick you into revealing personal information through fake emails or websites.");
            }
            else if (input.Contains("safe browsing") || input.Contains("browsing"))
            {
                TypeEffect("Always check for HTTPS in the website address and avoid clicking unknown or suspicious links.");
            }
            else if (input.Contains("malware"))
            {
                TypeEffect("Malware is malicious software designed to harm or steal data from your computer. Install antivirus software and avoid downloading files from unknown sources.");
            }
            else if (input.Contains("scam") || input.Contains("scams"))
            {
                TypeEffect("Online scams often trick people into sending money or personal information. Always verify messages and offers before trusting them.");
            }
            else if (input.Contains("cybersecurity") || input.Contains("security"))
            {
                TypeEffect("Cybersecurity is the practice of protecting computers, networks, and data from cyber threats and hackers.");
            }
            else
            {
                TypeEffect("I'm still learning. Try asking me about passwords, phishing, malware, scams, or safe browsing.");
            }
        }

        private void TypeEffect(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            Console.WriteLine();
        }
    }
}