using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

             //Adiministração
        private void adminstraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Administração";
        }

        private void usuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Atualiza o texto do lblStatus para mostrar o caminho do menu
            lblStatus.Text = "Administração > Usuários";

            // Código para abrir o formulário de Usuários
            //FormUsuarios formUsuarios = new FormUsuarios();
            //formUsuarios.Show();

        }
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Administração > Configurações";
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Administração > Relatórios";
        }

             //Vendas
        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Vendas";
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblStatus.Text = "Vendas > Pedidos";

            // Código para abrir o formulário de Pedidos
            //FormPedidos formPedidos = new FormPedidos();
            //formPedidos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Vendas > Clientes";
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Vendas > Estoque";
        }
            //Financeiro 
        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Financeiro";
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            lblStatus.Text = "Financeiro > Contas a Pagar";

            // Abre a tela de Contas a Pagar de forma modal
            FormContasAPagar formCPag = new FormContasAPagar();
            formCPag.ShowDialog();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            lblStatus.Text = "Financeiro > Contas a Receber";

            // Abre a tela de Contas a Receber de forma modal
            FormContasAReceber formCRec = new FormContasAReceber();
            formCRec.ShowDialog();
        }

        private void relatóriosFinanceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Financeiro > Contas a Receber";
        }

       
    }
}
