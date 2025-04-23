using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace POE_Part1
{
    class GUI : Display
    {
        

        public String Name { get; set; }

        public static void StartDisplayGUI()
        {
            // Console.SetWindowSize(1980, WindowHeight);
            Console.SetWindowSize(180, 50);
            Console.BackgroundColor = ConsoleColor.Black;            
            Console.WriteLine("              NNNN             NNNNNNNN   EEEEEEEEEEEEEEEE   OOOOOOOO  HHHHH         HHHHH   AAAAAA                              CCCCCCCCCCC");
            Console.WriteLine("            NNNNNNNN         NNNNNNNN   EEEEEEEEEEEEEEEE   OOOOOOOOOOOO  HHHHH         HHHHH   AAAAAAAAAAAA                    CCCCCCC   CCCCCCC");
            Console.WriteLine("          NNNNNNNNNNNN     NNNNNNNN   EEEEEEEE           OOOOOO    OOOOOO  HHHHH         HHHHH   AAAAAA   AAAAAA                 CCCCCCC      CCCCCCC");
            Console.WriteLine("        NNNNNNN NNNNNNN NNNNNNNN   EEEEEEEEEEEEEEEE   OOOOOO    OOOOOO       HHHHHHHHHHHHHHHHHHH   AAAAAA      AAAAAA              CCCCCCC");
            Console.WriteLine("      NNNNNNN     NNNNNNNNNNNN   EEEEEEEEEEEEEEEE   OOOOOO    OOOOOO           HHHHHHHHHHHHHHHHHHH   AAAAAAAAAAAAAAAAAAAAA           CCCCCCC     ");
            Console.WriteLine("    NNNNNNN         NNNNNNNN   EEEEEEEE           OOOOOO     OOOOOO              HHHHH         HHHHH   AAAAAA            AAAAAA        CCCCCCC     CCCCCCC");
            Console.WriteLine("  NNNNNNN            NNNNN   EEEEEEEEEEEEEEEE      OOOOOOOOOOOOOO                  HHHHH         HHHHH   AAAAAA               AAAAAA     CCCCCCC   CCCCCCC");
            Console.WriteLine("NNNNNNN               NN   EEEEEEEEEEEEEEEE         OOOOOOOOOOO                      HHHHH         HHHHH   AAAAAA                  AAAAAA    CCCCCCCCCCC");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
                       
        }


        public void GUIManiuplation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            GUI gui2 = new GUI(Name);
            StartDisplayGUI();
            gui2.PersonalizedGreeting();
            DisplayMainMenu();
            
        }


        public GUI(String name) : base(0)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name cannot be empty or null");
            Name = name;
        }

        public void PersonalizedGreeting()
        {
            Console.WriteLine("Hi " +Name );
            Console.WriteLine("Is there aything I can help you with today?");
        }


        public static void Play()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Resources/greeting.wav");
                player.PlaySync();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("[Error: The audio file was not found. Please ensure it exists at the specified location.]");
            }
            catch (Exception e)
            {
                Console.WriteLine("[Error playing audio: " + e.Message + "]");
            }


        }
    }
}
