using System;

namespace PracticeOne
{
    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            IsEnrolled = true;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public bool IsEnrolled { get; set; }


        static void Main(string[] args)
        {
            var k = new Student("Colton", "MacDonald", 31);
            Console.WriteLine(k);
            Console.WriteLine(k.FirstName + " " + k.LastName + " " + k.Age + " " + k.IsEnrolled);

            //var s = new Student();
            //s.FirstName = "Mary";
            //s.LastName = "Contrary";
            //s.Age = 35;
            ////s.IsEnrolled = true;
            //Console.WriteLine(s);

            //var codex = new Student()
            //{
            //    FirstName = "nfg",
            //    LastName = "Codex",
            //    Age = 29,
            //    IsEnrolled = true,
            //};
            //Console.WriteLine(codex);
            Console.ReadLine();

        }


    }
}
