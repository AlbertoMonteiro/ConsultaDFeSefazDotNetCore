using System.ServiceModel;

namespace ConsoleApp2.Services.DFe
{
    [MessageContract(IsWrapped = false, WrapperName = "nfeDistDFeInteresseRequest")]
    public class NFeDistDFeInteresseRequest
    {
        [MessageBodyMember(Name = "nfeDistDFeInteresse", Namespace = Constantes.DFe, Order = 0)]
        public NFeDistDFeInteresseRequestBody Body;

        public NFeDistDFeInteresseRequest()
        {
        }

        public NFeDistDFeInteresseRequest(NFeDistDFeInteresseRequestBody body)
            => Body = body;
    }
}