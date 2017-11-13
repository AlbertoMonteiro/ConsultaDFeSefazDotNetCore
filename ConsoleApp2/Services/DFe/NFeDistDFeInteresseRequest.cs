using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Linq;

namespace ConsoleApp2.Services.DFe
{
    [MessageContract(IsWrapped = false)]
    public class NFeDistDFeInteresseRequest
    {
        [MessageBodyMember(Name = "nfeDistDFeInteresse", Namespace = Constantes.DFe, Order = 0)]
        public NFeDistDFeInteresseRequestBody Body;

        public NFeDistDFeInteresseRequest(NFeDistDFeInteresseRequestBody body)
            => Body = body;
    }
    
    [DataContract(Namespace = Constantes.DFe)]
    public class NFeDistDFeInteresseRequestBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0, Name = "nfeDadosMsg")]
        public XElement NFeDadosMsg;

        public NFeDistDFeInteresseRequestBody(XElement nfeDadosMsg)
            => NFeDadosMsg = nfeDadosMsg;
    }
}