using System;

namespace MiniTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is trivia. Pick a topic: music, sports, or history\r\n");

            string ans = Console.ReadLine().ToLower();

            switch (ans)
            {
                case "music":
                Console.WriteLine("\r\nWhat stage name does virtuoso bassist Stephen Bruner go by?\r\n");
                    string music = Console.ReadLine().ToLower();
                    if (music == "thundercat")
                    {
                        Console.WriteLine("\r\nYou are correct.");
                    }
                    else
                    {
                        Console.WriteLine("\r\nwrong");
                    }
                    break;

                case "sports":
                    Console.WriteLine("\r\nWho has more Grand Slam titles, Venus or Serena Williams?\r\n");
                    string sports = Console.ReadLine().ToLower();
                    if (sports == "serena" | sports == "serena williams")
                    {
                        Console.WriteLine("\r\nYou are correct.");
                    }
                    else
                    {
                        Console.WriteLine("\r\nwrong");
                    }
                    break;

                case "history":
                    Console.WriteLine("\r\nWhat was Belle Isle called at one point in time: Hog, Beaver, or Wolverine Island?\r\n");
                  string history = Console.ReadLine().ToLower();
                   if (history == "hog" | history == "hog island")
                    {
                        Console.WriteLine("\r\nYou are correct.");
                    }
                    else
                    {
                        Console.WriteLine("\r\nwrong");
                    }
                    break;

                default:
                    Console.WriteLine("You must have misunderstood. Please try again.");
                    break;

                    

                



            }

            
        }
    }
}
