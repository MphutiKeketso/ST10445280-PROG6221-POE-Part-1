using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part1
{
    class BackEnd : Display
    {
        public int option;
        public BackEnd(int option) : base(option)
        {
            if (option < 1 || option > 12)
                throw new ArgumentOutOfRangeException("option must be between 0 and 12");
            this.option = option;
        }
    
        private string answer;
        

        public String basicResponse()
        {
        
            answer = Console.ReadLine();
            if (answer == "How are you?") return ("I'm well and yourself?");
            else if (answer == "I'm good") return ("Thats good to hear, is there anything I can help you with today?");
            else if (answer == "I'm well") return ("Thats good to hear, is there anything I can help you with today?");
            else if (answer == "I'm okay") return ("Thats good to hear, is there anything I can help you with today?");
            else if (answer == "What's your purpose") return ("My purpose is to answer your Cyber-Security questions");
            else if (answer == "What can I ask about") return ("You can ask about various Cyber-Security based on the different topics given\n Please select a number that correspondes to the topic that you have a queation about");
            else
            {
                return ("I'm sorry, I don't understand the question");
            }
        }


        


        public  void BackendManager()
        {
          
            BackEnd backEnd = new BackEnd(option);
            if (option == 11)
            {
                additionalHelp();
                Console.WriteLine(basicResponse());
            }
            else if (option == 12)
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
                Console.ReadKey();
            }
            else
            {
                backEnd.topicResponse();
                if (backEnd.topicResponse()== true)
                {
                    DisplayInformartion(option);
                    Console.WriteLine("\n\nPress enter to continue");
                    string input = Console.ReadLine();
                }
            }
            
        }


        


        public static void DisplayInformartion(int option)
        {
            for (int i = 0; i < 10; i++)
            {
                if ((option-1) == i)
                {
                    Console.Write(topics[i]);
                    
                }
            }
        }

    }
}
