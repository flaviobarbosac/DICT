namespace IvyPay.PI.Dict.Domain.Request
{
    public class ChaveEnderecamentoListaPorContaRequest
    {
        public int ispb { get; set; }
        public string nrAgencia { get; set; } = string.Empty;
        public int tpConta { get; set; }
        public string nrConta { get; set; } = string.Empty;
        public int tpPessoa { get; set; }
        public string cpfCnpj { get; set; } = string.Empty;
    }
}