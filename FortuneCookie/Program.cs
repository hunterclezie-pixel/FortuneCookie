using System.Runtime.Intrinsics.Arm;

namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor for random numbers
            Random rand = new Random();
            string[] fortune = new string[11];

            //test randomness and range with a for loop
            Console.WriteLine("Your fortune is...");

            //Fortune cookie Messages
            fortune[0] = "A well - timed reboot will solve more than one problem today.";
            fortune[1] = "Your circuit will close when you stop forcing the current.";
            fortune[2] = "Like a Spartan, patience and preparation will win the next encounter.";
            fortune[3] = "A small redstone tweak will unlock a much bigger build.";
            fortune[4] = "Even the strongest armor needs occasional repairs—take care of yourself.";
            fortune[5] = "Today’s bug is tomorrow’s feature… if you learn from it.";
            fortune[6] = "A rival may push you harder than a friend ever could. Embrace it.";
            fortune[7] = "The signal is weak now, but the transmission will get through.";
            fortune[8] = "Great power requires better cable management.";
            fortune[9] = "Like a hero swinging through the city, momentum matters more than speed.";
            fortune[10] = "Today’s side quest will reward you later in the main story.";

            for (int i = 0; i < 1; i++)
            {
                //rand.Next(min,max) max is not inclusive
                int n = rand.Next(0, 10); // Random number between 1 and 10
                Console.WriteLine($"{fortune[n]}");
            }

            //pause
            Console.Read();
        }
    }
}
