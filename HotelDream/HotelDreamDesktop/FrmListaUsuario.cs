using HotelDreamLib.Dao;
using System;
using System.Windows.Forms;

namespace HotelDreamDesktop
{
    public partial class FrmListaUsuario : Form
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        public FrmListaUsuario()
        {
            InitializeComponent();
            GridFuncionario();

            comboStatus.DisplayMember = "STATUS_DESC";
            comboStatus.ValueMember = "ID";
            comboStatus.DataSource = usuarioDao.GetStatus();
            comboStatus.SelectedItem = null;
        }

        private void GridFuncionario()
        {
            dgvUsuario.DataSource = usuarioDao.GetListUsuario();

            dgvUsuario.Columns["colEditar"].Width = 30;
            dgvUsuario.Columns["colEditar"].DisplayIndex = 4;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = usuarioDao.GetListUsuario(txtBusca.Text);
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvUsuario.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            if (dgvUsuario.Columns[e.ColumnIndex] == dgvUsuario.Columns["colEditar"])
            {
                var usuario = usuarioDao.GetUsuario(id);

                txtId.Text = id;
                txtUsuario.Text = usuario.Usuario.ToString();
                comboStatus.SelectedValue = usuario.Status;

                tabControl.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = usuarioDao.GetUsuario(txtId.Text);
            usuario.Status = Convert.ToInt32(comboStatus.SelectedValue);
            usuarioDao.SetUsuario(usuario);
            MsgSucesso();
        }

        private void MsgSucesso()
        {

            string msg = "Cadastro atualizado com sucesso!";
            string title = "";
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.None);

            if (result == DialogResult.OK)
            {
                tabControl.SelectedIndex = 0;
            }
        }
    }
}
