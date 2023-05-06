using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> codes = new HashSet<string>();
            HashSet<string> vipCodes = new HashSet<string>();
            string command;
            bool partyStarted = false;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyStarted = true;
                    continue;
                }

                if (partyStarted)
                {
                    codes.Remove(command);
                    vipCodes.Remove(command);
                }
                else
                {
                    if (char.IsDigit(command[0]))
                    {
                        vipCodes.Add(command);
                    }
                    else
                    {
                        codes.Add(command);
                    }

                }
            }

            Console.WriteLine(codes.Count + vipCodes.Count);
            foreach (var item in vipCodes)
            {
                Console.WriteLine(item);
            }
            foreach (var item in codes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
