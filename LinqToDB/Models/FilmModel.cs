//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace DapperToDB.Models;

[Table("film")]
public class FilmModel
{
    [Key]
    [Column("film_id")]
    public int Film_ID { get; set; }


    [Column("title")]
    public string? Title { get; set; }


    [Column("description")]
    public string? Description { get; set; }


    [Column("release_year")]
    public int Release_Year { get; set; }


    [Column("language_id")]
    public int Language_ID { get; set; }


    [Column("rental_duration")]
    public int Rental_Duration { get; set; }


    [Column("length")]
    public int Length { get; set; }


    [Column("replacement_cost")]
    public decimal Replacement_Cost { get; set; }


    [Column("rating")]
    public string[] Rating { get; set; }


    [Column("last_update")]
    public DateTime Last_Update { get; set; }


    [Column("special_features")]
    public object? Special_Features { get; set; }


    [Column("fulltext")]
    public object? FullText {  get; set; }

    public override string ToString()
    {
        return 
            $"{Film_ID} {Title} {Description} {Release_Year} {Language_ID} {Rental_Duration}" +
            $"{Length} {Replacement_Cost} {Rating} {Last_Update} {Special_Features} {FullText}";
    }
}
