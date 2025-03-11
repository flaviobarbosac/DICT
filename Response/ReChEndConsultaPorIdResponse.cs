using IvyPay.PI.Dict.Domain.Response.Dominio;

namespace IvyPay.PI.Dict.Domain.Response
{

    /// <summary>
    /// Consultar Reivindicações e/ou Portabilidade por ID
    /// URL: /pi/api/v1/reivindicacao/{{agencia}}/{{conta}}/reivindicacoes/{{reivindicacaoId}}
    /// </summary>
    public class ReChEndConsultaPorIdResponse
    {
        public string transactionId { get; set; } = string.Empty;
        public Erromessage? erroMessage { get; set; }
        public bool isSuccess { get; set; }
        public bool isFailure { get; set; }
        public ValueReChEndConsultaPorId? value { get; set; }
    }
}