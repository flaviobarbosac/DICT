using IvyPay.PI.Dict.Domain.Response.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Response.Core
{
    public class ChavePublicaResponse
    {
        public ConteudoChavePublica? conteudo { get; set; }
        public object[]? erros { get; set; }
        public object[]? alertas { get; set; }
        public bool sucesso { get; set; } = false;
        public string chaveCriptografada { get; set; } = string.Empty;
    }
}