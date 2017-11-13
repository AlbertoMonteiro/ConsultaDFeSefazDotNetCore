using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp2.Modelos;
using ConsoleApp2.Services.DFe;

namespace ConsoleApp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new NFeDistribuicaoDFeClient();
            Console.WriteLine("Insira o caminho do certificado:");
            var pathCertificado = Console.ReadLine();
            Console.WriteLine("Insira a senha do certificado:");
            var senha = Console.ReadLine();
            var certificate = new X509Certificate2(pathCertificado, senha);
            client.ClientCredentials.ClientCertificate.Certificate = certificate;

            var dfe = new distDFeInt
            {

                cUFAutor = "23",
                CNPJ = certificate.FriendlyName.Split(':')[1],
                tpAmb = "1",
                versao = "1.01",
                distNSU = new distNSU { ultNSU = "0" }
            };

            try
            {
                var nfeDistDFeInteresseResponse = await client.NFeDistDFeInteresseAsync(XElement.Parse(dfe.ToXml()));

                Console.WriteLine(nfeDistDFeInteresseResponse.Body.NFeDistDFeInteresseResult.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
