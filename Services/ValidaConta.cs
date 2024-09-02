using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Services
{
    public class ValidaConta
    {
        private bool ValidaContaPagar(ContaPagar contaPagar)
        {
            // O valor deve ser maior que zero
            if (contaPagar.Valor <= 0)
            {
                throw new ArgumentException("O valor da conta a pagar deve ser maior que zero.");
            }

            //  A data de vencimento não pode ser no passado
            if (contaPagar.DataVenc < DateTime.Now)
            {
                throw new ArgumentException("A data de vencimento da conta a pagar não pode ser no passado.");
            }

            return true;
        }

        private bool ValidaContaReceber(ContaReceber contaReceber)
        {
            // O valor deve ser maior que zero
            if (contaReceber.Valor <= 0)
            {
                throw new ArgumentException("O valor da conta a receber deve ser maior que zero.");
            }

            // A data de vencimento não pode ser no passado
            if (contaReceber.DataVenc < DateTime.Now)
            {
                throw new ArgumentException("A data de vencimento da conta a receber não pode ser no passado.");
            }


            return true;
        }

        public void ValidarConta(IContaBase conta)
        {
            switch (conta.TipoConta)
            {
                case TipoConta.ContasPagar:
                    ValidaContaPagar((ContaPagar)conta);
                    break;

                case TipoConta.ContasReceber:
                    ValidaContaReceber((ContaReceber)conta);
                    break;

                default:
                    throw new ArgumentException("Tipo de conta desconhecido.");
            }
        }
    }
}
