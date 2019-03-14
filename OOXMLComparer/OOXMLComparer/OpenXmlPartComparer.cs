using DocumentFormat.OpenXml.Packaging;

namespace OOXMLComparer
{
    public abstract class OpenXmlPartComparer<T> : IOpenXmlComparer where T : OpenXmlPartContainer
    {
        protected T a;
        protected T b;

        protected OpenXmlPartComparer(T a, T b)
        {
            this.a = a;
            this.b = b;
        }

        public abstract bool Compare();
    }
}
