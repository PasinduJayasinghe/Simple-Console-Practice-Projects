using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public class Manager
    {
        public List<Person> people;
        public Manager() {
            people = new List<Person>()
            {
                new Person(1,"Doe",20),
                new Person(2,"Smith",30)
            };
            PrintMenu();
        }
        public void PrintMenu()
        {
            Console.WriteLine("Welcome to my management system"+Environment.NewLine);
            Console.WriteLine("1. Print all users");
            Console.WriteLine("2. Add user");
            Console.WriteLine("3. Edit user");
            Console.WriteLine("4. Search user");
            Console.WriteLine("5. Remove user");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter your menu option");

            bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);
            if (tryParse) {
                Console.WriteLine(menuOption);

                if (menuOption == 1)
                {
                    PrintAll();
                    Console.Clear();
                }
                else if (menuOption == 2)
                {
                    AddUser();

                }
                else if (menuOption == 3)
                {
                    EditUser();
                }
                else if (menuOption == 4) { 
                    SearchUser();
                }
                if (menuOption >= 1 && menuOption <= 5)
                {
                    PrintMenu();
                }
            }
            else {
                OutputMessage("Incorrect menu choice");
                PrintMenu();
            }
        }

        public void PrintAll()
        {
            StartingOption("Printing all users");

            if (people.Count == 0)
            {
                Console.WriteLine("There are no users");
            }
            else
            {
                PrintAllUsers();
            }
            
            FinishOption();
        }
        public void AddUser()
        {
            StartingOption("Adding a user");

            try
            {
                int id = people.Count + 1;
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                int age = Convert.ToInt32(Console.ReadLine());

                if (!string.IsNullOrEmpty(name))
                {
                    if (age >= 0 && age <= 150)
                    {
                        Person person = new Person(id,name, age);
                        people.Add(person);
                        FinishOption();
                    }
                    else {
                        OutputMessage("Please enter a valid age");
                    }
                }
                else
                {
                    OutputMessage("Please enter a name");
                }
               

            }
            catch (Exception)
            {
                OutputMessage("Something went wrong");

                AddUser();
            }
            

            
        }
        public void EditUser() {
            StartingOption("Editing a user");
            if (people.Count == 0) {
                Console.WriteLine("There are no users to edit");
            }
            else
            {
                try
                {
                    PrintAllUsers();
                    Console.WriteLine("Please select a user to edit");
                    //bool isNumberValid = int.TryParse(Console.ReadLine(), out int userNumber);
                    int userNumber=Convert.ToInt32(Console.ReadLine());
                    if (userNumber!=null)
                    {
                        Console.WriteLine("User you want to edit " +people[userNumber].Id+ people[userNumber].Name + " " + people[userNumber].Age);
                        Console.WriteLine("Enter the name");
                        string newName = Console.ReadLine();
                        if (newName != null)
                        {
                            people[userNumber].Name = newName;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a name");
                        }
                        Console.WriteLine("Please enter the age");
                        int age = Convert.ToInt32(Console.ReadLine());
                        if (age >= 0 && age <= 150)
                        {
                            people[userNumber].Age = age;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid age");
                        }
                    }

                }
                catch (Exception)
                {

                    OutputMessage("Something went wrong");
                    EditUser();
                }
                
            }
            FinishOption();
        }
        public Person SearchUser() {
            StartingOption("Searching a user");

            if (people.Count == 0)
            {
                Console.WriteLine("There is no users");
                SearchUser();
            }
            else
            {
                Console.WriteLine("Enter the name of the user");
                string nameInput = Console.ReadLine();

                if (string.IsNullOrEmpty(nameInput))
                {
                    foreach (Person person in people)
                    {
                        if (person.Name == nameInput)
                        {
                            return person;
                        }
                    }
                }

            }

            return null;
            FinishOption();
        }
        public void RemoveUser() {
            StartingOption("Removing a user");
            if (people.Count == 0)
            {
                Console.WriteLine("There are no users to remove");
            }
            else
            {
                PrintAllUsers();
                Console.WriteLine("Enter the number of user you want to remove");
                int removeNumber=Convert.ToInt32(Console.ReadLine()) - 1;

                if (removeNumber >= 0 && removeNumber <= people.Count - 1)
                {
                    people.RemoveAt(removeNumber);
                    Console.WriteLine("Successfull removed");
                    FinishOption();
                }
                else
                {
                    OutputMessage("Please enter a valid number");
                    RemoveUser();
                }

            }
            FinishOption();
        }

        public void FinishOption()
        {
            Console.WriteLine("You have finished this option press enter to go back to the menu");
            Console.ReadLine();
            Console.Clear();
        }
        public void OutputMessage(string message)
        {
            Console.WriteLine(message+" press enter to try again");
            Console.ReadLine();
            Console.Clear();
        }
        public void StartingOption(string message)
        {
            Console.Clear();
            Console.WriteLine(message+Environment.NewLine);

        }

        public void PrintAllUsers()
        {
            int i = 0;
            people.ForEach(people =>
            {
                i++;
                Console.WriteLine("("+i + ")" + people.ReturnDetails());


            });
        }

        public Person ReturnPerson()
    {
        try
        {
            int id = people.Count + 1;
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (!string.IsNullOrEmpty(name))
            {
                if (age >= 0 && age <= 150)
                {
                    return new Person(id, name, age);

                }
                else
                {
                    OutputMessage("Please enter a valid age");
                }
            }
            else
            {
                OutputMessage("Please enter a name");
            }


        }
        catch (Exception)
        {
            OutputMessage("Something went wrong");

         
        }
            return null;

    }
    }
}
