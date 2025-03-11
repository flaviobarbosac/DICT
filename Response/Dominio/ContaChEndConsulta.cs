namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ContaChEndConsulta
    {
        public required string ispbParticipante { get; set; } = string.Empty;
        public required string nomeParticipante { get; set; } = string.Empty;
        public required Tipo tipo { get; set; }
        public required string agencia { get; set; } = string.Empty;
        public required string numero { get; set; } = string.Empty;
        public required DateTime dataAbertura { get; set; }
    }
}