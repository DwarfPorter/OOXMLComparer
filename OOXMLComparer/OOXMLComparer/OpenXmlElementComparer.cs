using DocumentFormat.OpenXml;

namespace OOXMLComparer
{
    public abstract class OpenXmlElementComparer<T> : IOpenXmlElementComparer where T : OpenXmlElement
    {
        protected T a;
        protected T b;

        protected OpenXmlElementComparer(T a, T b)
        {
            this.a = a;
            this.b = b;
        }

        public abstract bool Compare();
    }

    public class OpenXmlElementComparer : OpenXmlElementComparer<OpenXmlElement>
    {
        public OpenXmlElementComparer(OpenXmlElement a, OpenXmlElement b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return true;
        }
    }
}
