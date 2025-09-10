using System.Text.Json;
using Models;
using System.io;
using System.Linq;



namespace Data;

public class PlayerService
{
    private readonly string _filePath = "Data/players.json";
    public List<Player> GetAllPlayers()
    {
        if (!File.Exists(_filePath))
        {
            throw new FileNotFoundException($"The file {_filePath} was not found.");
        }
        var jsonString = File.ReadAllText(_filePath);
        var playersContainer = JsonSerializer.Deserialize<PlayersContainer>(jsonString);
        return playersContainer?.Players.ToList() ?? new List<Player>();
    }
    public Player GetPlayerById(int id)
    {
        var players = GetAllPlayers();
        return players.FirstOrDefault(p => p.Id == id);
    }
}

