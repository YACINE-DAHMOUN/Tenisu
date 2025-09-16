using Microsoft.AspNetCore.Mvc;
using Models;
using Data;

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

    [HttpGet]  // ← ICI l'attribut
    public IActionResult Get()
    {
        // 1. Récupérer les joueurs
        var players = _playerService.GetAllPlayers();

        // 2. Les trier par rang
        var sortedPlayers = players.OrderBy(p => p.Data.Rank).ToList();

        // 3. Retourner le résultat
        return Ok(sortedPlayers);
    }

   
    [HttpGet("stats")]
    public IActionResult GetStatistics()
    {
        var players = _playerService.GetAllPlayers();

        // 1. Calculer le meilleur pays (séparément)
        var bestCountry = players
            .GroupBy(p => p.Country.Code)
            .Select(g => new {
                Country = g.Key,
                WinRatio = g.Average(p => p.Data.Last.Average())
            })
            .OrderByDescending(x => x.WinRatio)
            .FirstOrDefault()?.Country ?? "N/A";

        // 2. Calculer l'IMC moyen (séparément)
        var averageIMC = players
            .Select(p => (p.Data.Weight / 1000.0) / ((p.Data.Height / 100.0) * (p.Data.Height / 100.0)))
            .Average();

        // 3. Calculer la médiane des tailles (séparément)
        var sortedHeights = players.Select(p => p.Data.Height).OrderBy(h => h).ToList();
        int count = sortedHeights.Count;
        double heightMedian;

        if (count % 2 == 0)
        {
            heightMedian = (sortedHeights[count / 2 - 1] + sortedHeights[count / 2]) / 2.0;
        }
        else
        {
            heightMedian = sortedHeights[count / 2];
        }

        // 4. Créer l'objet de réponse
        var statistics = new PlayerStatistics
        {
            BestCountry = bestCountry,
            AverageIMC = averageIMC,
            HeightMedian = heightMedian
        };

        return Ok(statistics);
    }
    [HttpGet("{id}")]
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