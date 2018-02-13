using System;
using System.Text;
using System.Collections.Generic;

namespace CoinCombinations
{
  public class CoinCombination
  {
    private double _quarterValue = .25;
    private double _dimeValue = .10;
    private double _nickelValue = .05;
    private double _pennyValue = .01;

    public List<double> CoinReturn(double inputtedTotal)
    {
      List<double> coins = new List<double>();

      double quarterNumber = 0;
      double dimeNumber = 0;
      double nickelNumber = 0;
      double pennyNumber = 0;

      double remainder = inputtedTotal;

      if (_quarterValue <= remainder)
      {
        quarterNumber = Math.Floor(remainder / _quarterValue);
        remainder -= _quarterValue * quarterNumber;
      }

      if(_dimeValue <= remainder)
      {
        dimeNumber = Math.Floor(remainder / _dimeValue);
        remainder -= _dimeValue * dimeNumber;
      }

      if(_nickelValue <= remainder)
      {
        nickelNumber = Math.Floor(remainder / _nickelValue);
        remainder -= _nickelValue * nickelNumber;
      }

      if(_pennyValue <= ((Math.Ceiling(remainder * 100))/100))
      {
        pennyNumber = ((Math.Ceiling(remainder * 100))/100) / _pennyValue;
      }

      coins.Add(quarterNumber);
      coins.Add(dimeNumber);
      coins.Add(nickelNumber);
      coins.Add(pennyNumber);
      return coins;
    }
  }
}
