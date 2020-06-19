
using ProjetoMVCC18.BLL;
using ProjetoMVCC18.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVCC18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando o DTO do cliente para armazenar os dados da tela
                tbl_clienteC18DTO cliente = new tbl_clienteC18DTO();
                cliente.Cpf_cliente = txtCpfC18.Text.Trim();
                cliente.Nome_cliente = txtNomeC18.Text.Trim();
                cliente.Nome_mae = txtNomeMaeC18.Text.Trim();
                Double Cpf = double.Parse(txtCpfC18.Text);

                // Instanciando a BLL para pesquisa do email e senha do cliente no banco
                tbl_clienteC18BLL bllCliente = new tbl_clienteC18BLL();
                if (bllCliente.consultarBeneficio(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_mae))
                {
                    MessageBox.Show("Beneficiário Localizado no Banco de dados.Processo em Análise", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Beneficiário Não Localizado no Banco de dados.Benefício Negado", "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
