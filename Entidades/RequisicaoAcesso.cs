namespace IvyPay.PI.Dict.Domain.Entidades
{
    public class RequisicaoAcesso
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string ClientId { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Etapa { get; set; } = string.Empty;
    }
}
