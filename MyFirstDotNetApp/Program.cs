using System;

namespace MyFirstDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Asam", 23);
            Console.WriteLine("Hello " + p.name);

            p.name = "Assssaaaam";
            Console.WriteLine("Hello " + p.name + " på " + p.age + " år");

        }
    }
}
