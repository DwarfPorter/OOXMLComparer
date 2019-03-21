using DocumentFormat.OpenXml;

namespace OOXMLComparer
{
    public abstract class OpenXmlElementComparer<T> : IOpenXmlComparer where T : OpenXmlElement
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
}
