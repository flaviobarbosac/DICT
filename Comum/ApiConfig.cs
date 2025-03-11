namespace IvyPay.PI.Dict.Domain.Comum
{
    public class ApiConfig
    {
        //Parametros revisados para a Ivy
        public string urlRencard { get; set; } = string.Empty;        
        public string incluirChave { get; set; } = string.Empty; 
        public string autenticacao { get; set; } = string.Empty;
        public string consultarChave { get; set; } = string.Empty;
        public string listarChavesPorConta { get; set; } = string.Empty;

        //Daqui pra baixo é pra ir removendo o que não for sendo utilizado
        public string urlAPICC { get; set; } = string.Empty;        
        
        public string excluirchave { get; set; } = string.Empty;        
        public string incluirReivindicacao { get; set; } = string.Empty;
        public string listaReivindicacao { get; set; } = string.Empty;
        public string consultaReivindicadaoPorId { get; set; } = string.Empty;
        public string alterarStatusReivindicacao { get; set; } = string.Empty;
        public string autenticacaoAPICC { get; set; } = string.Empty;
        public string obterChave { get; set; } = string.Empty;
        public string contaCarga { get; set; } = string.Empty;
        public string contaDescarga { get; set; } = string.Empty;
        public string contaSaldo { get; set; } = string.Empty;
        public string consultaConta { get; set; } = string.Empty;
        public string validaConta { get; set; } = string.Empty;
        public string monitoramentoSaldo { get; set; } = string.Empty;
        public string gerar_Codigo { get; set; } = string.Empty;
        public string obter_Token { get; set; } = string.Empty;
        public string gerar_ordem_pagamento { get; set; } = string.Empty;
        public string connectionstring { get; set; } = string.Empty;
        public string UrlPayloadJson { get; set; } = string.Empty;
        public string UrlJwk { get; set; } = string.Empty;
    }
}