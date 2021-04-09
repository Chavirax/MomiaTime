using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Momias.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Momias.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View(new PeopleListViewModel
            {
                People = context.People
            });
        }
    }
    public class PeopleListViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<string> Cities { get; set; }
        public string SelectedCity { get; set; }
        public string GetClass(string city) =>
        SelectedCity == city ? "bg-info text-white" : "";
    }
}

