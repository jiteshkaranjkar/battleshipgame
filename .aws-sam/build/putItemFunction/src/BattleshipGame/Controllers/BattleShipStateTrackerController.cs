using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleshipGame.Models;
using BattleshipGame.Models.Ships;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BattleshipGame.Controllers
{
  [ApiController]
  [Route("BattleshipGame")]
  public class BattleshipGameController : ControllerBase
  {
    private readonly ILogger<BattleshipGameController> _logger;

    public BattleshipGameController(ILogger<BattleshipGameController> logger)
    {
      _logger = logger;

    }

    // GET: api/ships
    [HttpGet]
    public void PlaceShipsAndFire()
    {
      Game battleShipGame = new Game();
      battleShipGame.PlayRound();
    }
  }
}