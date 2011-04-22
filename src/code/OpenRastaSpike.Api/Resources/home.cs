namespace OpenRastaSpike.Api.Resources
{
    using System.Xml.Serialization;

    public class home
    {
        [XmlArray]
        public link[] link { get; set; }
    }
}