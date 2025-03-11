namespace IvyPay.PI.Dict.Domain.Request.Core
{
  public class ConsultaContaRequest
  {    
    public string NumeroDeIdentificacaoLegado { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string Client_id { get; set; } = string.Empty;
    }
}
