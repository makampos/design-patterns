using System.Text;

public class HtmlElement
{
    public string Name, Text;

    public HtmlElement(string name, string text)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Text = text ?? throw new ArgumentNullException(nameof(text));
    }
        
    public HtmlElement()
    {
            
    }

    public List<HtmlElement> Elements = new List<HtmlElement>();
    private const int indentSize = 2;

    private string ToStringImpl(int ident)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indentSize * ident);
        sb.AppendLine($"{i}<{Name}>");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', indentSize * (ident + 1)));
            sb.AppendLine(Text);
        }

        foreach (var e in Elements)
        {
            sb.Append(e.ToStringImpl(ident + 1));
        }

        sb.AppendLine($"{i}</{Name}>");

        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }
}