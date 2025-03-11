namespace IvyPay.PI.Dict.Domain.Request
{
    

    public class CashIn
    {
        public string idReqJdPi { get; set; }
        public string endToEndId { get; set; }
        public int tpIniciacao { get; set; }
        public int prioridadePagamento { get; set; }
        public int tpPrioridadePagamento { get; set; }
        public int finalidade { get; set; }
        public string idConciliacaoRecebedor { get; set; }
        public PagadorCI pagador { get; set; }
        public RecebedorCI recebedor { get; set; }
        public DateTime dtHrOp { get; set; }
        public string dtContabil { get; set; }
        public DateTime dtHrLiquidacao { get; set; }
        public float valor { get; set; }
    }

    public class PagadorCI
    {
        public string nrAgencia { get; set; }
        public int ispb { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public int tpConta { get; set; }
        public string nrConta { get; set; }
        public string nome { get; set; }
    }

    public class RecebedorCI
    {
        public int ispb { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public int tpConta { get; set; }
        public string nrConta { get; set; }
        public string nrAgencia { get; set; }
    }

}
