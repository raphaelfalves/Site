using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace raphaelfalves.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var request = Request;
            var ipUsuario = request.HttpContext.Connection.RemoteIpAddress;
            var localUsuario = request.Headers["X-Forwarded-For"];

            _logger.LogInformation($"Endere�o IP do usu�rio: {ipUsuario}");
            _logger.LogInformation($"Local do usu�rio: {localUsuario}");
        }
    }
}
