using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.Services.DFe
{
    public class INFeDistribuicaoDFeClient : ClientBase<INFeDistribuicaoDFe>, INFeDistribuicaoDFe
    {
        public INFeDistribuicaoDFeClient()
            : base(GetBindingForEndpoint(), GetEndpointAddress())
        {
        }

        public Task<NFeDistDFeInteresseResponse> NFeDistDFeInteresseAsync(NFeDistDFeInteresseRequest request)
            => Channel.NFeDistDFeInteresseAsync(request);

        public Task<NFeDistDFeInteresseResponse> NFeDistDFeInteresseAsync(XElement nfeDadosMsg)
            => NFeDistDFeInteresseAsync(new NFeDistDFeInteresseRequest(new NFeDistDFeInteresseRequestBody(nfeDadosMsg)));

        private static Binding GetBindingForEndpoint()
            => new BasicHttpsBinding(BasicHttpsSecurityMode.Transport) { Security = { Transport = { ClientCredentialType = HttpClientCredentialType.Certificate } } };

        private static EndpointAddress GetEndpointAddress()
            => new EndpointAddress("https://www1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx");
    }
}