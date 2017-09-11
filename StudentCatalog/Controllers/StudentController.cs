using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentCatalog.Models;
using StudentCatalog.Models.Entites;

namespace test.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContext db = new StudentDbContext();

        public IActionResult Index()
        {
            ViewBag.stud = db.Students.ToList();
            return View();
        }

        public IActionResult Mvc(int id) 
        {
            ViewBag.number = id;
            return View();
        }

        // Create
        public IActionResult Create() {
            db.Students.Add(new Student{FirstName="Asam", LastName="Ali", Age=23});
            db.SaveChanges();
            return View();
        }

        // Update

        // Delete
    }
}