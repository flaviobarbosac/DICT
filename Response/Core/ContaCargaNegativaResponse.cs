using IvyPay.PI.Dict.Domain.Response.Core.Dominio;
namespace IvyPay.PI.Dict.Domain.Response.Core
{

    /// <summary>
    /// Fila 9604 - Descarregar Rendcard (sensibiliza saldo negativamente)
    /// {{urlapi_interna}}/Pix/Rendcard/Descarga
    /// </summary>
    public class ContaCargaNegativaResponse : Mensagem
    {
        public ConteudoConta? conteudo { get; set; }
    }
}