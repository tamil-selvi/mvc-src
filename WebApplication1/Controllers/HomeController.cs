using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            //1. func example
            Func<int, int> square = n => n * n;            
            int result = square(5);  //Ans 25

            //list example
            var numbers = new List<int> { 4, 5, 1, 2, 3 };
            //2. The Single() method throws an exception if no object matching the condition is found in the collection
            var number = numbers.Single(n => n == 10);


            //3. Nullable Type check (doesnot allow to nullable type to int)
            //n is a nullable int and cannot be assigned to an int. We need to call the GetValueOrDefault() method.
            int? n = null;
            int m = n.GetValueOrDefault();

            //4. Difference between var and dynamic
            //The resolution of types, properties and methods for the variables defined with var is checked at compile - time.We use dynamic to postpone the type resolution at runtime.
            dynamic k = 5;
            var l = k;


            return View();
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
