using System;
using System.Windows.Forms;
using HotelDreamLib.Model;
using HotelDreamLib.Dao;

namespace HotelDreamDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblErro.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginModel login = new LoginModel();
            LoginDao loginDao = new LoginDao();
            

            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            if (loginDao.GetLogin(login))
            {
                this.Hide();
                PrincipalForm formPrincipal = new PrincipalForm();

                formPrincipal.Show();
            }
            else
            {
                lblErro.Visible = true;
            }
        }
    }
}
