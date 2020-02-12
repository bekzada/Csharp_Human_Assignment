using System;

namespace Human
{
   public class Human
    {

        public string Name;
        public int Strength ;
        public int Intelligence;
        public int Dexterity;
        public int Health;

        public Human(string givenname)
        {
            Name = givenname;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;

        }
        public Human(string person, int strength, int dexterity, int health, int intelligence)
        {
            Name = person;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }


        public void Attack(Human target)   //here is my method   //daagi karap chigish kerek jakshy ishtebei ele
        {
            
            if(target ==null)
            {
               Console.WriteLine("Failed!"); 
            }
            else
            {
               target.Health -= Strength *5;


            }
            
        }
    }
    class Program
    {

        static void Main(string[] args)   // main koshkondon kiyin ishtei bashtadi   // without this piece of code ..is not working
        {
            Human Bella = new Human("Bella");
            Console.WriteLine(Bella.Health);
            Human Ilim = new Human("Ilim",400,400,5,200);
            Ilim.Attack(Bella);
            Console.WriteLine(Bella.Health);
        }
    }
}
 