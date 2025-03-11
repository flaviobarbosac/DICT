using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using IvyPay.PI.Dict.Domain.Extensions;
using Microsoft.AspNetCore.Http.Extensions;

namespace IvyPay.PI.Dict.Domain.Entidades
{
    public class LogServicoChamadaEntrada
    {
        [Key]
        public int LogServicoChamadaEntradaId { get; set; } 
        public DateTime DataRecebimento { get; set; } 
        public DateTime DataRetorno { get; set; } 
        public string Endpoint { get; set; } 
        public string RequestBody { get; set; } 
        public string ResponseBody { get; set; } 
        public string StatusCode { get; set; } 
        public long TempoDuracao { get; set; } 
        public string TraceId { get; set; } 


        public LogServicoChamadaEntrada(HttpContext context, string requestBody, string responseBody, long tempo)
        {
            StatusCode = context.Response.StatusCode.ToString();
            DataRecebimento = DateTime.Now;
            DataRetorno = DateTime.Now;
            Endpoint = context.Request.GetDisplayUrl();
            RequestBody = requestBody;
            ResponseBody = responseBody;
            TraceId = context.TraceIdentifier;
            TempoDuracao = tempo;
        }
    }
}
