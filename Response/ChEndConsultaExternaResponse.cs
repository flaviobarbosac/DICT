using IvyPay.PI.Dict.Domain.Response.Dominio;

namespace IvyPay.PI.Dict.Domain.Response
{
    public class ChEndConsultaExternaResponse
    {
        public required ValueChEndConsultaExterna value { get; set; }
        public required object message { get; set; }
        public required string transactionId { get; set; } = string.Empty;
        public required Erromessage erroMessage { get; set; }
        public required bool isSuccess { get; set; }
        public required bool isFailure { get; set; }
    }
}