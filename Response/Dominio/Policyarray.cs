namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class Policyarray
    {
        public int availableTokens { get; set; }
        public int capacity { get; set; }
        public int refillTokens { get; set; }
        public int refillPeriodSec { get; set; }
        public string name { get; set; } = string.Empty;
    }
}