using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;
using System.Collections.Generic;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorTest
  {
    [TestMethod]
    public void IsCoin_Quarter_True()
    {
      RockPaperScissor newCombination = new RockPaperScissor();
      List<double> testList = new List<double>(){4,0,0,0};
      CollectionAssert.AreEqual(testList, newCombination.CoinReturn(1.00));
    }
  }
}
