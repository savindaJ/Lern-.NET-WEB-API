using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lernApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public void OnPost()
    {
        Console.WriteLine("Post");
    }

    public void OnGet()
    {
        User user = new()
        {
            Name = "Max Mustermann",
            Email = "sample@gmail",
            Password = "123456"
        };

        Console.WriteLine(user.Name);
    }

    
}

public class User{
    public required string Name;
    public required string Email;
    public required string Password;
}
