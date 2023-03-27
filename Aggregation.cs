using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Aggregation
    {

       
    }
    public class Student
    {
        public Student(string  name, int age, int rollno, int dept_id, Marks M)
        {
            this.name = name;
            this.age = age;
            this.rollno = rollno;
            this.dept_id = dept_id;
            this.M = M;
        }
        string name;
        int age;
        int rollno;
        int dept_id;

        Marks M;

        public void Display()
        {
            Console.WriteLine($"Name: {name},age: {age},rollno: {rollno}, dept_id: {dept_id}, totalmarks: {M.total_marks}");
            //Console.WriteLine(percentage);
        }
        
    }
    public class Marks
    {
        public Marks(int total_marks, int no_subjects)
        {
            this.total_marks = total_marks;
            this.no_subjects = no_subjects;
        }
        public int total_marks;
        //float percentage;
        //string grade;
        int no_subjects;

        public float percentage;
        public void percentageCal()
        {
            percentage = (total_marks / no_subjects);
            Console.WriteLine(percentage);
        }
    }
}
