public class RoomsModel : PageModel
{
    public List<Room> Rooms { get; set; }

    public async Task OnGetAsync()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync("https://localhost:5001/api/rooms");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            Rooms = JsonSerializer.Deserialize<List<Room>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }

    public async Task<IActionResult> OnPostChangeStatusAsync(int id, string status)
    {
        using var client = new HttpClient();
        var room = new Room { Id = id, Status = status };
        var content = new StringContent(JsonSerializer.Serialize(room), Encoding.UTF8, "application/json");
        var response = await client.PutAsync($"https://localhost:5001/api/rooms/{id}", content);
        return RedirectToPage();
    }
}