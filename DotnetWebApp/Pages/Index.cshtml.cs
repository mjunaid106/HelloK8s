using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Message { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = $"HOSTNAME: {Environment.GetEnvironmentVariables()["HOSTNAME"]}";
        }
    }
}