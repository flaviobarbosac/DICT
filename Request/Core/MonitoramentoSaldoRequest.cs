namespace IvyPay.PI.Dict.Domain.Request.Core
{

    public class MonitoramentoSaldoRequest
    {
        public string agencia { get; set; } = string.Empty;
        public int conta { get; set; } = 0;
        public string operacao { get; set; } = string.Empty;
    }
}