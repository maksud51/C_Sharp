using System;

namespace Class1
{
    class Animal
    {
        public string name;
        public int age;
        public string voice;
        public static int animalCount = 0;

        public void printDetails()
        {
            Console.WriteLine("Name: " + name + " Age: " + age + " Voice: " +voice);
           
        }

        //class constructor
        public Animal(string _name, int _age, string _voice)
        {
            name = _name;
            age = _age;
            voice = _voice;
            animalCount++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal ob1 = new Animal("maksud", 1, "Tolk");
            ob1.printDetails();

            Animal ob2 = new Animal("Cat", 2, "Mew");
            ob2.printDetails();


            Animal ob3 = new Animal("Dog", 3, "Gew");
            ob3.printDetails();

            Console.WriteLine("number of Animal: " + Animal.animalCount);
        }
    }
}
