using AngleSharp.Html.Parser;

namespace Parser.Parserr
{
    internal class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings settings;

        HtmlLoader loader;

        bool isActive;

        #region Propeties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return settings;
            }
            set
            {
                settings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings settings) : this(parser)
        {
            this.settings = settings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Stop()
        {
            isActive = false;

        }

        private async void Worker()
        {
            string[] countries = { "belarus", "bulgaria", "hungary", "moldavia", "poland", "romania", "slovakia", "ukraine", "czech-republic", "turkey", "armenia", "georgia", "azerbaijan" };
            string[] region = { "by", "bg", "hu", "md", "pl", "ro", "sk", "ua", "cz", "tr", "am", "ge", "az" };

            for (int i = settings.StartPoint; i <= settings.EndPoint; i++)
            {


                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(countries[i], region[i]);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
