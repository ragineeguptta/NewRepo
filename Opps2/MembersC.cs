using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Opps2
{
    class MembersC
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;


        // member - public field
        public int age;

        //member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method  - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                ShareingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I am {2} year old", memberName, JobTitle, age);
            }
        }


        private void ShareingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public MembersC()
        {
            age = 30;
            memberName = "Raginee";
            salary = 30000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }


        // member - finalizer -  destructor
        
        ~MembersC()
        {
            // cleanup statement
            Console.WriteLine("Deconstruction of Member object");
            Debug.Write("Deconstruction of Member object");
        }
    }
}
