namespace option_pattern_in_asp_net_core_8;
public class CountryOptions
{
    public const string Position = "Country";
    public String Name { get; set; } = null!;
    public String Capital { get; set; } = null!;
    public long? Population { get; set; }
    public int? AreaSqKm { get; set; }
    public String Currency { get; set; } = null!;
    public String OfficialLanguage { get; set; } = null!;
    public List<String>? NeighborCountries { get; set; }
    public List<String>? MajorCities { get; set; }
    public String TimeZone { get; set; } = null!;
    public String InternetDomain { get; set; } = null!;
    public String CallingCode { get; set; } = null!;
    public String Government { get; set; } = null!;
    public String NationalAnthem { get; set; } = null!;
    public List<String>? FlagColors { get; set; }
    public List<String>? FamousLandmarks { get; set; }

}