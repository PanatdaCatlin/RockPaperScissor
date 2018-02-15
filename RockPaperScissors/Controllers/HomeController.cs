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
    [HttpPost("/result")]
    public ActionResult SubmitPlays()
    {
      string result = _myPlayers.WinCondition(Request.Form["player-one-choice"], Request.Form["player-two-choice"]);
      return View("Winner", result);
    }
  }
}
