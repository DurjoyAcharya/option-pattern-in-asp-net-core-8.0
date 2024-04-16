namespace option_pattern_in_asp_net_core_8;
public class CountryOptions
{
    public const string Option = "Country";
    public String Name { get; set; } = null!;
    public String Capital { get; set; } = null!;
    public long? Population { get; set; }
    public int? Area_sq_km { get; set; }
    public String Currency { get; set; } = null!;
    public String Official_language { get; set; } = null!;
    public List<String>? Neighbor_countries { get; set; }
    public List<String>? Major_cities { get; set; }
    public String Time_zone { get; set; } = null!;
    public String Internet_domain { get; set; } = null!;
    public String Calling_code { get; set; } = null!;
    public String Government { get; set; } = null!;
    public String National_anthem { get; set; } = null!;
    public List<String>? Flag_colors { get; set; }
    public List<String>? famous_landmarks { get; set; }

}