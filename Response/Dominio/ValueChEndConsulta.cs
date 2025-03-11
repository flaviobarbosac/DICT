namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class ValueChEndConsulta
    {
        public required string chaveId { get; set; } = string.Empty;
        public required string endToEnd { get; set; } = string.Empty;
        public required bool confirmado { get; set; }
        public required ContaChEndConsulta conta { get; set; }
        public required PessoaResponse pessoa { get; set; }
        public required ChaveChEndConsulta chave { get; set; }
        public required Data data { get; set; }
    }
}