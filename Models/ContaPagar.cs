using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Models
{
    public class ContaPagar : ContaBase
    {
        public string NotaNumero { get; set; }
        public string NotaVinculada { get; set; }

        public override TipoConta TipoConta => TipoConta.ContasPagar;

        
        public void ContaPagarMethod()
        {
            
        }
    }
}
