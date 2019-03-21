using System.IO;

namespace OOXMLComparer
{
    public interface IDocxComparer
    {
        bool Compare(Stream a, Stream b);
    }
}