using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using System;
using System.Windows.Forms;

namespace HotelDreamDesktop
{
    
    public partial class ListaFuncionario : Form
    {
        FuncionarioDao funcionarioDao = new FuncionarioDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        public ListaFuncionario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e) => dgvFuncionario.DataSource = funcionarioDao.GetListFuncionario(txtBusca.Text);

        private void btnAtualizar_Click(object sender, EventArgs e) => dgvFuncionario.DataSource = funcionarioDao.GetListFuncionario();

        private void GridFuncionario()
        {
            dgvFuncionario.DataSource = funcionarioDao.GetListFuncionario();

            dgvFuncionario.Columns["colExcluir"].Width = 40;
            dgvFuncionario.Columns["colExcluir"].DisplayIndex = 5;
            dgvFuncionario.Columns["colEditar"].Width = 50;
            dgvFuncionario.Columns["colEditar"].DisplayIndex = 4;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            EnderecoModel endereco = new EnderecoModel();


            //Set Funcionario

            endereco.Id = int.Parse(txtId.Text);
            endereco.CEP = txtCep.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Rua = txtRua.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;

           
            enderecoDao.SetEndereco(endereco);
            popUp.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popUp.Visible = false;
            tabControl.SelectedIndex = 0;
        }


    }
}
