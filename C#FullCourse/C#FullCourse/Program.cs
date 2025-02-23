using System;

namespace Structures
{
    class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthmonth;

            public Person(string name,int age,int birthmonth)
            {
                this.name = name;                
                this.age = age;
                this.birthmonth = birthmonth;
            }
        }
        static void Main(string[] args)
        {
            Person person=ReturnPerson();
            Console.WriteLine($"{person.name} {person.age} {person.birthmonth}");
            Console.ReadLine();

        }
        static Person ReturnPerson() {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth month");
            int birthmonth=Convert.ToInt32(Console.ReadLine());
            /*Person person;
            person.name = name;
            person.age = age;
            person.birthmonth = birthmonth;
            return person;*/
            return new Person(name,age,birthmonth);
        } 

    }
}