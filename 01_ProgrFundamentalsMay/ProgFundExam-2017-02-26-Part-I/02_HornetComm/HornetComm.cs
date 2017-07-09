using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _02_HornetComm
{
    public class HornetComm
    {
        public static void Main()
        {
            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();

            string messagePattern = @"^(\d+) <-> ([A-Za-z0-9]+)$";
            string broadcastPattern = @"^(\D+) <-> ([A-Za-z0-9]+)$";

            Regex regexMessage = new Regex(messagePattern);
            Regex regexBroadcast = new Regex(broadcastPattern);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Hornet is Green")
                {
                    break;
                }

                if (regexMessage.IsMatch(line))
                {
                    Match match = regexMessage.Match(line);
                    string recipient = String.Join("", match.Groups[1].Value.Reverse());
                    string message = match.Groups[2].Value;

                    messages.Add(recipient + " -> " + message);
                }

                if (regexBroadcast.IsMatch(line))
                {
                    Match match = regexBroadcast.Match(line);
                    string message = match.Groups[1].Value;
                    string frequency = match.Groups[2].Value;
                    frequency = DecryptMessage(frequency);

                    broadcasts.Add(frequency + " -> " + message);
                }

            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");  
            }
            else
            {
                Console.WriteLine(String.Join(Environment.NewLine, broadcasts));  
            }

            Console.WriteLine("Messages:");

            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(String.Join(Environment.NewLine, messages));
            }
        } 

        public static string DecryptMessage(string msg)
        {
            string result = String.Empty;

            foreach (char ch in msg)
            {
                if (char.IsLetter(ch))
                {
                    if (char.IsUpper(ch))
                    {
                        result += char.ToLower(ch);
                    }
                    else
                    {
                        result += char.ToUpper(ch);
                    }
                }
                else if (char.IsDigit(ch))
                {
                    result += ch;
                }
            }

            return result;
        }
    }
} 