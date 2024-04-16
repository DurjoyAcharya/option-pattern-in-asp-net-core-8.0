using Microsoft.AspNetCore.Mvc;

namespace option_pattern_in_asp_net_core_8._0.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller(IConfiguration configuration) : ControllerBase
{
    public readonly IConfiguration _configuration = configuration;

    [HttpGet("name")]
    public IActionResult Get()
    {
        var Name = _configuration.GetValue<string>("Country:Name");
        var Capital = _configuration.GetValue<string>("Country:Capital");
        return Ok(new
        {
            Name = Name,
            Capital = Capital,
        });
    }

    // [HttpGet("info")]
    // public IActionResult Result()
    // {
    //     var positionOptions = new PositionOptions();
    //     _configuration.GetSection(PositionOptions.Position).Bind(positionOptions);
    //     return Ok($"Title: {positionOptions.Title} \n" +
    //                    $"Name: {positionOptions.Name}");
    // }


    //     public PositionOptions? positionOptions { get; private set; }


    // [HttpGet("info")]

    // public IActionResult Result()

    // {

    // positionOptions = _configuration.GetSection(PositionOptions.Position).Get<PositionOptions>();

    // #pragma warning disable CS8602 // Dereference of a possibly null reference.

    // return Ok($"Title: {positionOptions.Title} \n"

    // + $"Name: {positionOptions.Name}");

    // #pragma warning restore CS8602 // Dereference of a possibly null reference.

    // }

}
