using System;
using System.Linq;
using Lesson7_3_CodeFirst.Models;

namespace Lesson7_3_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            StepContext db = new StepContext();

            foreach (Student student in db.Students)
            {
                Console.WriteLine(student.Id);
            }

            //AddStudents(db);
            //AddMarks(db);
            UpdateMarks(db);
        }

        private static void AddStudents(StepContext db)
        {
            db.Students.Add(new Student { FirstName = "Fuad", LastName = "Agazade", Gender=Gender.Male });
            db.Students.Add(new Student { FirstName = "Dmitriy", LastName = "Makarshin", Gender=Gender.Male});
            db.Students.Add(new Student { FirstName = "Murad", LastName = "Aliye",  Gender = Gender.Male });
            db.Students.Add(new Student { FirstName = "Kamran", LastName = "Aslanov",  Gender = Gender.Male });
            db.Students.Add(new Student { FirstName = "Farid", LastName = "Jalilov",  Gender = Gender.Male });
            db.Students.Add(new Student { FirstName = "Nail", LastName = "Shamsudinov",  Gender = Gender.Male });
            db.Students.Add(new Student { FirstName = "Kanan", LastName = "Gurbanov", Gender = Gender.Male });
            db.Students.Add(new Student { FirstName = "Kanan", LastName = "Mammadov", Gender=Gender.Male});
            db.Students.Add(new Student { FirstName = "Javid", LastName = "Madjidzade", Gender = Gender.Male });
            db.Students.Add(new Student { FirstName = "Nurana", LastName = "Sharifova", Gender = Gender.Female });

            db.SaveChanges();
        }

        private static void AddMarks(StepContext db)
        {
            foreach (Student student in db.Students)
            {
                db.Marks.Add(new Mark { StudentId = student.Id, Grade = new Random().Next(8, 12) });
            }

            db.SaveChanges();
        }


        private static void UpdateMarks(StepContext db)
        {
            foreach (Mark mark in db.Marks)
            {
                mark.Grade = new Random().Next(8, 12);
            }

            db.SaveChanges();
        }

    }
}
