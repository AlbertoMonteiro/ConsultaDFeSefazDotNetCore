using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Linq;

namespace ConsoleApp2.Services.DFe
{
    [MessageContract(IsWrapped = false)]
    public class NFeDistDFeInteresseResponse
    {
        [MessageBodyMember(Name = "nfeDistDFeInteresseResponse", Namespace = Constantes.DFe, Order = 0)]
        public NFeDistDFeInteresseResponseBody Body;
    }
    
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