namespace IvyPay.PI.Dict.Domain.Response.Core.Dominio
{
    public class ConteudoConta
    {
        public string codigodasolicitacao { get; set; } = string.Empty;
        public int conta { get; set; } = int.MinValue;
        public string numerodeidentificacaolegado { get; set; } =  string.Empty;
        public string tipodeidentificacaolegado { get; set; } = string.Empty;
        public float valor { get; set; } = float.MinValue;
        public string operacaorealizada { get; set; } = string.Empty;
        public string numerodereferencia { get; set; } = string.Empty;
    }
}