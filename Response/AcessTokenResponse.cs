namespace IvyPay.PI.Dict.Domain.Response
{
    /// <summary>
    /// Autenticação - Ivy
    /// {{BaseUrl}}/auth/jdpi/connect/token
    /// </summary>
    public class AcessTokenResponse
    {
        public int expires_in { get; set; }
        public string access_token { get; set; }=string.Empty;
        public string token_type { get; set; } = string.Empty;
        public string scope { get; set; } = string.Empty;
    }
}