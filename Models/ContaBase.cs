using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Models
{
    public abstract class ContaBase : IContaBase
    {
        public string Conta { get; set; }
        public DateTime DataPagto { get; set; }
        public DateTime DataVenc { get; set; }
        public string Descricao { get; set; }
        public int Id { get; set; }
        public decimal Multa { get; set; }
        public bool Paga { get; set; }
        public abstract TipoConta TipoConta { get; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
    }
}
