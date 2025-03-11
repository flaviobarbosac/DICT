namespace IvyPay.PI.Dict.Domain.Request.Dominio
{
    public class Chave
    {
        public required int TipoId { get; set; }
        public required string Valor { get; set; } = string.Empty;
    }
}
