namespace IvyPay.PI.Dict.Domain.Response.Core.Dominio
{
    public class ConteudoMonitoramento
    {
        public int conta { get; set; } = int.MinValue;
        public string agencia { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
    }
}