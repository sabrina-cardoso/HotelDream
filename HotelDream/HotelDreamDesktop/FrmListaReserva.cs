using HotelDreamLib.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDreamDesktop
{
    public partial class FrmListaReserva : Form
    {
        ReservaDao reservaDao = new ReservaDao();

        public FrmListaReserva()
        {
            InitializeComponent();
            GridReserva();
        }

        private void GridReserva(string busca = "")
        {
            dgvReserva.DataSource = reservaDao.GetListReserva(busca);

            dgvReserva.Columns["colCheckIn"].Width = 30;
            dgvReserva.Columns["colCheckIn"].DisplayIndex =7;
            dgvReserva.Columns["colCheckOut"].Width = 30;
            dgvReserva.Columns["colCheckOut"].DisplayIndex = 7;
        }

        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvReserva.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            if (dgvReserva.Columns[e.ColumnIndex] == dgvReserva.Columns["colCheckIn"])
            {
                reservaDao.CheckIn(id);
                MsgSucesso("Check-in realizado com sucesso!");


            }

            if (dgvReserva.Columns[e.ColumnIndex] == dgvReserva.Columns["colCheckOut"])
            {
                reservaDao.CheckOut(id);
                MsgSucesso("Check-Out realizado com sucesso!");
            }
        }

        private void MsgSucesso(string msg)
        {
            DialogResult result = MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
