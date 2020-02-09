using System;

namespace APICotacoes.Models
{
    public class Cotacao
    {
        public string Sigla { get; set; }
        public string NomeMoeda { get; set; }
        public DateTime UltimaCotacao { get; set; }
        public Valor Valor { get; set; }
    }

    public class Valor
    {
        public decimal Comercial { get; set; }
        public decimal? Turismo { get; set; }
    }
}