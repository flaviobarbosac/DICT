using IvyPay.PI.Dict.Domain.Request.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Request.Core
{
    /// <summary>
    /// Fila 9607- Valida Existencia conta
    /// {{urlapi_interna}}/Pix/Rendcard/Conta
    /// </summary>
    public class ContaValidaExistenciaRequest
    {
        public required string op { get; set; } = string.Empty;
        public required string path { get; set; } = string.Empty;
        public required Value value { get; set; }
    }
}