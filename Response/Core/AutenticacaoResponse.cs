using IvyPay.PI.Dict.Domain.Response.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Response.Core
{
    public class AutenticacaoResponse
    {
        public object? conteudo { get; set; }
        public ErroAutenticacao[]? erros { get; set; }
        public object[]? alertas { get; set; }
        public bool sucesso { get; set; }
        public DateTime created_at { get; set; }
    }
}