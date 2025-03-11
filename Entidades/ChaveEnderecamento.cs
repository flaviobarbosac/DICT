using IvyPay.PI.Dict.Domain.Request;
using IvyPay.PI.Dict.Domain.Response;
using System.Text.Json;

namespace IvyPay.PI.Dict.Domain.Entidades
{

    public class ChaveEnderecamento
    {
        public int Id { get; set; } 
        public string Agencia { get; set; }=string.Empty;
        public string Conta { get; set; }= string.Empty;
        public int TipoId { get; set; }
        public string ValorChave { get; set; } = string.Empty;
        public string ChaveId { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public DateTime DataHora { get; set; }
        public int Sucesso { get; set; }
        public string Mensagem { get; set; } = string.Empty;

        public void SetaRequest(ChaveEnderecamentoIncluirRequest dados, ChEndIncluirResponse? resultado, AccessTokenCh accessTokenCh)
        {
            this.Conta = accessTokenCh.Conta;
            this.Agencia = accessTokenCh.Agencia;
            //this.ValorChave = dados.Chave.Valor;
            this.DataHora = DateTime.UtcNow.AddHours(-3);

            if (resultado != null)            
            {
                // Bloco executado se 'resultado' é nulo
                this.ChaveId = "";
                this.Sucesso = 0;
                this.TransactionId = string.Empty;
            }

            // Mensagem é sempre definida, independentemente de 'resultado' ser nulo ou não
            this.Mensagem = JsonSerializer.Serialize<ChEndIncluirResponse>(resultado ?? new ChEndIncluirResponse());

            // TipoId é sempre definido, pois depende apenas de 'dados'
            //this.TipoId = dados.Chave.TipoId;
        }

        public void SetaRequest(ChaveEnderecamentoExcluirRequest dados, ChEndExcluirResponse? resultado, AccessTokenCh accessToken, string chave)
        {
            this.Conta = accessToken.Conta;
            this.Agencia = accessToken.Agencia;
            this.ValorChave = chave;
            this.DataHora = DateTime.Now;
            this.ChaveId = "";
            //this.Sucesso = resultado.isSuccess ? 1 : 0;
            this.Mensagem = JsonSerializer.Serialize<ChEndExcluirResponse>(resultado);
            //this.TransactionId = resultado.transactionId;
            this.TipoId = 99; // 99 é o tipo de exclusao
        }

        public void SetaRequest(string chaveExterna, ChEndConsultaExternaResponse resultado, AccessTokenCh accessToken)
        {
            this.Conta = accessToken.Conta;
            this.Agencia = accessToken.Agencia;
            this.ValorChave = chaveExterna;
            this.DataHora = DateTime.Now;
            this.ChaveId = "";
            this.Sucesso = resultado.isSuccess ? 1 : 0;
            this.Mensagem = JsonSerializer.Serialize<ChEndConsultaExternaResponse>(resultado);
            this.TransactionId = resultado.transactionId;
            this.TipoId = 98; // 99 é o tipo de consulta chave externa
        }

        public void SetaRequest(string inscricaoNacional, ChEndConsultaInscricaoResponse resultado, AccessTokenCh accessToken)
        {
            this.Conta = accessToken.Conta;
            this.Agencia = accessToken.Agencia;
            this.ValorChave = inscricaoNacional;
            this.DataHora = DateTime.Now;
            this.ChaveId = "";
            //this.Sucesso = resultado.isSuccess ? 1 : 0;
            this.Mensagem = JsonSerializer.Serialize<ChEndConsultaInscricaoResponse>(resultado);
            //this.TransactionId = resultado.transactionId;
            this.TipoId = 97; // 99 é o tipo de consulta de inscricao
        }
    }
}