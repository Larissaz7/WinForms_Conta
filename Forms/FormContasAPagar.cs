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
    public partial class FormContasAPagar : Form
    {

        public FormContasAPagar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Label " + ((Label)sender).Name);
        }
        
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeFornecedor.Text))
            {
                MessageBox.Show("Por favor, informe o nome do fornecedor.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNomeFornecedor.Focus();
                return;
            }

            if (comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o status da conta.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxStatus.Focus();
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
                ContaPagar contaPagar = new ContaPagar { 

                };



                // Valida a ContaPagar
                ValidaConta validador = new ValidaConta();
                validador.ValidarConta(contaPagar);

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

