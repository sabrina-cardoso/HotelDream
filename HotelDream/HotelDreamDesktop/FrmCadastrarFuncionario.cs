using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using System;
using System.Windows.Forms;
using Correios;
using HotelDreamLib.Services;

namespace HotelDreamDesktop
{
    public partial class FrmCadastrarFuncionario : Form
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

            comboStatus.DisplayMember = "STATUS_DESC";
            comboStatus.ValueMember = "ID";
            comboStatus.DataSource = usuarioDao.GetStatus();
            comboStatus.SelectedItem = null;

        }

        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
            lblSenhaErro.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                usuarioModel.Nivel = 2;
                usuarioModel.Usuario = txtUsuario.Text;
                usuarioModel.Senha = txtSenha.Text;
                usuarioModel.Status = int.Parse(comboStatus.SelectedValue.ToString());
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

                MsgSucesso();
                LimparCampos();
            }
            else
            {
                lblSenhaErro.Visible = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //popUp.Visible = false;
            this.Visible = false;
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                HotelDreamLib.Services.Correios buscaCep = new HotelDreamLib.Services.Correios();
                var retorno = buscaCep.BuscarCep(txtCep.Text);

                txtEstado.Text = retorno.Estado;
                txtCidade.Text = retorno.Cidade;
                txtBairro.Text = retorno.Bairro;
                txtRua.Text = retorno.Rua;
            }
            catch (Exception ex)
            {
                MsgErro(ex.Message);
            }

        }

        private void MsgSucesso()
        {

            string msg = "Cadastro realizado com sucesso!";
            string title = "";
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.None);

            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void MsgErro(string msg)
        {
            string title = "";
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCpf.Text) || String.IsNullOrEmpty(txtRg.Text) ||
                String.IsNullOrEmpty(dateNasc.Value.ToString()) || String.IsNullOrEmpty(dateNasc.Value.ToString()) ||
                String.IsNullOrEmpty(txtTelefone.Text) || String.IsNullOrEmpty(comboSetor.SelectedValue.ToString()) ||
                String.IsNullOrEmpty(comboSituacao.SelectedValue.ToString()) || String.IsNullOrEmpty(dateAdm.Value.ToString()) || 
                String.IsNullOrEmpty(txtCep.Text) || String.IsNullOrEmpty(txtNumero.Text) || String.IsNullOrEmpty(txtUsuario.Text) || 
                String.IsNullOrEmpty(txtSenha.Text))
            {
                MsgErro("Preencha todos os campos!");
                return false;
            }
            else
            {
                if (txtSenha.Text != txtConfSenha.Text)
                {
                    MsgErro("Senha não coincidem!");
                    lblSenhaErro.Visible = true;
                    return false;
                }
                else
                {
                    lblSenhaErro.Visible = false;
                    return true;
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtTelefone.Text = "";
            comboSetor.Text = "";
            comboSituacao.Text = "";
            txtSalario.Text = "";

            txtCep.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";

            txtUsuario.Text = "";
            comboStatus.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";

        }
    }
}
