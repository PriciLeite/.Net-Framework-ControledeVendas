using Projeto_Controle_de_Vendas.br.com.projeto.dao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }




        #region Cadastrar - btnSalvar:
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // 1) Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();


            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.cep = txtcep.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtestado.Text;

            // 2) Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            // atualizar o DataGredView
            tabelacliente.DataSource = dao.listarCliente();



        }
        #endregion


        #region Excluir - btnExcluir:

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            // pegar o código:            
            obj.cpf = txtcpf.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(obj);

            // atualizar o DataGredView
            tabelacliente.DataSource = dao.listarCliente();
        }
        #endregion


        #region Editar - btnEditar:

        private void Btneditar_Click(object sender, EventArgs e)
        {


            // 1) Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();


            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.cep = txtcep.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtestado.Text;
            obj.codigo = txtcodigo.Text;

            // 2) Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente

            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);

            // atualizar o DataGredView
            tabelacliente.DataSource = dao.listarCliente();

        }
        #endregion


        #region Novo - btnnovo
        private void btnnovo_Click(object sender, EventArgs e)
        {
            // 1) Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();


            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.cep = txtcep.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtestado.Text;

            // 2) Criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            // atualizar o DataGredView
            tabelacliente.DataSource = dao.listarCliente();


        }
        #endregion


        #region listarClientes no DataGredy

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            tabelacliente.DefaultCellStyle.ForeColor = Color.Black;
            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.listarCliente();
        }
        #endregion


        #region CellClick Retorno para alteração dos dados
        private void tabelacliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar os dados da tabelacliente
            txtcodigo.Text = tabelacliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelacliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelacliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelacliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelacliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelacliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelacliente.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelacliente.CurrentRow.Cells[7].Value.ToString();
            txtcep.Text = tabelacliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelacliente.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = tabelacliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelacliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelacliente.CurrentRow.Cells[12].Value.ToString();
            txtestado.Text = tabelacliente.CurrentRow.Cells[13].Value.ToString();

            // Retornando para aba cadastro cliente;
            tabclientes.SelectedTab = tabPage1;


        }
        #endregion


        #region Pesquisar - btnpesquisar:

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.BuscarClientePorNome(nome);

            
        }
        #endregion

    }
}
 