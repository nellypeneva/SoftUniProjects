using System; 
using System.Linq;
using System.Text.RegularExpressions; 

namespace _04_WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            string winningPattern = @"([$]{6,9}|[@]{6,9}|[\^]{6,9}|[#]{6,9})";
            string jackpotPatternFull = @"([$]{20}|[@]{20}|[\^]{20}|[#]{20})"; 

            Regex jackpotRegex = new Regex(jackpotPatternFull);
            Regex winningRegex  = new Regex(winningPattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                } 
 
                bool jackpotMatch = jackpotRegex.IsMatch(ticket);

                if (jackpotMatch)
                {
                    Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!", ticket, ticket[0]);
                    continue;
                }

                string ticketLeftPart = ticket.Substring(0, 10);
                string ticketRightPart = ticket.Substring(10, 10);

                if (!winningRegex.IsMatch(ticketLeftPart) || !winningRegex.IsMatch(ticketRightPart))
                {
                    Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    continue;
                } 

                Match winningLeftMatch = winningRegex.Match(ticketLeftPart);
                Match winningRightMatch = winningRegex.Match(ticketRightPart);

                ticketLeftPart = winningLeftMatch.Groups[1].ToString();
                ticketRightPart = winningRightMatch.Groups[1].ToString();

                if (ticketLeftPart[0] != ticketRightPart[0])  //example ^$$$$$$$$$$$@@@@@@@^
                {
                    Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    continue;
                }

                int length = Math.Min(ticketLeftPart.Length, ticketRightPart.Length); 
                Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, length, ticketLeftPart[0]); 
            }
        }
    }
}
 