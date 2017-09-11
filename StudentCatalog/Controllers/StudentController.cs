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

        // Read all
        public IActionResult Index() {
            ViewBag.stud = db.Students.ToList();
            return View();
        }

        // Search for FirstName and get info
        [HttpGet]
        public IActionResult GetStudent() {
            return View();
        }

        [HttpPost]
        public IActionResult GetStudent(Student name) {
            foreach (var stud in db.Students)
            {
                if (name.FirstName.ToLower().Equals(stud.FirstName.ToLower()))
                {
                    ViewBag.studentFound = stud;
                    return View();
                }
            }
            return View();
        }

        // Create
        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st) {
            db.Students.Add(st);
            db.SaveChanges();
            return View();
        }

        // Update


        // Delete
    }
}