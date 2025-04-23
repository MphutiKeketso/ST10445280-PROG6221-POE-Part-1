using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part1
{
    class Display
    {

        private int option;
        public static List<string> textFiles = new List<string>();
        public static List<string> topics = new List<string>();

        public Display(int option)
        {

            this.option = option;
        }




        public bool topicResponse()
        {
            bool isValid = true;
            if (option == 1) Console.WriteLine("You have selected the topic of Phishing");
            else if (option == 2) Console.WriteLine("You have selected the topic of Malware");
            else if (option == 3) Console.WriteLine("You have selected the topic of Ransomware");
            else if (option == 4) Console.WriteLine("You have selected the topic of Social Engineering");
            else if (option == 5) Console.WriteLine("You have selected the topic of Passwords");
            else if (option == 6) Console.WriteLine("You have selected the topic of Firewalls");
            else if (option == 7) Console.WriteLine("You have selected the topic of Antivirus Software");
            else if (option == 8) Console.WriteLine("You have selected the topic of Encryption");
            else if (option == 9) Console.WriteLine("You have selected the topic of Network Security");
            else if (option == 10) Console.WriteLine("You have selected the topic of Cyber Security");
            else if (option == 11) additionalHelp();
            else if (option == 12) Console.WriteLine("Goodbye");
            else
            {
                Console.WriteLine("Invalid option selected");
                isValid = false;
            }
            return isValid;
        }


        public static void additionalHelp()
        {
            Console.WriteLine("Need additional help? Or maybe just a casual conversation\nWhat ever you need I am here to help you\nYou can ask questions like 'How are you?', 'What's your purpose?', and 'What can I ask about?'\nPlease enter your question: ");
            
        }


        public static void DisplayMainMenu()
        {
            Console.WriteLine("\nPlease select a number that correspondes to the topic that you have a question about\n1. Phishing\n2. Malware\n3. Ransomware\n4. Social Engineering\n5. Passwords\n6. Firewalls\n7. Antivirus Software\n8. Encryption\n9. Network Security\n10. Cyber Security\n11. Help\n12. Exit");
           
        }


        public static void AddTextFiles()
        {
            string filePath = @"C:\example\file.txt"; 



            // Replace with your file path
            textFiles.Add("Resources/Phishing.txt");
            textFiles.Add("Resources/Malware.txt");
            textFiles.Add("Resources/Ransomware.txt");
            textFiles.Add("Resources/Social engineering.txt");
            textFiles.Add("Resources/Passwords.txt");
            textFiles.Add("Resources/Firewalls.txt");
            textFiles.Add("Resources/Antivirus Software.txt");
            textFiles.Add("Resources/Encryption.txt");
            textFiles.Add("Resources/Network Security.txt");
            textFiles.Add("Resources/Cybersecurity.txt");

            for (int i = 0; i < 10; i++)
            {
              try
              {
                    // Read the entire file at once
                    topics.Add(File.ReadAllText(textFiles[i]));                
              }
            catch (Exception ex)
              {
                Console.WriteLine($"Error: {ex.Message}");
              }  
            }

            
        }



       

    }
}
