using Microsoft.AspNetCore.Mvc;

namespace option_pattern_in_asp_net_core_8._0.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller(IConfiguration configuration) : ControllerBase
{
    public readonly IConfiguration _configuration = configuration;

    [HttpGet("config")]

    public IActionResult Get()
    {
        var Title = _configuration.GetValue<string>("Position:Title");
        var Name = _configuration.GetValue<string>("Position:Name");
        return Ok(new
        {
            Title = Title,
            Name = Name
        });
    }
    [HttpGet("info")]
    public IActionResult Result()
    {
        var positionOptions = new PositionOptions();
        _configuration.GetSection(PositionOptions.Position).Bind(positionOptions);
        return Ok($"Title: {positionOptions.Title} \n" +
                       $"Name: {positionOptions.Name}");
    }

}
