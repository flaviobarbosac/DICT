using Microsoft.AspNetCore.Mvc;

namespace IvyPay.PI.Dict.Domain.Request.Core.Dominio
{
    public class AccessToken
    {
        [FromHeader]
        public string chaveAcesso { get; set; } = string.Empty;
        [FromHeader]
        public string Agencia { get; set; } = string.Empty;
        [FromHeader]
        public string Conta { get; set; } = string.Empty;
        [FromHeader]
        public string client_id { get; set; } = string.Empty;
    }
}