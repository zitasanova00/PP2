using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zita2
{
    class Student
    {
        public string name;
        public int id;
        public int year;
        public Student()
        {
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());

        }
        public Student(string name,int id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;

        }
        public void incYear()
        {
            year++;
        }
        public override string ToString()
        {
            return name + " " + id + " " + this.year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Zita", 733, 1);
            st.incYear();
            Console.WriteLine(st);
            Console.ReadKey();

        }
    }
}
