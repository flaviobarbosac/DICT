namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class PessoaResponse
    {
        public required Tipo1? tipo { get; set; }
        public required string inscricaoNacional { get; set; } = string.Empty;
        public required string nome { get; set; } = string.Empty;
        public required object nomeFantasia { get; set; } = string.Empty;
    }
}