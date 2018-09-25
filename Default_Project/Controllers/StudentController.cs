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

        
    
    }
}