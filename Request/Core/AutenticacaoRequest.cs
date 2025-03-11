namespace IvyPay.PI.Dict.Domain.Request.Core
{
    public class AutenticacaoRequest
    {
        public required string nomeDoUsuario { get; set; }
        public string senha { get; set; } = string.Empty;
    }
}