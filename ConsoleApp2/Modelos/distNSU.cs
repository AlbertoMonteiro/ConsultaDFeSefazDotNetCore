using System.Xml.Serialization;

namespace ConsoleApp2.Modelos
{
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class distNSU
    {
        private string _ultNsu;

        /// <summary>
        /// A08 - �ltimo NSU recebido pelo ator.
        /// Caso seja informado com zero, ou com um NSU muito antigo, a consulta retornar� unicamente as informa��es resumidas e
        /// documentos fiscais eletr�nicos que tenham sido recepcionados pelo Ambiente Nacional nos �ltimos 3 meses.
        /// </summary>
        public string ultNSU
        {
            get => _ultNsu;
            set => _ultNsu = value.PadLeft(15, '0');
        }
    }
}