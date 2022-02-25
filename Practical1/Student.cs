using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    //1. internal - accessible in same assembly only
    //2. public - every class can access
    //3. private - accessible in the class only
    //4. protected - accessible to the class and its children
    //public,internal,private,protected
    internal class Student
    {
        //encapsulation-preventing unauthorized parties' direct access(public property expose the field to outside)
        //field
        private int _age;

        public int Age
        {
            get
            {
                return _age+10;
            }
            set
            {
                if (value < 0 || value > 150)
                    return;
                _age = value;
            }
        }

        public static int Count = 0;
        //constructor
        public Student()
        {
            Console.Write("Student is created");
            Count++;
        }
        //constructor with parameter
        public Student(string name)
        {
            //initialize something
            Name=name;
            Console.WriteLine($"Student {name} is created");
            Count++;
        }

        //property
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }

        public void PrintCount()
        {
            Console.WriteLine(Count);
        }
    }
}
