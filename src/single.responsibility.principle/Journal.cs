namespace single.responsibility.principle
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count;
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        // public void Save(string fileName)
        // {
        //     File.WriteAllText(fileName, ToString());
        // }
        // public static Journal Load(string fileName) {...}
        // public void Load(Uri uri) {...}
        // =============================================================================================================
        // -This class do a lot of things and
        // -There's a possibility to keep growing.
        // -To avoid this, prefer to create different classes and keep their responsibilities separated.
        // -For example create a class [Persistence Class] to deal with the logic to save to file.
        //==============================================================================================================
    }
}