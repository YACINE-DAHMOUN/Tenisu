using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Models;


public class CreatePlayerRequest
{
    [JsonPropertyName("firstname")]
    public string FirstName { get; set; }
    [JsonPropertyName("lastname")]
    public string LastName { get; set; }
    [JsonPropertyName("shortname")]
    public string ShortName { get; set; }
    [JsonPropertyName("sex")]
    public string Sex { get; set; }
    [JsonPropertyName("country")]
    public Country Country { get; set; }
    [JsonPropertyName("picture")]
    public string Picture { get; set; }
    [JsonPropertyName("data")]
    public required PlayerData Data { get; set; }  // Ajout du modificateur required
}

