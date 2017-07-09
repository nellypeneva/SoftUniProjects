using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _04_RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main()
        {
            string pattern = @"(\d+)\s+#([A-Za-z0-9]+)\s*((?:@[A-Za-z\'\-]+\s*)*)?";
            //this will match participant name like @roli@trophon 

            Regex reg = new Regex(pattern);
            List<Event> results = new List<Event>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Time for Code")
                {
                    break;
                }
 
                Match match  = reg.Match (input);
                if (match.Success)
                {
                    int id = int.Parse(match.Groups[1].Value);
                    string name = match.Groups[2].Value;
                    string[] participants = new string[0];
                    //participants = match.Groups[3].Value.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);  

                    if (input.Contains("@"))
                    {
                        string participantsNames = input.Substring(input.IndexOf("@"));
                        participants = participantsNames.Split("@ ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);  
                    }

                    if (results.Any(x => x.Id == id))
                    {
                        Event evn = results.FirstOrDefault(x => x.Id == id);

                        if (evn.Name != name)
                        {
                            continue;
                        }
 
                        foreach (var p in participants)
                        {
                            evn.Participants.Add(p);
                        }

                    }
                    else
                    {
                        results.Add(new Event(id, name, participants));
                    }
                } 
            }

            results = results.OrderByDescending(x => x.Participants.Count()).ThenBy(x => x.Name).ToList();

            foreach (Event evn in results)
            {
                Console.WriteLine("{0} - {1}", evn.Name, evn.Participants.Count);
                foreach (string p in evn.Participants)
                {
                    Console.WriteLine("@{0}",p);
                } 
            }
        }

        public class Event
        {
            public Event(int id, string name, string[] arr)
            {
                this.Id = id;
                this.Name =  name;
                this.Participants = new SortedSet<string>(arr);
            }

            public string Name { get; set; }
            public int Id { get; set; }
            public SortedSet<string> Participants { get; set; }
        }
    }
}


//string pattern = @"[0-9a-zA-Z]+\s+#[0-9a-zA-Z]+\s*(@[a-zA-Z]+\s*)*";
//string pattern = @"(\d+)\s+#(?<event>[A-Za-z0-9]+)\s+(?<participants>(?:@[A-Za-z'-]+\s?)*)"; //(@([A-Za-z'-]+\s?))+
//string pattern = @"(\d+)\s+#([A-Za-z0-9]+)\s+((?:@[A-Za-z'-]+\s+)*)";

/*
 "Split(new char[] { }...." хваща whitespace, а "Split(new char[] { ' ' }...." хваща само спейс (единично празно място).
 */

//pattern = @"(?<id>\d+)\s+#(?<eventName>[A-Za-z0-9]+)(\s+(?:@[A-Za-z\'\-]+\s+)+)?"; 
//pattern = @"(\d+)\s+#([A-Za-z0-9]+)(\s+(?:@[A-Za-z'-]+)+)?";