namespace IvyPay.PI.Dict.Domain.Response
{
    /// <summary>
    /// /chave-gestao-api/jdpi/dict/api/v2/{{chave}}?includeStatistics=true
    /// Ivy
    /// </summary>
    public class ChEndConsultaInscricaoResponse
    {
        public string chave { get; set; }=string.Empty;
        public int tpChave { get; set; }
        public int ispb { get; set; }
        public string nrAgencia { get; set; } = string.Empty;
        public string nrConta { get; set; } = string.Empty;
        public int tpConta { get; set; }
        public int tpPessoa { get; set; }
        public long cpfCnpj { get; set; }
        public string nome { get; set; } = string.Empty;
        public string nomeFantasia { get; set; } = string.Empty;
        public DateTime dtHrCriacaoChave { get; set; }
        public DateTime dtHrInicioPosseChave { get; set; }
        public DateTime dtHrAberturaConta { get; set; }
        public string endToEndId { get; set; } = string.Empty;
    }
}