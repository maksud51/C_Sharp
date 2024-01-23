using System;

namespace Inheritence
{
    class Animal
    {
        public string name;
        public int Age;
        public string color;

        public void printDetails() 
        {
            Console.WriteLine("Name: " +name + " Age: " +Age + " Color: " +color);
        }

    }

    class Dog :Animal
    {
        public string bred;

        public void Sound()
        {
            Console.WriteLine("Dog sound: Gew");
        }

        public Dog(string _name, int _Age, string _color, string _bred) 
        {
            name = _name;
            Age = _Age;
            color = _color;
            bred = _bred;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog ob1 = new Dog("maksud", 2, "red", "sibarian");
            ob1.printDetails();
            Console.WriteLine(ob1.bred);
            ob1.Sound();
        }
    }
}
