using System.Text;

namespace strategy.DynamicStrategy
{
    public interface IlistStrategy
    {
        void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }
}