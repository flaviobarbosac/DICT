namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ContaReChEnd
    {
        public string ispbParticipante { get; set; } = string.Empty;
        public Tipo1? tipo { get; set; }
        public string agencia { get; set; } = string.Empty;
        public string numero { get; set; } = string.Empty;
        public DateTime dataAbertura { get; set; }
    }
}