using System.Text;
namespace strategy.DynamicStrategy
{
    public class TextProcessor
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private IlistStrategy _listStrategy;

        public void SetOutPutFormat(OutputFormat format)
        {
            switch (format)
            {
                case OutputFormat.Markdown:
                    _listStrategy = new MarkdownListStrategy();
                    break;
                case OutputFormat.Html:
                    _listStrategy = new HtmlListStrategy();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }
        
        public void AppendList(IEnumerable<string> items)
        {
            _listStrategy.Start(_sb);
            foreach (var item in items)
            {
                _listStrategy.AddListItem(_sb, item);
            }
            _listStrategy.End(_sb);
        }

        public StringBuilder Clear()
        {
            return _sb.Clear();
        }
        
        public override string ToString()
        {
            return _sb.ToString();
        }
    }
}