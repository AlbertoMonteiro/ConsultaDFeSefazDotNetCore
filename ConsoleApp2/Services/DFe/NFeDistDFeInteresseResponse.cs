using System.ServiceModel;

namespace ConsoleApp2.Services.DFe
{
    [MessageContract(IsWrapped = false)]
    public class NFeDistDFeInteresseResponse
    {
        [MessageBodyMember(Name = "nfeDistDFeInteresseResponse", Namespace = Constantes.DFe, Order = 0)]
        public NFeDistDFeInteresseResponseBody Body;

        public NFeDistDFeInteresseResponse()
        {
        }

        public NFeDistDFeInteresseResponse(NFeDistDFeInteresseResponseBody body)
            => Body = body;
    }
}