namespace OpenRastaSpike.Api.Resources
{
    using System;
    using System.Xml.Serialization;

    public class form
    {
        [XmlAttribute]
        public string rel { get; set; }
        [XmlAttribute]
        public string action { get; set; }
        [XmlAttribute]
        public string method { get; set; }
        [XmlArray]
        public input[] input { get; set; }
    }
}