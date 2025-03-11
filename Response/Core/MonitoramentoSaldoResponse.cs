using IvyPay.PI.Dict.Domain.Response.Core.Dominio;

namespace IvyPay.PI.Dict.Domain.Response.Core
{
    public class MonitoramentoSaldoResponse : Mensagem
  {
    public ConteudoMonitoramento? conteudo { get; set; }  
  }
}