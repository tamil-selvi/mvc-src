using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Calculator.Test
{
    public class HomeTest
    {
        private readonly HomeController _controller;
        private readonly Mock<ILogger<HomeController>> _logger;

        public HomeTest()
        {
            _logger = new Mock<ILogger<HomeController>>();
            _controller = new HomeController(_logger.Object);           
        }

        [Fact]
        public void Test_Index()
        {
            var result = _controller.Index() ;

           // var result1 = _controller.Index() as ViewResult; //one way

           // Assert.IsAssignableFrom<IActionResult>(result); // anthoer way
            Assert.IsType<ViewResult>(result);  //another waity
        }

    }
}
