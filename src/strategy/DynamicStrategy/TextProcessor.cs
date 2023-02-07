using System.Text;
namespace strategy.DynamicStrategy
{
    public class TextProcessor<LS> where LS : IlistStrategy, new()
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private IlistStrategy _listStrategy = new LS();

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