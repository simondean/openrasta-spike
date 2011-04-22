namespace OpenRastaSpike.Api.Resources
{
    using System.Xml.Serialization;

    public class link
    {
        [XmlAttribute]
        public string rel { get; set; }
        [XmlAttribute]
        public string type { get; set; }
        [XmlAttribute]
        public string href { get; set; }
    }
}