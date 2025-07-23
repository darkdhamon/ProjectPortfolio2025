using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazor.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly Services.PortfolioApiClient _api;

    public List<Model.Entity.Profile> Portfolios { get; set; } = new();

    public IndexModel(ILogger<IndexModel> logger, Services.PortfolioApiClient api)
    {
        _logger = logger;
        _api = api;
    }

    public async Task OnGetAsync()
    {
        Portfolios = await _api.GetProfilesAsync();
    }
}
