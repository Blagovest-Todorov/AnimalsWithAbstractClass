using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                if (line == "Beast!")
                {
                    break;
                }

                string[] animalData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                

                if (animalData.Length != 3)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string name = animalData[0];
                int age = int.Parse(animalData[1]); // TryParse ? ?? exception ????
                string gender = animalData[2];

                if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(gender) || age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (line == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(cat);
                }
                else if (line == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog);
                }
                else if (line == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog);
                }
                else if (line == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine(kitten);
                }
                else if (line == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
    }
}
