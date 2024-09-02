using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;


namespace WindowsFormsApp1.Models
{
    public class ContaReceber : ContaBase
    {
        public string Cliwntw { get; set; }
        public string ClienteNome {  get; set; }

        public override TipoConta TipoConta => TipoConta.ContasReceber;

     
        public void ContaReceberMethod()
        {

        }
    }
}
