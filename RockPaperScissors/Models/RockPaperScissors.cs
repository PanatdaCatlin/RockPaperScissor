using System;
using System.Text;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class RockPaperScissor
  {
    private string _rock = "rock";
    private string _scissors = "scissors";
    private string _paper = "paper";
    private string _draw = "draw";
    private string _playerOneWins = "player one wins";
    private string _playerTwoWins = "player two wins";
    private string _playerOneName;
    private string _playerTwoName;

    private static List<RockPaperScissor> _playersList = new List<RockPaperScissor>{};

    public string GetPlayerOneName()
    {
      return _playerOneName;
    }

    public void SetPlayerOneName(string newPlayerOneName)
    {
      _playerOneName = newPlayerOneName;
    }
    public string GetPlayerTwoName()
    {
      return _playerTwoName;
    }

    public void SetPlayerTwoName(string newPlayerTwoName)
    {
      _playerTwoName = newPlayerTwoName;
    }
    public string WinCondition(string playerOneChoice, string playerTwoChoice)
    {
      if (playerOneChoice == _rock && playerTwoChoice == _scissors || playerOneChoice == _paper && playerTwoChoice == _rock || playerOneChoice == _scissors && playerTwoChoice == _paper)
      {
        return _playerOneWins;
      }

      if (playerOneChoice == _scissors && playerTwoChoice == _rock || playerOneChoice == _rock && playerTwoChoice == _paper || playerOneChoice == _paper && playerTwoChoice == _scissors )
      {
        return _playerTwoWins;
      }
      return _draw;
    }
  }
}
