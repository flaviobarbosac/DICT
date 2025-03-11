namespace IvyPay.PI.Dict.Domain.Request
{
    public class ReivindicacaoChaveEnderecamentoIncluirRequest : ChaveEnderecamentoIncluirRequest
    {
        public required string tipoReivindicacao { get; set; } = string.Empty;

    }
}