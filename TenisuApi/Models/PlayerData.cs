using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Models;

public class PlayerData
{
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
    [JsonPropertyName("points")]
    public int Points { get; set; }
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
    [JsonPropertyName("age")]
    public int Age { get; set; }
    [JsonPropertyName("last")]
    public int[] Last { get; set; }
}