namespace IvyPay.PI.Dict.Domain.Request.Dominio
{
    public class Pessoa
    {
        public required string InscricaoNacional { get; set; } = string.Empty;
        public required string Nome { get; set; } = string.Empty;
        public string NomeFantasia { get; set; } = string.Empty;
        public required string TipoId { get; set; } = string.Empty;
    }
}
