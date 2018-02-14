using System;
using System.Text;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class RockPaperScissor
  {
    private string _rock = "rock";
    private string _scissors = "scissors";
    private string _paper = "paper";
    private string _draw = "draw";

    public string WinCondition(string playerOneChoice, string playerTwoChoice)
    {
      if (playerOneChoice == _rock && playerTwoChoice == _scissors || playerOneChoice == _scissors && playerTwoChoice == _rock)
      {
        return _rock;
      }
      else if(playerOneChoice == _rock && playerTwoChoice == _paper || playerOneChoice == _paper && playerTwoChoice == _rock)
      {
        return _paper;
      }
      else if(playerOneChoice == _paper && playerTwoChoice == _scissors || playerOneChoice == _scissors && playerTwoChoice == _paper)
      {
        return _scissors;
      }
      return _draw;
    }
  }
}
