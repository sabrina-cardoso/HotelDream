using HotelDreamLib.Dao;
using HotelDreamLib.Model;
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
        HospedeDao hospedeDao = new HospedeDao();
        ReservaDao ReservaDao = new ReservaDao();

        HospedeModel hospede = new HospedeModel();
        QuartoModel quarto = new QuartoModel();

        

        public FrmCadastrarReserva()
        {
            InitializeComponent();
        }

        private void FrmCadastrarReserva_Load(object sender, EventArgs e)
        {
            //GridQuartos(dateEntrada.Value, dateSaida.Value);
            GridHospede();

            comboPagamento.DisplayMember = "PAGAMENTO_DESC";
            comboPagamento.ValueMember = "ID";
            comboPagamento.DataSource = ReservaDao.GetTipoPagamento();
            comboPagamento.SelectedItem = null;
        }

        private void GridQuartos(DateTime dataEntrada, DateTime dataSaida)
        {
            dgvQuarto.DataSource = quartoDao.GetListQuartoReserva(dataEntrada, dataSaida);

            dgvQuarto.Columns["colReservar"].Width = 30;
            dgvQuarto.Columns["colReservar"].DisplayIndex = 2;
        }

        private void GridHospede()
        {
            dgvHospede.DataSource = hospedeDao.GetListHospede();

            dgvHospede.Columns["colReservHospede"].Width = 30;
            dgvHospede.Columns["colReservHospede"].DisplayIndex = 2;
        }

        private void btnBuscarHospede_Click(object sender, EventArgs e) => dgvHospede.DataSource = hospedeDao.GetListHospede(txtBusca.Text);

        private void btnBuscarQuartos_Click(object sender, EventArgs e) => GridQuartos(dateEntrada.Value, dateSaida.Value);

        private void dgvQuarto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            quarto = quartoDao.GetQuarto(dgvHospede.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            txtQuarto.Text = quarto.Id.ToString();
            txtTipoQuarto.Text = quarto.TipoQuarto.Nome;
            dateEntradaReserv.Value = dateEntrada.Value;
            dateSaidaReserv.Value = dateSaida.Value;

            tabControl.SelectedIndex = 2;

        }

        private void dgvHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hospede = hospedeDao.GetHospede(dgvHospede.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            txtHospede.Text = hospede.Nome;

            tabControl.SelectedIndex = 3;
        }

        private void btnConfReserva_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

            }
        }

        private bool ValidarCampos()
        {
            return true;
        }
    }
}
