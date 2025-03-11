namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public  class BeneficiarioOrdemPagamento
    {
        public string chave { get; set; } = string.Empty;
        public string endToEnd { get; set; } = string.Empty; 
        public ContaOrdemPagamento? conta { get; set; }
        public PessoaOrdemPagamento1? pessoa { get; set; }
    }
}
