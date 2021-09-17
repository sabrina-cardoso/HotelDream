using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using System;
using System.Windows.Forms;
using Correios;

namespace HotelDreamDesktop
{
    public partial class CadastrarFuncionarioForm : Form
    {
        UsuarioModel usuarioModel = new UsuarioModel();
        FuncionarioModel funcionarioModel = new FuncionarioModel();
        EnderecoModel enderecoModel = new EnderecoModel();

        UsuarioDao usuarioDao = new UsuarioDao();
        FuncionarioDao funcionarioDao = new FuncionarioDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        private void CadastrarFuncionarioForm_Load(object sender, EventArgs e)
        {
            comboSetor.DisplayMember = "SETOR_DESC";
            comboSetor.ValueMember = "ID";
            comboSetor.DataSource = funcionarioDao.GetSetor();
            comboSetor.SelectedItem = null;

            comboSituacao.DisplayMember = "SITUACAO_DESC";
            comboSituacao.ValueMember = "ID";
            comboSituacao.DataSource = funcionarioDao.GetSituacao();
            comboSituacao.SelectedItem = null;

        }


        public CadastrarFuncionarioForm()
        {
            InitializeComponent();
            lblSenhaErro.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtConfSenha.Text == txtSenha.Text)
            {
                usuarioModel.Nivel = 2;
                usuarioModel.Usuario = txtUsuario.Text;
                usuarioModel.Senha = txtSenha.Text;
                usuarioDao.SetUsuario(usuarioModel);

                funcionarioModel.Id = int.Parse(usuarioDao.GetIdUsuario(usuarioModel.Usuario));
                funcionarioModel.Nome = txtNome.Text;
                funcionarioModel.CPF = txtCpf.Text;
                funcionarioModel.RG = txtRg.Text;
                funcionarioModel.DataNasc = dateNasc.Value;
                funcionarioModel.Telefone = txtTelefone.Text;
                funcionarioModel.Setor = int.Parse(comboSetor.SelectedValue.ToString());
                funcionarioModel.Situacao = int.Parse(comboSituacao.SelectedValue.ToString());
                funcionarioModel.DataAdm = dateAdm.Value;
                funcionarioModel.Salario = Convert.ToDouble(txtSalario.Text);

                funcionarioDao.SetFuncionario(funcionarioModel);

                enderecoModel.Id = int.Parse(usuarioDao.GetIdUsuario(usuarioModel.Usuario));
                enderecoModel.CEP = txtCep.Text;
                enderecoModel.Estado = txtEstado.Text;
                enderecoModel.Cidade = txtCidade.Text;
                enderecoModel.Bairro = txtBairro.Text;
                enderecoModel.Rua = txtRua.Text;
                enderecoModel.Numero = txtNumero.Text;
                enderecoModel.Complemento = txtComplemento.Text;
                enderecoDao.SetEndereco(enderecoModel);

                popUp.Visible = true;
            }
            else
            {
                lblSenhaErro.Visible = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popUp.Visible = false;
            this.Visible = false;
        }

        private void BuscarCep(string cep)
        {
            CorreiosApi correios = new CorreiosApi();
            var retorno = correios.consultaCEP(cep);

            txtEstado.Text = retorno.uf;
            txtCidade.Text = retorno.cidade;
            txtBairro.Text = retorno.bairro;
            txtRua.Text = retorno.end;

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            BuscarCep(txtCep.Text);
        }
    }
}
