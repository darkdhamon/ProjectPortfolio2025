using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazor.Services;
using Model.Entity;

namespace WebAppRazor.Pages.Portfolio;

public class IndexModel : PageModel
{
    private readonly PortfolioApiClient _api;

    public Profile? Profile { get; set; }

    public IndexModel(PortfolioApiClient api)
    {
        _api = api;
    }

    public async Task OnGetAsync(int id)
    {
        Profile = await _api.GetProfileAsync(id);
    }
}
