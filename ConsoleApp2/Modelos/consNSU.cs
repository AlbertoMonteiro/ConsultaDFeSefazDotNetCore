using System.Xml.Serialization;

namespace ConsoleApp2.Modelos
{
    /// <summary>
    /// A09 - Grupo para consultar um DF-e a partir de um NSU espec�fico
    /// </summary>


    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class consNSU
    {
        /// <summary>
        /// A10 - N�mero Sequencial �nico. Geralmente esta consulta ser� utilizada quando identificado pelo interessado um NSU faltante.
        /// O Web Service retornar� o documento ou informar� que o NSU n�o existe no Ambiente Nacional. 
        /// Assim, esta consulta fechar� a lacuna do NSU identificado como faltante.
        /// </summary>
        public string NSU { get; set; }
    }
}