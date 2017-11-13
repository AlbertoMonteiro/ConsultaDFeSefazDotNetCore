using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.Services.DFe
{
    public class NFeDistribuicaoDFeClient : HttpsClientBase<INFeDistribuicaoDFe>, INFeDistribuicaoDFe
    {
        public NFeDistribuicaoDFeClient()
            : base("https://www1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx")
        {
        }

        public Task<NFeDistDFeInteresseResponse> NFeDistDFeInteresseAsync(NFeDistDFeInteresseRequest request)
            => Channel.NFeDistDFeInteresseAsync(request);

        public Task<NFeDistDFeInteresseResponse> NFeDistDFeInteresseAsync(XElement nfeDadosMsg)
            => NFeDistDFeInteresseAsync(new NFeDistDFeInteresseRequest(new NFeDistDFeInteresseRequestBody(nfeDadosMsg)));
    }
}