using SimpleFactory.Enums;
using SimpleFactory.Factory;
using SimpleFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Menu
{
    public static class WeaponMenu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("=== Weapon Selection Menu ===");
            Console.WriteLine("Choose your weapon:");
            Console.WriteLine("1 - Gun");
            Console.WriteLine("2 - Magic Staff");
            Console.WriteLine("3 - Sword");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(WeaponType), choice))
            {
                WeaponType selectedType = (WeaponType)choice;
                IWeapon weapon = WeaponFactory.CreateWeapon(selectedType);

                Console.WriteLine($"\nYou selected: {selectedType}\n");

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nChoose an action:");
                    Console.WriteLine("1 - Attack");
                    Console.WriteLine("2 - Defend");
                    Console.WriteLine("3 - Use Skill");
                    Console.WriteLine("4 - Recover");
                    Console.WriteLine("0 - Exit");
                    Console.Write("Action: ");
                    var action = Console.ReadLine();

                    switch (action)
                    {
                        case "1":
                            weapon.Atack();
                            break;
                        case "2":
                            weapon.Shield();
                            break;
                        case "3":
                            weapon.Skill();
                            break;
                        case "4":
                            weapon.Reload();
                            break;
                        case "0":
                            exit = true;
                            Console.WriteLine("Exiting battle...");
                            break;
                        default:
                            Console.WriteLine("Invalid action. Try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }

            Console.WriteLine("\nProgram ended. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
