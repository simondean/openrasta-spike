namespace OpenRastaSpike.Api.Resources
{
    using System.Xml.Serialization;

    public class input
    {
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string type { get; set; }
        [XmlAttribute]
        public string value { get; set; }
    }
}
