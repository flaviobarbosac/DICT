using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvyPay.PI.Dict.Domain.Response.Dominio
{
    public class RetornoQrCode
    {
        public Calendario calendario { get; set; }
        public Valor valor { get; set; }
        public int revisao { get; set; }
        public Devedor devedor { get; set; }
        public string chave { get; set; }
        public string txid { get; set; }
        public string solicitacaoPagador { get; set; }
        public List<Infoadicionai> infoAdicionais { get; set; }
        public string status { get; set; }
    }

    public class Calendario
    {
        public int expiracao { get; set; }
        public DateTime criacao { get; set; }
        public DateTime apresentacao { get; set; }
    }

    public class Valor
    {
        public string original { get; set; }
        public int modalidadeAlteracao { get; set; }
    }

    public class Devedor
    {
        public string cpf { get; set; }
        public string nome { get; set; }
    }

    public class Infoadicionai
    {
        public string nome { get; set; }
        public string valor { get; set; }
    }
}
