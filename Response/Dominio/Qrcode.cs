namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class Qrcode
    {
        public Formato? formato { get; set; }
        public string valor { get; set; } = string.Empty;
    }
}