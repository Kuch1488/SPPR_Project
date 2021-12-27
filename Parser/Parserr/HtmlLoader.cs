namespace Parser.Parserr
{
    internal class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseURL}{settings.Prefix}";
        }

        public async Task<string> GetSourceByPageId(string id, string reg)
        {
            var currentUrl = url.Replace("{CurrentId}", id);
            var currentUrl2 = currentUrl.Replace("{CurrentReg}", reg);
            var response = client.GetAsync(currentUrl2).Result;

            string source = await response.Content.ReadAsStringAsync();

            return source;
        }
    }
}
