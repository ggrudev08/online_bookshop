using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookshop.Presentation
{
    internal class Display
    {
        public Display()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(Logo());
            Console.WriteLine("1. Author");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Customer");
            Console.WriteLine("4. Oreder");
            Console.WriteLine("5. Exit");
        }

        private string Logo()
        {

            string logo = @"
    /$$$$$$             /$$  /$$                         /$$$$$$$                         /$$                  /$$                             
   /$$__  $$           | $$ |__/                        | $$__  $$                       | $$                 | $$                             
  | $$  \ $$  /$$$$$$$ | $$  /$$  /$$$$$$$  /$$$$$$     | $$  \ $$   /$$$$$$    /$$$$$$  | $$   /$$  /$$$$$$$ | $$$$$$$    /$$$$$$    /$$$$$$   
  | $$  | $$ | $$__ $$ | $$ | $$ | $$__ $$ /$$__  $$    | $$$$$$$   /$$__  $$  /$$__  $$ | $$  /$$/ /$$_____/ | $$__  $$  /$$__  $$  /$$__  $$  
  | $$  | $$ | $$  \$$ | $$ | $$ | $$  \$$ |$$$$$$$$    | $$__  $$ | $$  \ $$ | $$  \ $$ | $$$$$$/  |  $$$$$$ | $$  \ $$ | $$  \ $$ | $$  \ $$ 
  | $$  | $$ | $$  |$$ | $$ | $$ | $$  |$$ |$$_____/    | $$  \ $$ | $$  | $$ | $$  | $$ | $$_  $$   \____ $$ | $$  | $$ | $$  | $$ | $$  | $$  
  |  $$$$$$/ | $$  |$$ | $$ | $$ | $$  |$$ | $$$$$$$    | $$$$$$$/ |  $$$$$$/ |  $$$$$$/ | $$ \ $$  /$$$$$$$/ | $$  | $$ |  $$$$$$/ | $$$$$$$/  
   \______/  |__/  |__/|__/ |__/ |__/  |__/ \_______/   |_______/   \______/   \______/  |__/  \__/ |_______/ |__/  |__/  \______/  | $$____/   
                                                                                                                                    | $$         
                                                                                                                                    | $$         
                                                                                                                                    |__/         ";

            return logo;
        }


        private void Input()
        {
            bool is_running = true;
            while (is_running = true)
            {
                ShowMenu();
                int operation = int.Parse(Console.ReadLine());

                if (operation == 5)
                    break;

                switch (operation)
                {
                    case 1:
                        {
                            new AuthorDisplay();
                            break;
                        }
                    case 2:
                        {
                            new BookDisplay();
                            break;
                        }
                    case 3:
                        {
                            new CustomerDisplay();
                            break;
                        }
                    case 4:
                        {
                            new OrderDisplay();
                            break;
                        }

                    case 5:
                        {
                            is_running = false;
                            break;
                        }
                    default:
                        break;
                }
            }

        }
    }
}