namespace IvyPay.PI.Dict.Domain.Request
{
    public class GerarQRCodeImmediate
    {
        public string walletId { get; set; }
        public string externalId { get; set; }
        public string requestToPayer { get; set; }
        public Additionalinformation[] additionalInformation { get; set; }
        public Immediate immediate { get; set; }
    }

    public class Immediate
    {
        public Payerinformation payerInformation { get; set; }
        public int expirationInSeconds { get; set; }
        public float amount { get; set; }
    }

    public class Payerinformation
    {
        public string name { get; set; }
        public string cpfCnpj { get; set; }
    }

    public class Additionalinformation
    {
        public string name { get; set; }
        public string content { get; set; }
    }

}
