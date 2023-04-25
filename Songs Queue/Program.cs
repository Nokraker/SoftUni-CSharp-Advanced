using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(
                Console.ReadLine()
                .Split(", ")
            );

            while (songs.Count > 0)
            {
                List<string> commands = Console.ReadLine()
                    .Split(" ")
                    .ToList();

                string cmnd = commands[0];

                if (cmnd == "Play")
                {
                    songs.Dequeue();
                }
                else if (cmnd == "Add")
                {
                    string newSong = SongName(commands);

                    if (!songs.Contains(newSong))
                    {
                        songs.Enqueue(newSong);
                    }
                    else
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                }
                else if (cmnd == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }

        private static string SongName(List<string> commands)
        {
            commands.RemoveAt(0);

            return string.Join(" ", commands);
        }
    }
}
