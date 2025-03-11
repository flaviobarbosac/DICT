namespace IvyPay.PI.Dict.Domain.Response
{

    public class ContaValidaResponse
    {
        public int resultado { get; set; }
        public string dtHrValidacao { get; set; }
    }


    public class ContaValidaResponse2
    {
        public int resultado { get; set; }
        public string motivo { get; set; }
        public string motivoComplemento { get; set; }
        public string dtHrValidacao { get; set; }
    }

}
