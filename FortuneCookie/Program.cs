using System.Runtime.Intrinsics.Arm;

namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor for random numbers
            Random rand = new Random(); 

            //test randomness and range with a for loop
            for (int i = 0; i < 10; i++)
            {
                //rand.Next(min,max) max is not inclusive
                int n = rand.Next(1, 21); // Random number between 1 and 6

                //Fortune cookie Messages
                switch (n)
                {
                    case 1:
                        Console.WriteLine("A well - timed reboot will solve more than one problem today.");
                        break;
                    case 2:
                        Console.WriteLine("Your circuit will close when you stop forcing the current.");
                        break;
                    case 3:
                        Console.WriteLine("Like a Spartan, patience and preparation will win the next encounter.");
                        break;
                    case 4:
                        Console.WriteLine("A small redstone tweak will unlock a much bigger build.");
                        break;
                    case 5:
                        Console.WriteLine("Even the strongest armor needs occasional repairs—take care of yourself.");
                        break;
                    case 6:
                        Console.WriteLine("Today’s bug is tomorrow’s feature… if you learn from it.");
                        break;
                    case 7:
                        Console.WriteLine("A rival may push you harder than a friend ever could. Embrace it.");
                        break;
                    case 8:
                        Console.WriteLine("Your inventory is full—drop what you don’t need to move forward.");
                        break;
                    case 9:
                        Console.WriteLine("The signal is weak now, but the transmission will get through.");
                        break;
                    case 10:
                        Console.WriteLine("Great power requires better cable management.");
                        break;
                    case 11:
                        Console.WriteLine("A new path opens when you stop following the waypoint.");
                        break;
                    case 12:
                        Console.WriteLine("Like a hero swinging through the city, momentum matters more than speed.");
                        break;
                    case 13:
                        Console.WriteLine("Your design doesn’t need perfection—just one solid iteration.");
                        break;
                    case 14:
                        Console.WriteLine("A hidden choice will determine the ending more than you expect.");
                        break;
                    case 15:
                        Console.WriteLine("Trust the process; even the best AI starts with simple logic gates.");
                        break;
                    case 16:
                        Console.WriteLine("Not every boss is meant to be defeated head-on.");
                        break;
                    case 17:
                        Console.WriteLine("Your controller isn’t broken—your timing just needs calibration.");
                        break;
                    case 18:
                        Console.WriteLine("Today’s side quest will reward you later in the main story.");
                        break;
                    case 19:
                        Console.WriteLine("When the system crashes, you’ll discover what really matters.");
                        break;
                    case 20:
                        Console.WriteLine("You are closer to the checkpoint than you think. Save progress.");
                        break;
                }
            }

            //pause
            Console.Read();
        }
    }
    }
