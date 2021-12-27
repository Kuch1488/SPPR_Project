namespace Parser.Parserr.Population
{
    internal class ParserSettings : IParserSettings
    {
        public ParserSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseURL { get; set; } = "https://all-populations.com/ru/";
        public string Prefix { get; set; } = "{CurrentReg}/list-of-cities-in-{CurrentId}-by-population.html";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
