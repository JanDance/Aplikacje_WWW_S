namespace AWWW_lab1_gr2.Models{
public class Article
{ 
    public int Id {get; set;}
    public string? Lead {get;set;}=null!;
    public string? Title {get; set;}=null!;
    public string? Content {get; set;}=null!;
    public DateTime CreationDate {get; set;}
}
}