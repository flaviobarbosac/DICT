namespace IvyPay.PI.Dict.Domain.Comum
{
    public class ChaveSecreta
    {
        public string password { get; set; }
    }

    public class CredencialsConfig
    {
        //Parametros revisados para a Ivy
        public string client_id { get; set; } = string.Empty;
        public string client_secret { get; set; } = string.Empty;
        public string grant_type { get; set; } = string.Empty;
        public string scope { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty ;
        public string Cookie { get; set; } = string.Empty;
        public string accessKeyId { get; set; } = string.Empty;
        public string secretAccessKey { get; set; } = string.Empty;
        public string sessionToken { get; set; } = string.Empty;
        public string secretName { get; set; } = string.Empty;       


        //Daqui pra baixo é pra ir removendo o que não for sendo utilizado
        public string chaveAcesso { get; set; } = string.Empty;
        public string authorization { get; set; } = string.Empty;
        public string client_id_dict { get; set; } = string.Empty;
        public string agencia{ get; set; } = string.Empty;
        public string conta { get; set; } = string.Empty;
        public string ispbParticipante { get; set; } = string.Empty;
        public string includeStatistics { get; set; } = string.Empty;
        public string tokenKey { get; set; } = string.Empty;
        public string tempoautenticacaoRedisMinuto { get; set; } = string.Empty;
        public string client_id_apicc { get; set; } = string.Empty;
        public string mensagemCripto { get; set; } = string.Empty;
        public string nomeDoUsuario { get; set; } = string.Empty;
        public string chaveapicc { get; set; } = string.Empty;
        public string senhacriptografada { get; set; } = string.Empty;
        public string tokenKeyAPICC { get; set; } = string.Empty;        
    }
}