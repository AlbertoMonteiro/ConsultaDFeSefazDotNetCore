using System.Runtime.Serialization;
using System.Xml.Linq;

namespace ConsoleApp2.Services.DFe
{
    [DataContract(Namespace = Constantes.DFe, Name = "nfeDistDFeInteresseResponseBody")]
    public class NFeDistDFeInteresseResponseBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0, Name = "nfeDistDFeInteresseResult")]
        public XElement NFeDistDFeInteresseResult;

        public NFeDistDFeInteresseResponseBody()
        {
        }

        public NFeDistDFeInteresseResponseBody(XElement nfeDistDFeInteresseResult)
            => NFeDistDFeInteresseResult = nfeDistDFeInteresseResult;
    }
}