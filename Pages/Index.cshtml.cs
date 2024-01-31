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

    public void OnGet()
    {
        User user = new User();

        user.Name = "Max Mustermann";
        user.Email = "sample@gmail";
        user.Password = "123456";

        Console.WriteLine(user);
    }
}

public class User{
    public string Name;
    public string Email;
    public string Password;
}
