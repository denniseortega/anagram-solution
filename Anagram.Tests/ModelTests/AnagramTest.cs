using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramApp.Models;
using System.Collections.Generic;
// using System;

namespace AnagramApp.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      //Arrange
      string word = "beard";

      AnagramGenerator newAnagramGenerator = new AnagramGenerator(word);
      newAnagramGenerator.Save();

      //Act
      string result = newAnagramGenerator.GetDescription();

      //Assert
      Assert.AreEqual(word, result);
    }
  }
}
