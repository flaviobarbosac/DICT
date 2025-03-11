namespace IvyPay.PI.Dict.Domain.Response
{
    public class ChEndIncluirResponse
    {
        public string chave { get; set; }= string.Empty;
        public DateTime dtHrCriacaoChave { get; set; }
        public DateTime dtHrInicioPosseChave { get; set; }
    }    
}