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
    public partial class FrmCadastrarReserva : Form
    {
        QuartoDao quartoDao = new QuartoDao();
        public FrmCadastrarReserva()
        {
            InitializeComponent();
        }

        private void FrmCadastrarReserva_Load(object sender, EventArgs e)
        {

        }

        private void GridQuartos()
        {
            dgvQuarto.DataSource = quartoDao.GetListQuarto();

            dgvQuarto.Columns["colReservar"].Width = 30;
            dgvQuarto.Columns["colReservar"].DisplayIndex = 5;
        }
    }
}
