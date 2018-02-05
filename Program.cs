using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Dictionary also called : Hash Map
             * Examples: SSN, Coat Check
             * Takes the term and then looks up with definition paired with it.
             * all keys must be unique, but values can be repeated.
             */

            //<Data type for key, value data type>, NEW keyword think exstantiating.
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                // {Key, value}
                {"Kary",90 },
                {"Barry", 85 },
                {"Michelle", 100 }
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //Using the add method, let's add drinks to our drink machine
            //This machine uses just a number to vend an item insead of a letter - number pair

            drinkMachine.Add(10, "Ginger ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Root Beer");
            drinkMachine.Add(13, "Mountain Dew");
            drinkMachine.Add(14, "Sprite");
            drinkMachine.Add(15, "Dr. Pepper");

            //Count is a property not a method so no (), Returns size of dictionary
            Console.WriteLine(drinkMachine.Count);

            //We have another property, called .Key
            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                //Prints keys 
                Console.WriteLine(drink.Key);
            }
            
            //For each loops make a local variable that assigns it each time, "Magic"
            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {001, "Hoodie" },
                {002, "Jacket" },
                {003, "Trench" },
                {004, "Rain" },
                {005, "Fur" },
                {006, "Leather" },
                {007, "Suit" },
                {008, "Childrens" },
                {009, "Bomber" },
                {010, "Sweatshirt" }

            };

            Dictionary<string, string> valet = new Dictionary<string, string>();

            valet.Add("Beasly", "Ford");
            valet.Add("Helpert", "Chevy");
            valet.Add("Hudson", "BMW");
            valet.Add("Bernard", "Ford");
            valet.Add("Palmer", "Dodge");
            valet.Add("Scott", "Sebring");
            valet.Add("Shrute", "Chevy");
            valet.Add("Howard", "Volkswagan");
            valet.Add("Kapour", "Volkswagan");
            valet.Add("Bratton", "Mercedes");

            Dictionary<string, int> zooAnimal = new Dictionary<string, int>()
            {
                {"Lion", 3 },
                {"Elephant", 5 },
                {"Hippo", 2 },
                {"Giraffe", 7 },
                {"Zebra", 5 },
                {"Gorilla", 4 },
                {"Komodo Dragon", 2 },
                {"Leopard", 6 },
                {"Rhino", 1 },
                {"Walrus", 3 },
                {"Polar Bear", 4 }

            };
           



            //Prints the highest quantity 
            int highest = 0;
            foreach(KeyValuePair<string, int> animal in zooAnimal)
            {
                if(animal.Value > highest)
                {
                    highest = animal.Value;
                } 
                
            }

            foreach(KeyValuePair<string, int> animal in zooAnimal)
            {
                if(animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }

           

            
           
             //See last side of Dictionaries for homework and research Dict properties and methods   
           

            



        }
    }
}
