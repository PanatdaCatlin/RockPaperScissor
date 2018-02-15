using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System.Collections.Generic;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {
    private RockPaperScissor _myPlayers = new RockPaperScissor();
    [HttpGet("/home")]
    public ActionResult Home()
    {
      return View();
    }
    [HttpPost("/game")]
    public ActionResult PostRunGame()
    {
      _myPlayers.SetPlayerOneName(Request.Form["player-one-name"]);
      _myPlayers.SetPlayerTwoName(Request.Form["player-two-name"]);
      return View("game", _myPlayers);
    }
    [HttpGet("/game")]
    public ActionResult RunGame()
    {
      return View("game", _myPlayers);
    }

    [HttpGet("/playerOneWins")]
    public ActionResult PlayerOneWins()
    {
      _myPlayers.WinCondition(playerOneChoice, playerTwoChoice);
      return View("playerOneWins");
    }
    [HttpGet("/playerTwoWins")]
    public ActionResult PlayerTwoWins()
    {
      _myPlayers.WinCondition(playerOneChoice, playerTwoChoice);
      return View("playerTwoWins");
    }
    [HttpGet("/draw")]
    public ActionResult Draw()
    {
      _myPlayers.WinCondition(playerOneChoice, playerTwoChoice);
      return View("draw");
    }
  }
}
