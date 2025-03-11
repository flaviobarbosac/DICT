namespace IvyPay.PI.Dict.Domain.Response
{
    
    public class GerarQrCodeResponse
    {
        public string idDocumento { get; set; }
        public string payloadBase64 { get; set; }
        public string payloadJws { get; set; }
    }

}
