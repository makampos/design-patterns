using System.Text;

namespace singleton.AmbientContext;

public class Building
{
    public List<Wall> _walls = new List<Wall>();

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var wall in _walls)
        {
            sb.AppendLine(wall.ToString());
        }

        return sb.ToString();
    }
}