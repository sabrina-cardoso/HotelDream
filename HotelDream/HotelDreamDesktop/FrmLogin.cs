using System;
using System.Windows.Forms;
using HotelDreamLib.Model;
using HotelDreamLib.Dao;

namespace HotelDreamDesktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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
                FrmPrincipal formPrincipal = new FrmPrincipal();

                formPrincipal.Show();
            }
            else
            {
                lblErro.Visible = true;
            }
        }
    }
}
