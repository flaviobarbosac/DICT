namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ChaveChEndConsulta
    {
        public required Tipo2? tipo { get; set; }
        public required string valor { get; set; } = string.Empty;
        public required bool reivindicadaDoacao { get; set; }
    }
}