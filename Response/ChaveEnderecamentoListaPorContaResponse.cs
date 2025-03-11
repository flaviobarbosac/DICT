namespace IvyPay.PI.Dict.Domain.Response
{
    public class ChaveEnderecamentoListaPorContaResponse
    {
        public DateTime dtHrJdPi { get; set; }
        public Chavesassociada[] chavesAssociadas { get; set; }
    }

    public class Chavesassociada
    {
        public int tpChave { get; set; }
        public string chave { get; set; }=string.Empty;
        public string nome { get; set; } = string.Empty;
        public string nomeFantasia { get; set; } = string.Empty;
        public DateTime dtHrCriacaoChave { get; set; }
        public DateTime dtHrInicioPosseChave { get; set; }
    }
}
