using System.Runtime.Serialization;
using System.Xml.Linq;

namespace ConsoleApp2.Services.DFe
{
    [DataContract(Namespace = Constantes.DFe, Name = "nfeDistDFeInteresseRequestBody")]
    public class NFeDistDFeInteresseRequestBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0, Name = "nfeDadosMsg")]
        public XElement NFeDadosMsg;

        public NFeDistDFeInteresseRequestBody()
        {
        }

        public NFeDistDFeInteresseRequestBody(XElement nfeDadosMsg)
            => NFeDadosMsg = nfeDadosMsg;
    }
}