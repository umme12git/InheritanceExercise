using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird  AnimalBird = new Bird();
            AnimalBird.TypeName = "Cardinal";
            AnimalBird.Age = 3;
            AnimalBird.Color = "blue";
            AnimalBird.Name = "bird";
            AnimalBird.Kind = "omnivores";
            AnimalBird.Legs = "two";
            AnimalBird.Sound = "cheer cheer";
            

            Console.WriteLine("Bird");
            Console.WriteLine("-----");

            Console.WriteLine($"The {AnimalBird.Name} {AnimalBird.TypeName} is {AnimalBird.Age} years old, it has color {AnimalBird.Color}. " +
                $"This {AnimalBird.Kind} kind animal has {AnimalBird.Legs} legs and can sound {AnimalBird.Sound}.");
            AnimalBird.Talks("loud");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile AnimalReptile = new Reptile();
            AnimalReptile.TypeName = "Sea turtle";
            AnimalReptile.Age = 1;
            AnimalReptile.Color = "brown";
            AnimalReptile.Name = "Reptile";
            AnimalReptile.Kind = "omnivores";
            AnimalReptile.Legs = "two";
            AnimalReptile.Sound = "cha cha";


            Console.WriteLine("Reptile");
            Console.WriteLine("-------");

            Console.WriteLine($"The {AnimalReptile.Name} {AnimalReptile.TypeName} is {AnimalReptile.Age} year old, it has color {AnimalReptile.Color}. " +
                $"This {AnimalReptile.Kind} kind animal has {AnimalReptile.Legs} legs and can sound {AnimalReptile.Sound}.");
            AnimalReptile.Crawl();


        }
    }
}
