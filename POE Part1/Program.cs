// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            GUI.Play();
            Console.ForegroundColor = ConsoleColor.Red;
            String name="";
            while (name == "")
            {
                GUI.StartDisplayGUI();
                Console.WriteLine("Welcome to NEOHAC. I'm Neo, your chatbot assistant");
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
                try
                {
                    int option = 0;
                    GUI gui2 = new GUI(name);
                    Display.AddTextFiles();
                    bool run = true;
                    while (option == 0 || run == true)
                    {
                        gui2.GUIManiuplation();
                        try
                        {
                            Console.WriteLine("");
                            option = Convert.ToInt32(Console.ReadLine());
                            BackEnd backEnd = new BackEnd(option);
                            backEnd.BackendManager();
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            Console.WriteLine("Press enter to try again");
                            string input2 = Console.ReadLine();

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                           
                        }
                    }
                    

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Press enter to try again");
                    string input = Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }

            Console.ReadKey();
        }
    }
}