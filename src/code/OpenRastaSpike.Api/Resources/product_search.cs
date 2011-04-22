namespace OpenRastaSpike.Api.Resources
{
    using System;
    using System.Xml.Serialization;

    public class product_search
    {
        public form form { get; set; }

        [XmlArray]
        public product[] product { get; set; }
    }
}