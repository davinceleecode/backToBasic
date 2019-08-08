using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
    public class OperatorOverload
    {







        public static void Main(string[] args)
        {

            Student s1 = new Student(1, 1);


            Student s2 = new Student(1, 1);


            Student s3 = s1 + s2;
            bool b = s1 > s2;


            int value = s1;

        }



    }


    public class Student
    {

        private int id;
        private double grade;


        public Student(int id, double grade)
        {

            this.id = id;
            this.grade = grade;

        }



        //operator overloading
        public static Student operator +(Student s1, Student s2)
        {
            Student newStudent = new Student((s1.id + s2.id) * 2, s1.grade + s2.grade);
            return newStudent;


        }

        public static bool operator >(Student s1, Student s2)
        {
            if (s1.grade >= s2.grade)
                return true;
            else
                return false;
        }
        public static bool operator <(Student s1, Student s2)
        {
            if (s1.grade >= s2.grade)
                return true;
            else
                return false;
        }



        public static implicit operator int(Student s1)
        {
            return s1.id;
        }



        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Grade:" + grade);
            Console.ReadLine();
        }
    }

}
