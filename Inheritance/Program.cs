using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal-DONE
            // give this class 4 members that all Animals have in common-DONE


            // Create a class Bird -DONE
            // give this class 4 members that are specific to Bird -DONE
            // Set this class to inherit from your Animal Class -DONE

            // Create a class Reptile -DONE
            // give this class 4 members that are specific to Reptile -DONE
            // Set this class to inherit from your Animal Class -DONE




            /*Create an object of your Bird class-DONE
             *  give values to your members using the object of your Bird class-DONE
             *  
             * Creatively display the class member values -DONE
             */
            var eagle = new Bird();
            eagle.Age = 4;
            eagle.AirSpeed = 32;
            eagle.Aquatic = false;
            eagle.BirdSound = "FREEDOM";
            eagle.Carnivore = true;
            eagle.Flies = true;
            eagle.Herbivore = false;
            eagle.Limbs = 4;

            Console.WriteLine($"I have a pet eagle who is {eagle.Age} years old, flies at {eagle.AirSpeed} miles per hour, shrieking {eagle.BirdSound}");

            /*Create an object of your Reptile class -DONE
             *  give values to your members using the object of your Reptile class -DONE
             *  
             * Creatively display the class member values -DONE
             */
            var komodoDragon = new Reptiles();
            komodoDragon.Age = 18;
            komodoDragon.Carnivore = true;
            komodoDragon.ChangesColor = false;
            komodoDragon.Herbivore = false;
            komodoDragon.Limbs = 4;
            komodoDragon.Regenerates = true;
            komodoDragon.ReptileSound = "hissssss";
            komodoDragon.Venomous = true;

            Console.WriteLine($"The Komodo Dragon is a deadly beast!  They live up to {komodoDragon.Age} years and make a ferocious {komodoDragon.ReptileSound}");
        }
    }
}
