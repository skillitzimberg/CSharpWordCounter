using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectActionResult_True()
      {
          //Arrange
        HomeController controller = new HomeController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
    // 
    //   [TestMethod]
    //   public void Index_ReturnsCorrectActionName_Index()
    //   {
    //       //Arrange
    //     HomeController controller = new HomeController();
    //
    //     //Act
    //     ActionResult indexView = controller.Index();
    //
    //     //Assert
    //     Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    // }
    //
    //   [TestMethod]
    //   public void Index_HasCorrectModelType_ItemList()
    //   {
    //       //Arrange
    //       HomeController controller = new HomeController();
    //       ViewResult indexView = new HomeController().Index() as ViewResult;
    //
    //       //Act
    //       var result = indexView.ViewData.Model;
    //
    //       //Assert
    //       Assert.IsInstanceOfType(result, typeof(List<Item>));
    //   }

  }
}
