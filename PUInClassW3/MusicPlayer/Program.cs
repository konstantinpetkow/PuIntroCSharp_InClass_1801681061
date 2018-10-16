using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();

            if (answer == "Yes")
            {
                Console.WriteLine("Playing music ....");

                using (SoundPlayer player = new SoundPlayer(@"D:\PUWorkFolder\PuIntroCSharp_InClass_1801681061\Music\GAZIROVKA_Black_Bass_Boosted-0wbJJgLz1sI.wav"))
                {
                    // Use PlaySync to load and then play the sound.
                    // ... The program will pause until the sound is complete.
                    player.PlaySync();

                }
          }
            else if (answer == "No")
            {
                Console.WriteLine("GoodBye!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }


        
           // Console.WriteLine("Hello koce");
        }
    }
}
