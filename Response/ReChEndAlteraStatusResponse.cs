using IvyPay.PI.Dict.Domain.Response.Dominio;

namespace IvyPay.PI.Dict.Domain.Response
{

    /// <summary>
    /// Alterar o Status de uma Reivindicação de Chave de Endereçamento
    /// URL: /pi/api/v1/reivindicacao/{{agencia}}/{{conta}}/reivindicacoes
    /// </summary>
    public class ReChEndAlteraStatusResponse
    {
        public string transactionId { get; set; } = string.Empty;
        public Erromessage? erroMessage { get; set; }
        public bool isSuccess { get; set; }
        public bool isFailure { get; set; }
        public ValueReChEndIncluir? value { get; set; }
    }
}