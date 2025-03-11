namespace IvyPay.PI.Dict.Domain.Request.Core
{
    public class ContaCargaNegativaRequest
    {
        public required string agencia { get; set; } = string.Empty;
        public required int conta { get; set; }
        public required float valor { get; set; }
        public string observacao { get; set; } = string.Empty;
        public required string numerodereferencia { get; set; }
        public string Motivo { get; set; } = string.Empty;
    }
}