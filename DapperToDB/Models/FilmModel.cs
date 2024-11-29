namespace DapperToDB.Models;


public class FilmModel
{
    public int Film_ID { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int Release_Year { get; set; }

    public int Language_ID { get; set; }

    public int Rental_Duration { get; set; }

    public int Length { get; set; }

    public decimal Replacement_Cost { get; set; }


    public string[] Rating { get; set; }

    public DateTime Last_Update { get; set; }


    public object? Special_Features { get; set; }

    public object? FullText {  get; set; }
   
}
