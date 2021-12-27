using AngleSharp.Html.Dom;

namespace Parser.Parserr
{
    internal interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
