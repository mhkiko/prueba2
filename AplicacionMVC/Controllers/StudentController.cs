﻿using AplicacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionMVC.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                        };
        // GET: Student
        public ActionResult Index()
        {           
            // Get the students from the database in the real application

            return View(studentList);
        }

        public ActionResult Edit(int Id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //write code to update student 
            if(!ModelState.IsValid) return View(std);
            /*if (string.IsNullOrEmpty(std.StudentName))
            {
              ModelState.AddModelError(string.Empty, "EL ESTUDIANTE DEBE TENER NOMBRE");
                return View(std);

            }*/
            return RedirectToAction("Index");
        }
    }
}