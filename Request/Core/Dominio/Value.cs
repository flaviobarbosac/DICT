namespace IvyPay.PI.Dict.Domain.Request.Core.Dominio
{
    public class Value
    {
        public required int conta { get; set; }
        public required string agencia { get; set; } = string.Empty;
    }
}