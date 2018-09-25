using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Default_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Default_Project.Controllers
{
    public class StudentController : Controller
    {

        ProjectContext _ORM = null;
        public StudentController(ProjectContext ORM)
        {
            _ORM = ORM;
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(Student S)
        {
            _ORM.Student.Add(S);
            _ORM.SaveChanges();
            ViewBag.Message = "Registration is Done";
            return View();
        }

        [HttpGet]
        public IActionResult AllStudents()

        {
            IList<Student> AllStudents = _ORM.Student.ToList<Student>();
            return View(AllStudents);
        }

        [HttpPost]
        public IActionResult AllStudents(string SearchByName, string SearchByClass)
        {

            IList<Student> AllStudents = _ORM.Student.Where(m => m.Name.Contains(SearchByName) || m.Class.Contains(SearchByName)).ToList<Student>();
            return View(AllStudents);
        }
        public IActionResult DeleteStudent(Student S)
        {
            // Student S =  ORM.Student.Where(a => a.Id == Id).FirstOrDefault<Student>();
           _ORM.Student.Remove(S);
            _ORM.SaveChanges();
            //return View("AllStudents");
            return RedirectToAction("AllStudents");
        }

        [HttpGet]
        public IActionResult EditStudent(int Id)
        {

            Student S = _ORM.Student.Where(m => m.Id == Id).FirstOrDefault<Student>();
            return View(S);
        }
        [HttpPost]
        public IActionResult EditStudent(Student S)
        {
            _ORM.Student.Update(S);
            _ORM.SaveChanges();
            //Student S = ORM.Student.Where(m => m.Id == Id).FirstOrDefault<Student>();
            return RedirectToAction("AllStudents");
        }
    }
}