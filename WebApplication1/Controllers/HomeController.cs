using AspNetMVCPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaxiServiceBD.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Category> cat;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
                   cat= new List<Category>() { new Category() { Id=1,FullName="First Name"},
                new Category() { Id = 2, FullName = "Sec Name" },
                new Category() { Id = 3, FullName = "Third Name" } };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ThirdPage()
        {
            ViewData["Id"] = new SelectList(cat, "Id", "FullName");
            return View();
        }

        public IActionResult FourthPage()
        {
          

            return View(cat);
        }

        public IActionResult FifthPage()
        {

            List<Employee> list = new List<Employee>() {
            new Employee() {
                    Id = 1,
                    Name = "Mudassar",
                    Address = "Abbottabad",
                    City = "Abbottabad Pakistan",
                    Country = "Paksistan"
            },
            new Employee() {
                    Id = 2,
                    Name = "Asad",
                    Address = "Abbottabad",
                    City = "Abbottabad Pakistan",
                    Country = "Paksistan"
            },
            new Employee() {
                    Id = 3,
                    Name = "Mubashir",
                    Address = "Abbottabad",
                    City = "Abbottabad Pakistan",
                    Country = "Paksistan"
            },

        };
            ViewBag.model = list;
            return View();


        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

