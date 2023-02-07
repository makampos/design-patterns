using System.Text;

public class Program
{
    public enum OutputFormat
    {
        Markdown,
        Html
    }

    public interface IlistStrategy
    {
        void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }

    public class HtmlListStrategy : IlistStrategy
    {
        public void Start(StringBuilder sb)
        {
            sb.AppendLine($"<ul>");
        }

        public void End(StringBuilder sb)
        {
            sb.AppendLine($"<ul>");
        }

        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" <li>{item}<li>");
        }
    }

    public class MarkdownListStrategy : IlistStrategy
    {
        public void Start(StringBuilder sb)
        {
            
        }

        public void End(StringBuilder sb)
        {
            
        }

        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * {item}");
        }
    }

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
    
    public static void Main(string[] args)
    {
        var tp = new TextProcessor();
        tp.SetOutPutFormat(OutputFormat.Markdown);
        tp.AppendList(new[] {"foo", "bar", "baz"});
        Console.WriteLine(tp);

        tp.Clear();
        
        tp.SetOutPutFormat(OutputFormat.Html);
        tp.AppendList(new[] {"foo", "bar", "baz"});
        Console.WriteLine(tp);
    }
}
