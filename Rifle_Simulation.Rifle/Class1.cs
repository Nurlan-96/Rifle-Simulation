using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Rifle_Simulation.Rifle
{
    public class Rifle
    {
        public void Shoot()
        {
            int bullets = 30;
            Console.WriteLine("Choose 'Auto' or 'Single' as firing mode");
            string FireMode = Console.ReadLine();
            Console.WriteLine("Write 'Shoot'");
            string Command = Console.ReadLine();
            if (FireMode == "Auto")
            {
                if (Command == "Shoot")
                {
                    while (bullets > 0)
                    {
                        Console.WriteLine("BANG");
                        bullets--;
                    }
                }
            }
            if (FireMode == "Single")
            {
                if (Command == "Shoot")
                {
                    Console.WriteLine("BANG");
                    bullets--;
                    Console.WriteLine($"bullets={bullets}");
                    while (bullets > 0) 
                    {
                        Command = Console.ReadLine();
                        Console.WriteLine("BANG");
                        bullets--;
                        Console.WriteLine($"bullets={bullets}");
                    }
                }
            }
            if (bullets == 0)
            {
                Console.WriteLine("You are out of bullets. Do you want to change the clip?");
                string ChangeClip = Console.ReadLine();
                if ((ChangeClip == "yes"))
                {
                    Console.WriteLine("Clip changed");
                    bullets = 30;
                    Console.WriteLine($"bullets={bullets}");
                    Shoot();
                }
                else return;
            }
        }
    }
}