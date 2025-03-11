namespace IvyPay.PI.Dict.Domain.Response
{

    /// <summary>
    /// Consultar reinvidicaçao por ID
    /// {{baseurl}}/api/v1/Reivindicacao/{{agencia}}/{{conta}}/reivindicacoes/:reivindicacaoId?InscricaoNacional=&IspbParticipante=
    /// </summary>
    public class ReConsultaResponse
    {
        public string transactionId { get; set; } = string.Empty;
        public Erromessage? erroMessage { get; set; }
        public bool isSuccess { get; set; }
        public bool isFailure { get; set; }
        public Value? value { get; set; }
    }

    public class Erromessage
    {
        public int statusCode { get; set; }
        public string message { get; set; } = string.Empty;
        public List<Error>? errors { get; set; }
    }

    public class Error
    {
        public string domain { get; set; } = string.Empty;
        public string reason { get; set; } = string.Empty;
        public string message { get; set; } = string.Empty;
    }

    public class Value
    {
        public string chaveId { get; set; } = string.Empty;
        public Reivindicacao? reivindicacao { get; set; }        
        public Pessoareclamante? pessoaReclamante { get; set; }
        public Dadosconta? dadosConta { get; set; }
        public Pessoadoador? pessoaDoador { get; set; }
        public Dadoscontadoador? dadosContaDoador { get; set; }
        public DateTime prazoEncerramento { get; set; }
        public DateTime prazoResolucao { get; set; }
        public DateTime ultimaModificacao { get; set; }
        public string ultimaSolicitacao { get; set; } = string.Empty;
        public bool eParticipanteDoador { get; set; }
        public bool eParticipanteReclamante { get; set; }
        public bool ePessoaDoadora { get; set; }
        public bool ePessoaReclamante { get; set; }
    }

    public class Reivindicacao
    {
        public string id { get; set; } = string.Empty;
        public StatusConsulta? status { get; set; }        
        public Participantecancelamento? participanteCancelamento { get; set; }
        public Motivoconfirmacao? motivoConfirmacao { get; set; }
        public Motivocancelamento? motivoCancelamento { get; set; }
    }

    public class StatusConsulta
    {
        public string id { get; set; } = string.Empty;
        public string descricao { get; set; } = string.Empty;
    }

    public class Participantecancelamento
    {
        public int id { get; set; }
        public string descricao { get; set; } = string.Empty;
    }

    public class Motivoconfirmacao
    {
        public int id { get; set; }
        public string descricao { get; set; } = string.Empty;
    }

    public class Motivocancelamento
    {
        public int id { get; set; }
        public string descricao { get; set; } = string.Empty;
    }



    public class Pessoareclamante
    {
        public Tipo2? tipo { get; set; }
        public string inscricaoNacional { get; set; } = string.Empty;
        public string nome { get; set; } = string.Empty;
        public string nomeFantasia { get; set; } = string.Empty;
    }

    public class Tipo2
    {
        public int id { get; set; }
        public string descricao { get; set; } = string.Empty;
    }

    public class Dadosconta
    {
        public string ispbParticipante { get; set; } = string.Empty;
        public string nomeParticipante { get; set; } = string.Empty;
        public Tipo3? tipo { get; set; }
        public string agencia { get; set; } = string.Empty;
        public string numero { get; set; } = string.Empty;
        public DateTime dataAbertura { get; set; }
    }

    public class Tipo3
    {
        public string id { get; set; } = string.Empty;
        public string descricao { get; set; } = string.Empty;
    }

    public class Pessoadoador
    {
        public Tipo4? tipo { get; set; }
        public string inscricaoNacional { get; set; } = string.Empty;
        public string nome { get; set; } = string.Empty;
        public string nomeFantasia { get; set; } = string.Empty;
    }

    public class Tipo4
    {
        public string id { get; set; } = string.Empty;
        public string descricao { get; set; } = string.Empty;
    }

    public class Dadoscontadoador
    {
        public string ispbParticipante { get; set; } = string.Empty;
        public string nomeParticipante { get; set; } = string.Empty;
        public Tipo5? tipo { get; set; }
        public string agencia { get; set; } = string.Empty;
        public string numero { get; set; } = string.Empty;
        public DateTime dataAbertura { get; set; }
    }

    public class Tipo5
    {
        public string id { get; set; } = string.Empty;
        public string descricao { get; set; } = string.Empty;
    }
}