using System.Xml.Serialization;

namespace ConsoleApp2.Modelos
{
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class consChNFe
    {
        public string chNFe { get; set; }
    }
}