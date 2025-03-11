namespace IvyPay.PI.Dict.Domain.Request.Dominio
{
    public class Conta
    {
        public required string ISPBParticipante { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public required string Numero { get; set; } = string.Empty;
        public required string DataAbertura { get; set; } = string.Empty;
        public required string TipoId { get; set; } = string.Empty;
    }
}
