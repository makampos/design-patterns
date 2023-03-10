using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace prototype.OldSolution;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        var stream = new MemoryStream();
        var formatter = new BinaryFormatter();
        if (self != null) formatter.Serialize(stream, self);
        stream.Seek(0, SeekOrigin.Begin);
        object copy = formatter.Deserialize(stream);
        stream.Close();
        return (T)copy;
    }

    public static T DeepCopyXml<T>(this T self)
    {
        using(var memoryStream = new MemoryStream())
        {
            var s = new XmlSerializer(typeof(T));
            s.Serialize(memoryStream, self);
            memoryStream.Position = 0;
            return (T)s.Deserialize(memoryStream);
        }
    }
}