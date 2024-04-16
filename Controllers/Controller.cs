using Microsoft.AspNetCore.Mvc;

namespace option_pattern_in_asp_net_core_8._0.Controllers;

[ApiController]
[Route("api/country")]
public class Controller(IConfiguration configuration) : ControllerBase
{
    public readonly IConfiguration _configuration = configuration;

    [HttpGet("info")]
    public IActionResult Get()
    {
        var Name = _configuration.GetValue<string>("Country:Name");
        var Capital = _configuration.GetValue<string>("Country:Capital");
        var Population = _configuration.GetValue<string>("Country:Population");
        var AreaSqKm = _configuration.GetValue<string>("Country:Area_sq_km");
        return Ok(new
        {
            Name = Name,
            Capital = Capital,
            Population = Population,
            AreaSqKm = AreaSqKm,
        });
    }


    //using config bind 
    // [HttpGet("happy")]

    // public IActionResult OnGet()
    // {
    //     var countryOptions = new CountryOptions();
    //     _configuration.GetSection(CountryOptions.Option).Bind(countryOptions);

    //     return Ok($"{countryOptions.Name}\n" +
    //             $"{countryOptions.Capital}\n" +
    //             $"{countryOptions.Population}\n" +
    //             $"{countryOptions.Area_sq_km}\n" +
    //             $"{countryOptions.Currency}\n" +
    //             $"{countryOptions.Calling_code}\n"
    //     );
    // }

    public CountryOptions? countryOptions { get; private set; }


    [HttpGet("infos")]
    public IActionResult OnGet()
    {
        countryOptions = _configuration.GetSection(CountryOptions.Option).Get<CountryOptions>();
        return Ok(
            $"{countryOptions.Name}\n" +
                $"{countryOptions.Capital}\n" +
                $"{countryOptions.Population}\n" +
                $"{countryOptions.Area_sq_km}\n" +
                $"{countryOptions.Currency}\n" +
                $"{countryOptions.Calling_code}\n"
        );
    }

    [HttpGet("another")]
    public IActionResult onAnother()
    {
        var AnotherOption = new AnotherCountryDetailsOption("Norway", "Oslo");
        _configuration.GetSection(AnotherCountryDetailsOption.Options).Bind(AnotherOption);
        return Ok($"Name: {AnotherOption.Name}\n" +
                $"Capital: {AnotherOption.Capital}\n" +
                $"Goverment: {AnotherOption.Government}\n"//don't take it serious 
        );
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
