using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables

        //ctor
        public Game()
        {
            
        }
        //member methods

        public void QuitGame()
        {
            //quit game option always available to user
            //type quit at any time to quit
            //will display final stats as if it is the end of the game
        }

        public void BeginGame()
        {
            Console.WriteLine("██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗ ");
            Console.WriteLine("██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝ ");
            Console.WriteLine("██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗   ");
            Console.WriteLine("██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝   ");
            Console.WriteLine("╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗ ");
            Console.WriteLine(" ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝ ");
            System.Threading.Thread.Sleep(800);
            
            Console.Clear();

            Console.WriteLine(" ████████╗ ██████╗ ");
            Console.WriteLine("╚══██╔══╝██╔═══██╗");
            Console.WriteLine("   ██║   ██║   ██║");
            Console.WriteLine("   ██║   ██║   ██║");
            Console.WriteLine("   ██║   ╚██████╔╝");
            Console.WriteLine("   ╚═╝    ╚═════╝ ");
            System.Threading.Thread.Sleep(800);

            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("██╗     ███████╗███╗   ███╗ ██████╗ ███╗   ██╗ █████╗ ██████╗ ███████╗");
                Console.WriteLine("██║     ██╔════╝████╗ ████║██╔═══██╗████╗  ██║██╔══██╗██╔══██╗██╔════╝");
                Console.WriteLine("██║     █████╗  ██╔████╔██║██║   ██║██╔██╗ ██║███████║██║  ██║█████╗  ");
                Console.WriteLine("██║     ██╔══╝  ██║╚██╔╝██║██║   ██║██║╚██╗██║██╔══██║██║  ██║██╔══╝  ");
                Console.WriteLine("███████╗███████╗██║ ╚═╝ ██║╚██████╔╝██║ ╚████║██║  ██║██████╔╝███████╗");
                Console.WriteLine("╚══════╝╚══════╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝╚═════╝ ╚══════╝");


                Console.WriteLine("███████╗████████╗ █████╗ ███╗   ██╗██████╗ ");
                Console.WriteLine("██╔════╝╚══██╔══╝██╔══██╗████╗  ██║██╔══██╗");
                Console.WriteLine("███████╗   ██║   ███████║██╔██╗ ██║██║  ██║");
                Console.WriteLine("╚════██║   ██║   ██╔══██║██║╚██╗██║██║  ██║");
                Console.WriteLine("███████║   ██║   ██║  ██║██║ ╚████║██████╔╝");
                Console.WriteLine("╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ");

                if (i == 3)
                {
                    System.Threading.Thread.Sleep(1500);
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                }
                
                Console.Clear();

                System.Threading.Thread.Sleep(500);
            }

        }


        public void StartDay()
        {
            Console.Clear();
            Console.WriteLine("Ready for business!");
            Console.WriteLine("Press enter to begin day.");
            Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("..");
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(100);
                Console.Clear();
            }
            

        }

        //last line of big block
    }
}
