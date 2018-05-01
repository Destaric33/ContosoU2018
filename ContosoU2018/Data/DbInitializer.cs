using ContosoU2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //EnsureCreated method will automatically create the database. If it does not already exist.
            context.Database.EnsureCreated();

            //First look for any students
            //======================== STUDENTS =====================================//
            if(context.Students.Any())
            {
                //Database has already been seeded with students.
                return; //exits
            }
            //If we get here - students do not already exist - seed
            var students = new Student[] //creating an object array
            {
               new Student
               {
                FirstName = "Carson",
                LastName = "Alexander",
                Email = "calexander@contso.com",
                EnrollmentDate = DateTime.Parse("2017-09-01"),
                Address = "4 Flanders Court",
                City = "Moncton",
                Province = "NB",
                PostalCode = "E1C 0K6"
               },
               new Student
               {
                FirstName = "Meredith",
                LastName = "Alonso",
                Email = "malonso@contso.com",
                EnrollmentDate = DateTime.Parse("2017-09-01"),
                Address = "205 Argyle Street",
                City = "Moncton",
                Province = "NB",
                PostalCode = "E1C 8V2"
               }
            };

            //Loops the students array and add each student to the database context
            foreach(Student s in students)
            {
                context.Students.Add(s);
            }

            //Save Context
            context.SaveChanges(); //Will put in database.

            //Second look for any instructors
            //======================== INSTRUCTORS ==================================//
            var instructors = new Instructor[]
            {
                new Instructor
                {
                    FirstName = "Steven",
                    LastName = "Mallaley",
                    Email = "SMallaley@contoso.com",
                    HireDate = DateTime.Parse("2005-07-23"),
                    Address = "816 Main Street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E8G 1M1"

                },
                new Instructor
                {
                    FirstName = "Would",
                    LastName = "You",
                    Email = "wouldyou@contoso.com",
                    HireDate = DateTime.Parse("2003-07-23"),
                    Address = "816 Would you Street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E8G 1M1"
                }
            };
            foreach(Instructor i in instructors)
            {
                context.Instructors.Add(i);

            }
            //save it
            context.SaveChanges();

            //========================================== COURSES ==================================//
            var courses = new Course[]
            {
                new Course{CourseID =1050,Title="Chemistry",Credits=3},
                new Course{CourseID =4022,Title="MicroEconomics",Credits=3}
            };
            foreach(Course c in courses)
            {
                context.Add(c);
            }
            context.SaveChanges();

            //========================================== ENROLLMENT ==================================//
            var enrollments = new Enrollment[]
            {
                new Enrollment{CourseID= 1050,
                              StudentID=students.Single(s=>s.LastName=="Alexander").ID,
                              Grade = Grade.A},
                new Enrollment{CourseID= 4022,
                              StudentID=students.Single(s=>s.LastName=="Alonso").ID,
                              Grade = Grade.B}
            };
            foreach(Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
