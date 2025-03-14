using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id,string name,int age)
        {   
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public string ReturnDetails()
        {
            return Id+"-"+Name+"-"+Age;
        }

    }
}
