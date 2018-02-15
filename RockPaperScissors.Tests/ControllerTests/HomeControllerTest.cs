using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaperScissors.Controllers;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsHomeView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      IActionResult homeView = controller.Home();
      ViewResult result = homeView as ViewResult;

      //Assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_ReturnsPlayerOneWinsView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      IActionResult playerOneWinsView = controller.PlayerOneWins();
      ViewResult result = playerOneWinsView as ViewResult;

      //Assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_ReturnsPlayerTwoWinsView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      IActionResult playerTwoWinsView = controller.PlayerTwoWins();
      ViewResult result = playerTwoWinsView as ViewResult;

      //Assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_ReturnsDrawView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      IActionResult drawView = controller.Draw();
      ViewResult result = drawView as ViewResult;

      //Assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
  }
}
