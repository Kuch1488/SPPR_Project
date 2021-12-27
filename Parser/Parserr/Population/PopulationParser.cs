using AngleSharp.Html.Dom;

namespace Parser.Parserr.Population
{
    internal class PopulationParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("table-responsive"));
            document.QuerySelectorAll(".table-responsive");
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
