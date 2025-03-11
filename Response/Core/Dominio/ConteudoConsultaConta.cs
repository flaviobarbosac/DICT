namespace IvyPay.PI.Dict.Domain.Response.Core.Dominio
{
    public class ConteudoConsultaConta
    {
        public int conta { get; set; }
        public string agencia { get; set; } = string.Empty;
        public string numerodeidentificacaolegado { get; set; } = string.Empty;
        public string tipodeidentificadorlegado { get; set; } = string.Empty;
        public int codigodamoeda { get; set; } = 0;
        public int codigodoreseller { get; set; } = 0;
        public int codigodaempresa { get; set; } = 0;
        public int tipodeempresa { get; set; } = 0;
        public string documento { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
    }
}