using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentCatalog.Models.Entites;

namespace test.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            students.Add(new Student{FirstName="Asam", LastName="Ali", Age=23});
            students.Add(new Student{FirstName="Masa", LastName="Lia", Age=42});
            students.Add(new Student{FirstName="Sama", LastName="Ila", Age=11});

            ViewBag.stud = students;

            return View();
        }

        public IActionResult Mvc(int id) 
        {
            ViewBag.number = id;
            return View();
        }
    }
}