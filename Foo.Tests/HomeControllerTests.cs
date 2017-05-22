using System;
using Foo.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Foo.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ShouldReturnIActionResult()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void About_ShouldReturnIActionResult()
        {
            var controller = new HomeController();
            var result = controller.About();
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
