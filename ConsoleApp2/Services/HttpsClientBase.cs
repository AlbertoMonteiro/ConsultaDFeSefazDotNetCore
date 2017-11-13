using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp2.Services.DFe;

namespace ConsoleApp2
{
    public static class HttpsSoapClientFactory
    {
        public static HttpsSoapClient<INFeDistribuicaoDFe> NFeDistribuicaoDFe(X509Certificate2 certificado)
            => new HttpsSoapClient<INFeDistribuicaoDFe>("https://www1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx", certificado);
    }

    public sealed class HttpsSoapClient<T> : ClientBase<T>, INFeDistribuicaoDFe
        where T : class, INFeDistribuicaoDFe
    {
        public HttpsSoapClient(string urlEndpoint, X509Certificate2 certificado)
            : base(GetBindingForEndpoint(), new EndpointAddress(urlEndpoint))
            => ClientCredentials.ClientCertificate.Certificate = certificado;

        private static Binding GetBindingForEndpoint()
            => new BasicHttpsBinding(BasicHttpsSecurityMode.Transport) { Security = { Transport = { ClientCredentialType = HttpClientCredentialType.Certificate } } };

        Task<NFeDistDFeInteresseResponse> INFeDistribuicaoDFe.NFeDistDFeInteresseAsync(NFeDistDFeInteresseRequest request)
            => Channel.NFeDistDFeInteresseAsync(request);

        Task<NFeDistDFeInteresseResponse> INFeDistribuicaoDFe.NFeDistDFeInteresseAsync(XElement nfeDadosMsg)
            => ((INFeDistribuicaoDFe)this).NFeDistDFeInteresseAsync(new NFeDistDFeInteresseRequest(new NFeDistDFeInteresseRequestBody(nfeDadosMsg)));
    }
}