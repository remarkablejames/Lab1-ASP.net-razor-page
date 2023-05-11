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
    public int? MaxValue { get; private set; }
    public int? MinValue { get; private set; }
    
    // declare a list of integers to store the numbers
    public List<int> Numbers { get; set; } = new List<int>();

    public void OnPost()
    {
      Console.WriteLine(Number1+Number2+Number3);
      if (Number1.HasValue)
      {
          Numbers.Add(Number1.Value);
          
      }
      if (Number2.HasValue)
      {
          Numbers.Add(Number2.Value);
            
      }
      if (Number3.HasValue)
      {
          Numbers.Add(Number3.Value);
            
      }

      Result = Numbers.Sum();
      MaxValue = Numbers.Max();
      MinValue = Numbers.Min();
      Console.WriteLine(Result);
    }
}