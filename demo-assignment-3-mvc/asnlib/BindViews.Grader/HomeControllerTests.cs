using System;
using System.Threading.Tasks;
using BindViews.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace HttpClientExample.Grader
{
    public class HomeControllerTests
    {

        [Fact]
        public void IndexDoesNotUseViewDataViewBagOrTempData()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            IActionResult result = controller.Index();

            // Assert
            var viewResult = Assert.IsAssignableFrom<ViewResult>(result);
            Assert.Empty(viewResult.ViewData);
            if (viewResult.TempData != null)
            {
                Assert.Empty(viewResult.TempData);
            }
        }

        [Fact]
        public void IndexPassesModelToView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            IActionResult result = controller.Index();

            // Assert
            var viewResult = Assert.IsAssignableFrom<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
        }
    }
}
