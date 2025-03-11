namespace IvyPay.PI.Dict.Domain.Request
{
    /// <summary>
    /// Excluir Chave de Endereçamento - Ivy
    /// {{baseurl}}/chave-gestao-api/jdpi/dict/api/v2/{{chave}}/excluir
    /// </summary>
    public class ChaveEnderecamentoExcluirRequest
    {
        public int tpChave { get; set; }
        public string chave { get; set; } = string.Empty;
        public int ispb { get; set; }
        public string nrAgencia { get; set; } = string.Empty;
        public int tpConta { get; set; }
        public string nrConta { get; set; } = string.Empty;
        public DateTime dtHrAberturaConta { get; set; }
        public int tpPessoa { get; set; }
        public string cpfCnpj { get; set; } = string.Empty;
        public string nome { get; set; } = string.Empty;
        public string nomeFantasia { get; set; } = string.Empty;
        public int motivo { get; set; }
    }
}