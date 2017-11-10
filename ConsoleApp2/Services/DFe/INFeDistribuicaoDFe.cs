using System.ServiceModel;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.DFe
{
    public class Constantes
    {
        public const string DFe = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe";
    }
    [ServiceContract(Namespace = Constantes.DFe, ConfigurationName = "NFeDistribuicaoDFeSoap")]
    public interface INFeDistribuicaoDFe
    {
        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe/nfeDistDFeInteresse", ReplyAction = "*")]
        Task<NFeDistDFeInteresseResponse> NFeDistDFeInteresseAsync(NFeDistDFeInteresseRequest request);
    }
}