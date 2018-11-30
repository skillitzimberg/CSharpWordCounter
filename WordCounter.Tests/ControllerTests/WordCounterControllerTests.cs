using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectActionResult_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void New_ReturnsCorrectActionResult_True()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();

      //Act
      ActionResult newView = controller.New();

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    // [TestMethod]
    // public void New_HasCorrectModelType_ItemList()
    // {
    //     //Arrange
    //     WordCounterController controller = new WordCounterController();
    //     ViewResult newView = new HomeController().New() as ViewResult;
    //
    //     //Act
    //     var result = newView.ViewData.Model;
    //
    //     //Assert
    //     Assert.IsInstanceOfType(result, typeof(List<Item>));
    // }

  }
}
