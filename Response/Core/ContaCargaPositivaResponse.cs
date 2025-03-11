using IvyPay.PI.Dict.Domain.Response.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Response.Core
{
    /// <summary>
    /// Fila 9603 - Carregar Rendcard (sensibiliza saldo positivamente)
    /// {{urlapi_interna}}/Pix/Rendcard/Carga
    /// </summary>
    public class ContaCargaPositivaResponse : Mensagem
    {
        public ConteudoConta? conteudo { get; set; }

    }
}