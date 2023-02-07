using System.Text;

namespace strategy.DynamicStrategy
{
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
}