using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3.Challenge1
{
    class Transformer
    {
        public void Run()
        {
            string ability = ChooseVehicleAbility();
            Ability vehicleAbility = ConvertStringToEnumValue(ability);
            Vehicle vehicle = null;
            while (vehicleAbility != Ability.None)
            {
                switch (vehicleAbility)
                {
                    case Ability.Air:
                        Console.Write("Air Vehicle choosen.\n");
                        vehicle = new Jet();
                        vehicle.Run();
                        break;
                    case Ability.Road:
                        Console.Write("Road Vehicle choosen.\n");
                        vehicle = new Car();
                        vehicle.Run();
                        break;
                    case Ability.Water:
                        Console.Write("Water Vehicle choosen.\n");
                        vehicle = new Boat();
                        vehicle.Run();                        
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                ability = ChooseVehicleAbility();
                vehicleAbility = ConvertStringToEnumValue(ability);
            };
        }

        private static Ability ConvertStringToEnumValue(string ability)
        {
            return (Ability)Enum.Parse(typeof(Ability), ability);
        }

        private string ChooseVehicleAbility()
        {
            string abilityInText;
            Console.WriteLine("1. Air");
            Console.WriteLine("2. Road");
            Console.WriteLine("3. Water");
            Console.WriteLine("4. None");
            Console.WriteLine("The abilities your vehicle can have are listed above.");
            Console.Write("Choose by writing the number in front of the ability you would like: ");

            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                abilityInText = "Air";
            }
            else if (number == 2)
            {
                abilityInText = "Road";
            }
            else if (number == 3)
            {
                abilityInText = "Water";
            }
            else
            {
                abilityInText = "None";
            }
            return abilityInText;
        }
    }
}
