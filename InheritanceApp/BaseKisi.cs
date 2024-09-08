using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    public abstract class BaseKisi
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Hello()
        {
            Console.WriteLine("Benim adım " + Name + " " + "ve soyadım " +Surname);
        }
    }

    public class Teacher : BaseKisi
    {
        public decimal Salary { get; set; }

        public void TeacherIntroduce()
        {
            Console.WriteLine($"Öğretmenin adı {Name}, soyadı {Surname} ve maaşı {Salary}$");
        }
    }

    public class Student : BaseKisi
    {
        public int StudentNumber { get; set; }

        public void StudentIntroduce()
        {
            Console.WriteLine($"Öğrencinin adı {Name}, soyadı {Surname} ve öğrenci numarası {StudentNumber}");
        }
    } 
}
