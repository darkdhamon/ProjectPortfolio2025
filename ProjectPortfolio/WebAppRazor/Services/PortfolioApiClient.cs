using System.Net.Http.Json;
using Model.Entity;

namespace WebAppRazor.Services;

public class PortfolioApiClient
{
    private readonly HttpClient _client;

    public PortfolioApiClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<Profile>> GetProfilesAsync()
    {
        var result = await _client.GetFromJsonAsync<List<Profile>>("profiles");
        return result ?? new List<Profile>();
    }

    public async Task<Profile?> GetProfileAsync(int id)
    {
        return await _client.GetFromJsonAsync<Profile>($"profiles/{id}");
    }
}
