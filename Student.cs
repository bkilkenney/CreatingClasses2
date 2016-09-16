using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses2
{
    class Student
    {
        //These are fields
        private string fullName;
        private int age;
        private string university;
        private string major;
        private float gpa;
        
        //Properties
        public string name
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        
       public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string University
        {
            get { return this.university; }
        }

        public string Major
        {
            get;
            set;
        }

        public float GPA 
            {
                get { return this.gpa; }
                set { this.gpa = value; }
            }
        
        //Constructors
         public Student()
        {
           
        }

        public Student(string fullName, int age, string university, string major, float gpa)
            
        {
            this.fullName = fullName;
            this.age = age;
            this.university = university;
            this.major = major;
            this.gpa = gpa;
        }
    }
}
