using IvyPay.PI.Dict.Domain.Response.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Response.Core
{

    /// <summary>
    /// Fila 9607- Valida Existencia conta
    /// {{urlapi_interna}}/Pix/Rendcard/Conta
    /// </summary>   
    public class ContaValidaExistenciaResponse : Mensagem
    {
        public ConteudoValidaExistencia? conteudo { get; set; }

    }
}