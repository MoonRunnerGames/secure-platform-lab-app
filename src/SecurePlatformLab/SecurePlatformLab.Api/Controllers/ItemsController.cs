using Microsoft.AspNetCore.Mvc;
using SecurePlatformLab.Api.Models;

namespace SecurePlatformLab.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private static readonly List<Item> Items =
    [
        new Item
        {
            Id = "1",
            Name = "Interview lab item",
            Status = "Created"
        }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Item>> Get()
    {
        return Ok(Items);
    }

    [HttpPost]
    public ActionResult<Item> Post([FromBody] CreateItemRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            return BadRequest("Name is required.");
        }

        var item = new Item
        {
            Name = request.Name,
            Status = "Created"
        };

        Items.Add(item);

        return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
    }
}

public class CreateItemRequest
{
    public string Name { get; set; } = string.Empty;
}