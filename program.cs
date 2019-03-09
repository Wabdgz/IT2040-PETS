using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);
            Console.WriteLine("Name: " + pet1.name + "\nWeight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());
            Console.WriteLine("\n\n");

            Dog dog1 = new Dog("Daisy", "Kent", 23.4);
            Console.WriteLine("Name: " + dog1.name + "\nWeight: " + pet1.weight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.Bark(4));
            Console.WriteLine("\n\n");

            Cat cat1 = new Cat("Simba","Maria",5.2);
            Console.WriteLine("Name: " + cat1.name + "\nWeight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.Meow(3));
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }
    }
}
