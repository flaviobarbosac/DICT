namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ValueReChEndIncluir
    {
        public Reivindicacao? reivindicacao { get; set; }
        public ContaReChEnd?  conta { get; set; }
        public Pessoareclamante? pessoaReclamante { get; set; }
        public DateTime prazoEncerramento { get; set; }
        public DateTime prazoResolucao { get; set; }
        public DateTime ultimaModitificacaoStatus { get; set; }
        public string instituicaoDoadora { get; set; } = string.Empty;
    }
}
