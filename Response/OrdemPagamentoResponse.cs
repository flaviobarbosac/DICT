namespace IvyPay.PI.Dict.Domain.Response
{

    public class OrdemPagamentoResponse
    {
        public string idReqSistemaCliente { get; set; }
        public string idReqJdPi { get; set; }
        public string endToEndId { get; set; }
        public DateTime dtHrReqJdPi { get; set; }
        public int tpCanal { get; set; }
    }

}
