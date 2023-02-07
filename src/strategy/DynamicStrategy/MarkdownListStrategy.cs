using System.Text;

namespace strategy.DynamicStrategy
{
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
}