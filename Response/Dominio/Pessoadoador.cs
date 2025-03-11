namespace IvyPay.PI.Dict.Domain.Response.Dominio

{
    public class Pessoadoador
    {
        public Tipo4? tipo { get; set; }
        public string inscricaoNacional { get; set; } = string.Empty;
        public string nome { get; set; } = string.Empty;
        public string nomeFantasia { get; set; } = string.Empty;
    }
}
