using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        class Student
        {
            private string name;
            private string id;
            private int yearofstudy;
            public Student(string name, string id)
            {
                this.name = name;
                this.id = id;
            }
            public void Increment()
            {
                yearofstudy++;
            }
            public int YearofStudy
            {
                get
                {
                    return yearofstudy;
                }
                set
                {
                    yearofstudy = value;
                }
            }
           

        }
        static void Main(string[] args)
        {
            Student s = new Student("Dariga", "18BD110336");
            s.YearofStudy = 1;
            s.Increment();
            Console.WriteLine(s.YearofStudy);
          
        }
    }
}
