namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class Reivindicaco
    {
        public Reivindicacao? reivindicacao { get; set; }
        public Dadosconta? dadosConta { get; set; }
        public Pessoareclamante? pessoaReclamante { get; set; }
        public ChaveReChEndLista? chave { get; set; }
        public Pessoadoador? pessoaDoador { get; set; }
        public Dadoscontadoador? dadosContaDoador { get; set; }
        public DateTime prazoEncerramento { get; set; }
        public DateTime prazoResolucao { get; set; }
        public DateTime ultimaModitificacaoStatus { get; set; }
        public string ultimaSolicitacao { get; set; } = string.Empty;
        public bool eParticipanteDoador { get; set; }
        public bool eParticipanteReclamante { get; set; }
        public bool ePessoaDoadora { get; set; }
        public bool ePessoaReclamante { get; set; }
    }
}