using Microsoft.AspNetCore.Mvc;
using Models;
using Data;
using HttpGet = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly PlayerService _playerService;

    public PlayersController(PlayerService playerService)
    {
        _playerService = playerService;
    }

    [@HttpGet]  // ← ICI l'attribut
    public IActionResult Get()
    {
        // 1. Récupérer les joueurs
        var players = _playerService.GetAllPlayers();

        // 2. Les trier par rang
        var sortedPlayers = players.OrderBy(p => p.Data.Rank).ToList();

        // 3. Retourner le résultat
        return Ok(sortedPlayers);
    }

    [@HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var player = _playerService.GetPlayerById(id);
        if (player == null)
        {
            return NotFound();
        }
        return Ok(player);
    }
}