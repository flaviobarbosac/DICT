namespace IvyPay.PI.Dict.Domain.Request
{
       public class OrdemPagamentoRequest
    {
        public string idReqSistemaCliente { get; set; }
        public DateTime dtHrRequisicaoPsp { get; set; }
        public int tpIniciacao { get; set; }
        public int prioridadePagamento { get; set; }
        public int tpPrioridadePagamento { get; set; }
        public int finalidade { get; set; }
        public string cnpjIniciadorPagamento { get; set; }
        public Pagador pagador { get; set; }
        public Recebedor recebedor { get; set; }
        public string chave { get; set; }
        public float valor { get; set; }
        public string infEntreClientes { get; set; }
    }

    public class Pagador
    {
        public int ispb { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public string nome { get; set; }
        public string nrAgencia { get; set; }
        public int tpConta { get; set; }
        public string nrConta { get; set; }
    }

    public class Recebedor
    {
        public int ispb { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public string nrAgencia { get; set; }
        public int tpConta { get; set; }
        public string nrConta { get; set; }
        public string nome { get; set; }
    }

}
