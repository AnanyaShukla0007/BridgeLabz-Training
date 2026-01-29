using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public int Marks;
}

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("students.csv");
        List<Student> list = new List<Student>();
        string line;

        sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            string[] d = line.Split(',');

            Student s = new Student();
            s.Id = int.Parse(d[0]);
            s.Name = d[1];
            s.Age = int.Parse(d[2]);
            s.Marks = int.Parse(d[3]);

            list.Add(s);
        }

        foreach (Student s in list)
        {
            Console.WriteLine(s.Id + " " + s.Name + " " + s.Marks);
        }

        sr.Close();
    }
}
