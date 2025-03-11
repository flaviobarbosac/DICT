namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class Error
    {
        public required string domain { get; set; } = string.Empty;
        public required object reason { get; set; }
        public required string message { get; set; } = string.Empty;
    }
}