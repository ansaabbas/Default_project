using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Default_Project.Controllers
{
    public class StudentController : Controller
    {

        public StudentContext _ORM = null;
        public StudentController(StudentContext ORM)
        {
            _ORM = ORM;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}