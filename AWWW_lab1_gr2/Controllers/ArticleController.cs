using Microsoft.AspNetCore.Mvc;
using AWWW_lab1_gr2.Models;
public class ArticleController : Controller{
    public IActionResult Index()
    {
        var article = new Article
        {
        Id=1,
        Title = "Artykuł 1",
        Content = "Lorem ipsum...",
        CreationDate = DateTime.Now        
        };
    
    return View(article);
    }
}