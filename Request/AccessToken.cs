using System.ComponentModel.DataAnnotations;

namespace IvyPay.PI.Dict.Domain.Request
{
    public class AccessToken
    {
        public string Authorization { get; set; } = string.Empty;

        [Required]
        public string client_id { get; set; } = string.Empty;

        [Required]
        public string client_secret { get; set; } = string.Empty;

        [Required]
        public string access_token { get; set; } = string.Empty;
    }
    public class AccessTokenCh : AccessToken
    {
        #region Propriedades para solicitacoes secundarias

        public string chaveAcesso { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public string Conta { get; set; } = string.Empty;

        #endregion
    }
}
