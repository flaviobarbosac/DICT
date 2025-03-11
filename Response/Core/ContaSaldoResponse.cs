using IvyPay.PI.Dict.Domain.Response.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Response.Core
{

    /// <summary>
    /// Fila 9605 - Consultar saldo
    /// {{urlapi_interna}}/Pix/Rendcard/Agencia/0001/Conta/3462/saldo
    /// </summary>    
    public class ContaSaldoResponse : Mensagem
    {
        public ConteudoSaldo? conteudo { get; set; }
    }
}