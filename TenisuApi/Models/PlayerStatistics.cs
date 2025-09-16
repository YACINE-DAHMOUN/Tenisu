
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Models;


public class PlayerStatistics
{
    public string BestCountry { get; set; }
    public double AverageIMC { get; set; }
    public double HeightMedian { get; set; }
}