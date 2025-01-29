using System.Collections.Generic;

Dictionary<int,string> name=new Dictionary<int,string>();
name.Add(0, "Pasindu");
name.Add(1, "thisara");
name.Add(2, "Shanuka");

for (int i = 0; i < name.Count; i++)
{
    Console.WriteLine(name);
}

Dictionary<int, string> name2 = new Dictionary<int, string>
{
    {1,"asas" },
    {2,"asas" },
    {3,"shhsa" }
};