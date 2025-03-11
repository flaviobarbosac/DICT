namespace IvyPay.PI.Dict.Domain.Response.Dominio
{

    public class Operacao
    {
        public int id { get; set; }
        public string status { get; set; } = string.Empty;
        public Tipo? tipo { get; set; }
    }
}