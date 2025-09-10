using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Models;

public class Country
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
    [JsonPropertyName("picture")]
    public string Picture { get; set; }
}