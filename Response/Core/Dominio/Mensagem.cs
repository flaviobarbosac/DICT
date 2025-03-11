namespace IvyPay.PI.Dict.Domain.Response.Core.Dominio
{
    public class Mensagem
    {
        public object[]? erros { get; set; }
        public object[]? alertas { get; set; }
        public bool sucesso { get; set; } 
    }
}