namespace IvyPay.PI.Dict.Domain.Response
{

    /// <summary>
    /// Listar Reivindicações por Inscrição Nacional
    /// URL: /pi/api/v1/reivindicacao/{{agencia}}/{{conta}}/reivindicacoes/
    /// </summary>
    public class ReChEndListarResponse
    {
        public string transactionId { get; set; } = string.Empty;
        public Erromessage? erroMessage { get; set; }
        public bool isSuccess { get; set; }
        public bool isFailure { get; set; }
        public Value? value { get; set; }
    }
}