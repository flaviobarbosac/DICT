namespace IvyPay.PI.Dict.Domain.Request.DTO
{
    public class AccessTokenDto
    {
        public string Authorization { get; set; } = string.Empty;
        public string ClientId { get; set; } = string.Empty;     
        public string ClientSecret { get; set; } = string.Empty; 
        public string AccessToken { get; set; } = string.Empty;  
    }

    public class AccessTokenChDto : AccessTokenDto
    {
        #region Propriedades para solicitacoes secundarias


        public string ChaveAcesso { get; set; } = string.Empty;


        public string Agencia { get; set; } = string.Empty;


        public string Conta { get; set; } = string.Empty;


        public string Access_token { get; set; } = string.Empty;
        #endregion
    }
}