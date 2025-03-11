namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ChaveResponse
    {
        public required Tipo2? tipo { get; set; }
        public required string valor { get; set; } = string.Empty;
        public required object nomePsp { get; set; }
    }
}