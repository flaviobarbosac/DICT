namespace IvyPay.PI.Dict.Domain.Request
{

    public class ValidaCredito
    {
        public int tpIniciacao { get; set; }
        public int prioridadePagamento { get; set; }
        public int tpPrioridadePagamento { get; set; }
        public int finalidade { get; set; }
        public PagadorC pagador { get; set; }
        public RecebedorC recebedor { get; set; }
        public DateTime dtHrOp { get; set; }
        public float valor { get; set; }
        public Creditoordempagamento creditoOrdemPagamento { get; set; }
    }

    public class PagadorC
    {
        public string nrAgencia { get; set; }
        public int ispb { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public int tpConta { get; set; }
        public string nrConta { get; set; }
        public string nome { get; set; }
    }

    public class RecebedorC
    {
        public int ispb { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public int tpConta { get; set; }
        public string nrConta { get; set; }
        public string nrAgencia { get; set; }
    }

    public class Creditoordempagamento
    {
        public string endToEndId { get; set; }
        public string idConciliacaoRecebedor { get; set; }
    }

}
