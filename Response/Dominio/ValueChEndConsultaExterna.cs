namespace IvyPay.PI.Dict.Domain.Response.Dominio
{

    public class ValueChEndConsultaExterna
    {
        public required string endToEnd { get; set; } = string.Empty;
        public required string chaveId { get; set; } = string.Empty;
        public required bool confirmado { get; set; }
        public required ContaResponse conta { get; set; }
        public required PessoaResponse pessoa { get; set; }
        public required ChaveReChEnd chave { get; set; }
        public required Data data { get; set; }
    }
}