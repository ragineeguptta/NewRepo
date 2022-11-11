using System;
using System.Collections;
using System.Text;

namespace _7_Array
{
    class Hashtables
    {   // Key - Value
        //Auto Car
        static void Main(string[] args)
        {
            Hashtable studentstable = new Hashtable();

            Student stud1 = new Student(1, "Ragine1", 98);
            Student stud2 = new Student(2, "Ragine2", 44);
            Student stud3 = new Student(3, "Ragine3", 55);
            Student stud4 = new Student(4, "Ragine4", 23);

            studentstable.Add(stud1.Id, stud1);
            studentstable.Add(stud2.Id, stud2);
            studentstable.Add(stud3.Id, stud3);
            studentstable.Add(stud4.Id, stud4);

            Console.WriteLine("test");
            Console.ReadLine();
        }

        class Student
        {
            //property called Id
            public int Id { get; set; }
            //property called Name
            public string Name { get; set; }
            //property called GPA
            public float GPA { get; set; }
            //simple constructor
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }

        }
    }
}