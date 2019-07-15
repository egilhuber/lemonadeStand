using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        UserInterface newInterface = new UserInterface();
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


        public void StartDay(bool noLoad)
        {
            Console.Clear();
            Console.WriteLine("Ready for business!");
            Console.WriteLine("Press enter to begin day.");
            Console.ReadLine();
            Console.Clear();
            if (noLoad == true)
            {
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
            else if (noLoad == false)
            {
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
                newInterface.Lemons();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Squeezing lemons.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Squeezing lemons..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Squeezing lemons...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Spilling sugar.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Spilling sugar..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Spilling sugar...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Crushing ice.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Crushing ice..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Crushing ice...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Giving out samples.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Giving out samples..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Giving out samples...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Taking inventory.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Taking inventory..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Taking inventory...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Counting money.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Counting money..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Counting money...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Closing up shop.");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Closing up shop..");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("Closing up shop...");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
            }
            
        }

        //last line of big block
    }
}
