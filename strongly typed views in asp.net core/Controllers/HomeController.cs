using Microsoft.AspNetCore.Mvc;
using strongly_typed_views_in_asp.net_core.Models;
using System.Diagnostics;

namespace strongly_typed_views_in_asp.net_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            var myemployees = new List<Employee>
            {
                
                new Employee {Empid=11,Empname="sandhya",designation="manager",salary=23000},
                new Employee {Empid=12,Empname="sita",designation="assistant",salary=3000},
                new Employee {Empid=13,Empname="sandesh",designation="sales",salary=2000},
                new Employee {Empid=14,Empname="ram",designation="ceo",salary=25000},
                new Employee {Empid=15,Empname="shyam",designation="md",salary=28000}



                };
            return View(myemployees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}