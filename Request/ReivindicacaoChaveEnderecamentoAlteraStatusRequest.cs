using IvyPay.PI.Dict.Domain.Request.Dominio;

namespace IvyPay.PI.Dict.Domain.Request
{
    /// <summary>
    /// Alterar o status de uma Reinvidicação de Chave de Enderecamento
    /// {{baseurl}}/api/v1/Reivindicacao/{{agencia}}/{{conta}}/reivindicacoes
    /// </summary>
    public class ReivindicacaoChaveEnderecamentoAlteraStatusRequest
    {
        public required Reivindicacao reivindicacao { get; set; }
        public required string ispbParticipante { get; set; } = string.Empty;
        public required string Motivo { get; set; } = string.Empty;
        public required string statusFila { get; set; } = string.Empty;
    }
}