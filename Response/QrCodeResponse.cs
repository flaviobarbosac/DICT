namespace IvyPay.PI.Dict.Domain.Response
{
   

    public class QrCodeResponse
    {
        public Data1 data { get; set; }
        public Meta meta { get; set; }
    }

    public class Data1
    {
        public string walletId { get; set; }
        public string pixDictKey { get; set; }
        public string pixChargeId { get; set; }
        public string pixChargeExternalId { get; set; }
        public string pixChargeTextContent { get; set; }
        public string pixChargeStatus { get; set; }
        public string pixChargeIdConciliation { get; set; }
        public string pixChargeUrl { get; set; }
        public string pixChargeCreatedAt { get; set; }
        public float pixChargeValue { get; set; }
        public string pixChargeQrCodeType { get; set; }
    }

    public class Meta
    {
        public string requestDateTime { get; set; }
    }

}
