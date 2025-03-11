using System.ComponentModel.DataAnnotations;

namespace IvyPay.PI.Dict.Domain.Entidades
{
    public class LogServicoChamadaSaida
    {
        public LogServicoChamadaSaida(string origem, DateTime dataEnvio, DateTime dataRecebimento, string metodo, string endpoint, string request, string response, int statusCodeResponse, int tempoDuracao)
        {
            Origem = origem;
            DataEnvio = dataEnvio;
            DataRecebimento = dataRecebimento;
            Metodo = metodo;
            Endpoint = endpoint;
            Request = request;
            Response = response;
            StatusCodeResponse = statusCodeResponse;
            TempoDuracao = tempoDuracao;
            Header = string.Empty;
        }

        [Key]
        public int LogServicoChamadaSaidaId { get; set; }
        public string Origem { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataRecebimento { get; set; }
        public string Metodo { get; set; } 
        public string Endpoint { get; set; } 
        public string Request { get; set; } 
        public string Response { get; set; } 
        public int StatusCodeResponse { get; set; } 
        public int TempoDuracao { get; set; } 
        public string Header { get; set; } 
    }
}
