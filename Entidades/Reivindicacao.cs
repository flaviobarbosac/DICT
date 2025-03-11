using IvyPay.PI.Dict.Domain.Request;
using IvyPay.PI.Dict.Domain.Response;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace IvyPay.PI.Dict.Domain.Entidades
{
    public class Reivindicacao
    {
        [Key]
        public int Id { get; set; }
        public string TipoReinvindicacao { get; set; } = string.Empty;
        public string TransactionID { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public string Conta { get; set; } = string.Empty;
        public string ispbParticipante { get; set; } = string.Empty;
        public string inscricaoNacional { get; set; } = string.Empty;
        public DateTime DataHora { get; set; }
        public string Mensagem { get; set; } = string.Empty;

        public void SetaRequest(string inscricaoNacional, ReivindicacaoChaveEnderecamentoIncluirRequest reChEndIncluirRequest, ReChEndIncluirResponse? resultado, AccessTokenCh accessToken)
        {
            this.TipoReinvindicacao = reChEndIncluirRequest.tipoReivindicacao;
            this.ispbParticipante = "";
            this.inscricaoNacional = "";
            this.Agencia = accessToken.Agencia;
            this.Conta = accessToken.Conta;
            this.DataHora = DateTime.UtcNow.AddHours(-3);
            this.TransactionID = resultado?.transactionId ?? "0";
            
            // Verificação condicional antes de serializar
            if (resultado != null)
            {
                this.Mensagem = JsonSerializer.Serialize<ReChEndIncluirResponse>(resultado); 
            }
            else
            {
                this.Mensagem = "{}";
            }
        }

        public void SetaRequest(string inscricaoNacional, string ispbParticipante, string tipoReivindicacao, ReChEndListarResponse? resultado, AccessTokenCh accessToken)
        {
            this.TipoReinvindicacao = tipoReivindicacao;
            this.inscricaoNacional = inscricaoNacional;
            this.ispbParticipante = ispbParticipante;
            this.Agencia = accessToken.Agencia;
            this.Conta = accessToken.Conta;
            this.DataHora = DateTime.UtcNow.AddHours(-3);
            this.TransactionID = resultado?.transactionId ?? "0";

            // Verificação condicional antes de serializar
            if (resultado != null)
            {
                this.Mensagem = JsonSerializer.Serialize<ReChEndListarResponse>(resultado); 
            }
            else
            {
                this.Mensagem = "{}";
            }
        }

        public void SetaRequest(string inscricaoNacional, string ispbParticipante, string reivindicacaoId, ReChEndConsultaPorIdResponse? resultado, AccessTokenCh accessToken)
        {
            this.TipoReinvindicacao = reivindicacaoId;
            this.inscricaoNacional = inscricaoNacional;
            this.ispbParticipante = ispbParticipante;
            this.Agencia = accessToken.Agencia;
            this.Conta = accessToken.Conta;
            this.DataHora = DateTime.UtcNow.AddHours(-3);
            this.TransactionID = resultado?.transactionId ?? "0";

            // Verificação condicional antes de serializar
            if (resultado != null)
            {
                this.Mensagem = JsonSerializer.Serialize<ReChEndConsultaPorIdResponse>(resultado); 
            }
            else
            {
                this.Mensagem = "{}";
            }
        }

        public void SetaRequest(ReivindicacaoChaveEnderecamentoAlteraStatusRequest dados, ReChEndAlteraStatusResponse? resultado, AccessTokenCh accessToken)
        {
            this.TipoReinvindicacao = dados.reivindicacao.id;
            this.inscricaoNacional = "";
            this.ispbParticipante = dados.ispbParticipante;
            this.Agencia = accessToken.Agencia;
            this.Conta = accessToken.Conta;
            this.DataHora = DateTime.UtcNow.AddHours(-3);
            this.TransactionID = resultado?.transactionId ?? "0";

            // Verificação condicional antes de serializar
            if (resultado != null)
            {
                this.Mensagem = JsonSerializer.Serialize<ReChEndAlteraStatusResponse>(resultado); 
            }
            else
            {
                this.Mensagem = "{}";
            }
        }

        public void SetaRequest(ReivindicacaoChaveEnderecamentoIncluirRequest dados, ReChEndIncluirResponse? resultado, AccessTokenCh accessToken)
        {
            this.TipoReinvindicacao = dados.tipoReivindicacao;
            //this.inscricaoNacional = dados.Pessoa.InscricaoNacional;
            this.ispbParticipante = "";
            this.Agencia = accessToken.Agencia;
            this.Conta = accessToken.Conta;
            this.DataHora = DateTime.UtcNow.AddHours(-3);
            this.TransactionID = resultado?.transactionId ?? "0";

            // Verificação condicional antes de serializar
            if (resultado != null)
            {
                this.Mensagem = JsonSerializer.Serialize<ReChEndIncluirResponse>(resultado); 
            }
            else
            {
                this.Mensagem = "{}";
            }
        }
    }
}
