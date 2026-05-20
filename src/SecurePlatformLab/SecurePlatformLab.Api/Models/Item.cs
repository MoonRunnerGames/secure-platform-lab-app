namespace SecurePlatformLab.Api.Models;

public class Item
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name { get; set; } = string.Empty;

    public string Status { get; set; } = "Created";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}