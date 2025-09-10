using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Models;

public class PlayersContainer
{
    [JsonPropertyName("players")]
    public Player[] Players { get; set; }
}