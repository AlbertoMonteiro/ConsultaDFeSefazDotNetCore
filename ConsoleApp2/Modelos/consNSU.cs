using System.Xml.Serialization;

namespace ConsoleApp2.Modelos
{
    /// <summary>
    /// A09 - Grupo para consultar um DF-e a partir de um NSU específico
    /// </summary>


    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class consNSU
    {
        /// <summary>
        /// A10 - Número Sequencial Único. Geralmente esta consulta será utilizada quando identificado pelo interessado um NSU faltante.
        /// O Web Service retornará o documento ou informará que o NSU não existe no Ambiente Nacional. 
        /// Assim, esta consulta fechará a lacuna do NSU identificado como faltante.
        /// </summary>
        public string NSU { get; set; }
    }
}