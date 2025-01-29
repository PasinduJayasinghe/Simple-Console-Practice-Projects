using System;
namespace ShortCutsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter you age");
            int age=Convert.ToInt32(Console.ReadLine());
            string details = userDetails(name, age);
            Console.WriteLine(details);
            Console.ReadLine();
        }

        static string userDetails(string name, int age)
        {
            return $"your name : {name} your age : {age}";
        }
    }
}