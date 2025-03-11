namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ValueReChEndConsultaPorId
    {
        public Reivindicacao? reivindicacao { get; set; }
        public ChaveValueReChEndConsultaPorId? chave { get; set; }
        public Pessoareclamante? pessoaReclamante { get; set; }
        public Dadosconta? dadosConta { get; set; }
        public Pessoadoador? pessoaDoador { get; set; }
        public Dadoscontadoador? dadosContaDoador { get; set; }
        public DateTime prazoEncerramento { get; set; }
        public DateTime prazoResolucao { get; set; }
        public DateTime ultimaModificacao { get; set; }
        public string ultimaSolicitacao { get; set; } = string.Empty;
        public bool eParticipanteDoador { get; set; }
        public bool eParticipanteReclamante { get; set; }
        public bool ePessoaDoadora { get; set; }
        public bool ePessoaReclamante { get; set; }
    }
}
