using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Models
{
    public interface IContaBase
    {
        string Conta { get; set; }
        DateTime DataPagto { get; set; }
        DateTime DataVenc { get; set; }
        string Descricao { get; set; }
        int Id { get; set; }
        decimal Multa { get; set; }
        bool Paga { get; set; }
        TipoConta TipoConta { get; }
        decimal Valor { get; set; }
        decimal ValorPago { get; set; }
    }
}
