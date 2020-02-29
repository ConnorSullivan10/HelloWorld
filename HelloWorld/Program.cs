using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a dialect");
            foreach (var arg in args) 
            {
                Console.WriteLine(arg);
            }

	        string dialect = Console.ReadLine().ToLower();
            Console.WriteLine("Now please enter your name");
            string userName = Console.ReadLine();

            switch (dialect)
            {
                case "hillbilly":
                    Console.WriteLine($"Well darn tootin', howdy doody there {userName}");
                    break;
                case "jabba":
                    Console.WriteLine($"Go te te boomba sa la {userName}");
                    break;
                case "yoda":
                    Console.WriteLine($"Greetings old friend. Doing well, I hope you are {userName}");
                    break;
                default: Console.WriteLine($"Howdy {userName}!!");
                    break;

            }
	
            
            Console.ReadLine();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y'};
            foreach (var animal in animals)
            {
                var syllables = 0;
                foreach (var animalChar in animal)
                {
                    foreach (var vowel in vowels)
                    {
                        if (vowel == animalChar)
                        {
                            syllables++;
                        }
                    }
                }
                if (syllables >= 2)
                {
                    Console.WriteLine(animal);
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"What's your favorite color, {userName}?");
            string favColor = Console.ReadLine();
            // Creates a random object
            Random rand = new Random();
            // selects random index from array
            int index = rand.Next(animals.Length);
            Console.WriteLine($"Would you like to have a {favColor} {animals[index]}?");
        Console.ReadKey();
        }
    }
}
