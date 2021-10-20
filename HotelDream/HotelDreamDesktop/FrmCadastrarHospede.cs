using System;
using System.Windows.Forms;
using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using HotelDreamLib.Services;

namespace HotelDreamDesktop
{
    public partial class FrmCadastrarHospede : Form
    {
        UsuarioModel usuarioModel = new UsuarioModel();
        HospedeModel hospedeModel = new HospedeModel();
        EnderecoModel enderecoModel = new EnderecoModel();

        UsuarioDao usuarioDao = new UsuarioDao();
        HospedeDao hospedeDao = new HospedeDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        public FrmCadastrarHospede()
        {
            InitializeComponent();
            lblSenhaErro.Visible = false;
        }

        private void FrmCadastrarHospede_Load(object sender, EventArgs e)
        {
            comboStatus.DisplayMember = "STATUS_DESC";
            comboStatus.ValueMember = "ID";
            comboStatus.DataSource = usuarioDao.GetStatus();
            comboStatus.SelectedItem = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) {
                usuarioModel.Nivel = 3;
                usuarioModel.Usuario = txtUsuario.Text;
                usuarioModel.Senha = txtSenha.Text;
                usuarioModel.Status = int.Parse(comboStatus.SelectedValue.ToString());
                usuarioDao.SetUsuario(usuarioModel);

                hospedeModel.Id = int.Parse(usuarioDao.GetIdUsuario(usuarioModel.Usuario));
                hospedeModel.Nome = txtNome.Text;
                hospedeModel.CPF = txtCpf.Text;
                hospedeModel.RG = txtRg.Text;
                hospedeModel.DataNasc = dateNasc.Value;
                hospedeModel.Telefone = txtTelefone.Text;
                hospedeModel.Email = txtEmail.Text;
                hospedeDao.SetHospede(hospedeModel);

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

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCpf.Text) || String.IsNullOrEmpty(txtRg.Text) || 
                String.IsNullOrEmpty(txtTelefone.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtCep.Text) ||
                String.IsNullOrEmpty(txtNumero.Text) || String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                MsgErro("Preencha todos os campos!");
                return false;
            }
            else
            {
                if (txtSenha.Text != txtConfSenha.Text)
                {
                    MsgErro("Senhas não coincidem!");
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
            txtEmail.Text = "";
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
    }
}
