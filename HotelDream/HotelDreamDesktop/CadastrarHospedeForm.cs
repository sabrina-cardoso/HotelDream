using System;
using System.Windows.Forms;
using HotelDreamLib.Dao;
using HotelDreamLib.Model;

namespace HotelDreamDesktop
{
    public partial class CadastrarHospedeForm : Form
    {
        UsuarioModel usuarioModel = new UsuarioModel();
        HospedeModel hospedeModel = new HospedeModel();
        EnderecoModel enderecoModel = new EnderecoModel();

        UsuarioDao usuarioDao = new UsuarioDao();
        HospedeDao hospedeDao = new HospedeDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        public CadastrarHospedeForm()
        {
            InitializeComponent();
        }

        private void CadastrarHospedeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usuarioModel.Nivel = 3;
            usuarioModel.Usuario = txtUsuario.Text;
            usuarioModel.Senha = txtSenha.Text;
            usuarioDao.SetUsuario(usuarioModel);

            hospedeModel.Id = int.Parse(usuarioDao.GetIdUsuario(usuarioModel.Usuario));
            hospedeModel.Nome = txtNome.Text;
            hospedeModel.CPF = txtCpf.Text;
            hospedeModel.RG = txtRg.Text;
            hospedeModel.DataNasc = txtDataNasc.Text;
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

            popUp.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popUp.Visible = false;
            this.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
