using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System.Collections.Generic;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorTest
  {
    [TestMethod]
    public void IsRockPaperScissors_RockOverScissors_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player one wins", newCombination.WinCondition("rock", "scissors"));
    }
    [TestMethod]
    public void IsRockPaperScissors_RockOverScissors2_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player two wins", newCombination.WinCondition("scissors", "rock"));
    }
    [TestMethod]
    public void IsRockPaperScissors_RockOverPaper_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player two wins", newCombination.WinCondition("rock", "paper"));
    }
    [TestMethod]
    public void IsRockPaperScissors_RockOverPaper2_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player one wins", newCombination.WinCondition("paper", "rock"));
    }
    [TestMethod]
    public void IsRockPaperScissors_PaperOverScissors_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player two wins", newCombination.WinCondition("paper", "scissors"));
    }
    [TestMethod]
    public void IsRockPaperScissors_PaperOverScissors2_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("player one wins", newCombination.WinCondition("scissors", "paper"));
    }
    [TestMethod]
    public void IsRockPaperScissors_RockOverRock_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("draw", newCombination.WinCondition("rock", "rock"));
    }
    [TestMethod]
    public void IsRockPaperScissors_PaperOverPaper_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("draw", newCombination.WinCondition("paper", "paper"));
    }
    [TestMethod]
    public void IsRockPaperScissors_ScissorsOverScissors_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      Assert.AreEqual("draw", newCombination.WinCondition("scissors", "scissors"));
    }
  }
}
