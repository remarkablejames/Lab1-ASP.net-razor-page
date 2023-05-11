using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    [BindProperty]
    public int? Number1 { get; set; }

    [BindProperty]
    public int? Number2 { get; set; }
    [BindProperty]
    public int? Number3 { get; set; }

    public int? Result { get; private set; }

    public void OnPost()
    {
      Console.WriteLine(Number1+Number2+Number3);

      if (Number1.HasValue && Number2.HasValue && Number3.HasValue )
      {
          Result = Number1 + Number2 + Number3;
      }
      Console.WriteLine(Result);
    }
}