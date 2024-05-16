using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DemoMV.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DataSetDateTime ReleaseData { get; set; }
    public String? Genre { get; set; }
    public decimal Price { get; set;}
}