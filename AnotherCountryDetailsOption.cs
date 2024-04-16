namespace option_pattern_in_asp_net_core_8
{
    public class AnotherCountryDetailsOption(string name, string capital) : AnotherCountryDetails
    {
        public const string Options = "Country";
        public override string? Name { get; } = name;
        public override string? Capital { get; } = capital;
        public string? Government { get; set; }
    }
}