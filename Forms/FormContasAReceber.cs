using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class FormContasAReceber : Form
    {
        public FormContasAReceber()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Label " + ((Label)sender).Name);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeCliente.Text))
            {
                MessageBox.Show("Por favor, informe o nome do Cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNomeCliente.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(TxbValor.Text))
            {
                MessageBox.Show("Por favor, informe um valor válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbValor.Focus();
                return;
            }

            try
            {
                // Captura e popula o objeto ContaPagar
                ContaReceber contaReceber = new ContaReceber
                {
                    Valor = decimal.Parse(TxbValor.Text)
                    //DataVenc = dateTimePicker.Value
                };
   
                // Valida a ContaPagar
                ValidaConta validador = new ValidaConta();
                validador.ValidarConta(contaReceber);

                MessageBox.Show("Validação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

      
}

