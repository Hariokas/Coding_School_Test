using System;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentProfessorTest.test(100);
        }
    }

    class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int aAge)
        {
            age = aAge;
        }
    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old.");
        }
    }

    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }

    static class StudentProfessorTest
    {
        public static void test(int age)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(age);
            student.Greet();
            student.ShowAge();
            student.Study();

            Professor professor = new Professor();
            professor.Greet();
            professor.Explain();
        }
    }
}
