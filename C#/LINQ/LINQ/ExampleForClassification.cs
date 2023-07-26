using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ExampleForClassification
    {
        public void ex1() 
        {
            //IList<string> courses = new List<string>();
            //courses.Add("C# Tutorials");
            //courses.Add("Sql Tutorials");
            //courses.Add("Jave Tutorials");
            //courses.Add(" web ");

            /*  var tutcourses = from c in courses where c.Contains("Tutorials") select c;

              foreach (var tut in tutcourses)
              {
                  Console.WriteLine(tut);
              }
            */
            //var tutcourses = courses.Where( c=>c.Contains("Tutorials"));
            //foreach (var tut in tutcourses)
            //{
            //    Console.WriteLine(tut);
            //}

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 }
            };
            //query syntex
            var filterResult = from s in studentList
                               where s.Age > 12
                               where s.Age < 20
                               select s;
            Console.WriteLine("Name      Age");
            foreach ( var stu in filterResult )
            {
                Console.WriteLine( stu.StudentName + "  /-/  " + stu.Age );
            }
        }
    }
}
