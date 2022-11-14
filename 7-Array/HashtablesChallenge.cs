using System;
using System.Collections;
using System.Text;

namespace _7_Array
{
    class HashtablesChallenge
    {
        static void Main2(string[] args)
        {
            Hashtable table = new Hashtable();

            Student[] students = new Student[5];
            students[0]= new Student(1, "Ragine Gutpa", 98);
            students[1] = new Student(2, "Vikas Gupta", 44);
            students[2] = new Student(3, "Rohit Gupta", 55);
            students[3] = new Student(4, "Amit Gupta", 23);
            students[4] = new Student(3, "mayank Gupta", 55);

            foreach (Student s in students)
            {
                if (!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine("Student with ID{0} was addes!.", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, A student with same id alreadynextists ID:{0}", s.Id);
                }
            }


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
