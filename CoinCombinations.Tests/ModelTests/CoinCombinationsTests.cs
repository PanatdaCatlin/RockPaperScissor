using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations;
using System.Collections.Generic;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinCombinationTest
  {
    [TestMethod]
    public void IsCoin_Quarter_True()
    {
      CoinCombination newCombination = new CoinCombination();
      List<double> testList = new List<double>(){4,0,0,0};
      CollectionAssert.AreEqual(testList, newCombination.CoinReturn(1.00));
    }
    [TestMethod]
    public void IsCoin_Dime_True()
    {
      CoinCombination newCombination = new CoinCombination();
      List<double> testList = new List<double>(){0,2,0,0};
      CollectionAssert.AreEqual(testList, newCombination.CoinReturn(0.20));
    }
    [TestMethod]
    public void IsCoin_Nickel_True()
    {
      CoinCombination newCombination = new CoinCombination();
      List<double> testList = new List<double>(){0,0,1,0};
      CollectionAssert.AreEqual(testList, newCombination.CoinReturn(0.05));
    }
    [TestMethod]
    public void IsCoin_Penny_True()
    {
      CoinCombination newCombination = new CoinCombination();
      List<double> testList = new List<double>(){0,0,0,4};
      CollectionAssert.AreEqual(testList, newCombination.CoinReturn(0.04));
    }
    [TestMethod]
    public void IsCoin_AllCoins_True()
    {
      CoinCombination newCombination = new CoinCombination();
      List<double> testList = new List<double>(){4,1,1,3};
      CollectionAssert.AreEqual(testList, newCombination.CoinReturn(1.18));
    }
  }
}
