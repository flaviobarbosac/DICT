namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class Reivindicacao
    {
        public string id { get; set; } = string.Empty;
        public Status? status { get; set; }
        public Tipo? tipo { get; set; }
        public Participantecancelamento? participanteCancelamento { get; set; }
        public Motivoconfirmacao? motivoConfirmacao { get; set; }
        public Motivocancelamento? motivoCancelamento { get; set; }
    }
}