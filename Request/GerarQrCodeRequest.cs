namespace IvyPay.PI.Dict.Domain.Request
{
    public class GerarQrCodeRequest
    {
        public int Formato { get; set; }
        public string Chave { get; set; }
        public string CodigoCategoria { get; set; }
        public string NomeRecebedor { get; set; }
        public string SolicitacaoPagador { get; set; }
        public string CpfPagador { get; set; }
        public string CnpjPagador { get; set; }
        public string NomePagador { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public float ValorOriginal { get; set; }
        public string ExpiracaoQR { get; set; }
        public string IdConciliacaoRecebedor { get; set; }
        public List<DadoAdicional> DadosAdicionais { get; set; }
        public bool Reutilizavel { get; set; }
        public string UrlPayloadJson { get; set; }
        public string UrlJwk { get; set; }
    }

    public class DadoAdicional
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
    }

}
