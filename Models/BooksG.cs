using System.ComponentModel.DataAnnotations;

public class BooksG
{
    [Key]

    public int Idbook { get; set; }

    public string? tittle{get; set;}
    public int prec { get; set; }
    
}