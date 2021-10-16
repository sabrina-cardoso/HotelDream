using HotelDreamLib.Business;
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
        ReservaDao reservaDao = new ReservaDao();
        AcompanhanteDao acompanhanteDao = new AcompanhanteDao();

        HospedeModel hospede = new HospedeModel();
        QuartoModel quarto = new QuartoModel();
        ReservaModel reserva = new ReservaModel();
        AcompanhanteModel acompanhante = new AcompanhanteModel();

        ReservaBusiness reservaBusiness = new ReservaBusiness();

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
            comboPagamento.DataSource = reservaDao.GetTipoPagamento();
            comboPagamento.SelectedItem = null;
        }

        private void GridQuartos(DateTime dataEntrada, DateTime dataSaida)
        {
            dgvQuarto.DataSource = quartoDao.GetListQuartoReserva(dataEntrada, dataSaida);

            dgvQuarto.Columns["colReservQuarto"].Width = 30;
            dgvQuarto.Columns["colReservQuarto"].DisplayIndex = 2;
        }

        private void GridHospede()
        {
            dgvHospede.DataSource = hospedeDao.GetListHospede();

            dgvHospede.Columns["colReservHospede"].Width = 30;
            dgvHospede.Columns["colReservHospede"].DisplayIndex = 4;
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

            reserva.Quarto = quarto;
            reserva.DtEntrada = dateEntradaReserv.Value;
            reserva.DtSaida = dateSaidaReserv.Value;

            tabControl.SelectedIndex = 1;
        }

        private void dgvHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hospede = hospedeDao.GetHospede(dgvHospede.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            txtHospede.Text = hospede.Nome;

            reserva.Hospede = hospede;

            tabControl.SelectedIndex = 2;
        }

        private void btnConfReserva_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                reserva.Total = reservaBusiness.CalcularReserva(reserva);
                reserva.TipoPagamento = int.Parse(comboPagamento.SelectedValue.ToString());
                reservaDao.SetReserva(reserva);

                if (reserva.QtdAcompanhante > 0)
                {
                    tabControl.SelectedIndex = 3;            
                }
                else{
                    MsgSucesso("Reserva Realizada com sucesso!");
                    LimparCampos();
                }
            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtQuarto.Text) || String.IsNullOrEmpty(txtHospede.Text) || String.IsNullOrEmpty(txtTipoQuarto.Text) ||
               String.IsNullOrEmpty(numAcompanhante.Text) || String.IsNullOrEmpty(comboPagamento.Text))
            {
                MsgErro("Preencha todos os campos!");
                return false;
            }
            return true;

        }

        private void numAcompanhante_Leave(object sender, EventArgs e)
        {
            if (int.Parse(numAcompanhante.Text) <= reserva.Quarto.TipoQuarto.QtdHospede)
            {
                reserva.QtdAcompanhante = int.Parse(numAcompanhante.Text);
                lblTotal.Text = "R$ " + reservaBusiness.CalcularReserva(reserva).ToString("F");
            }
            else
            {
                MsgErro("Número de acompanhantes é maior do que o permitido de acordo com o quarto. Escolha outro quarto ou altere o número de acompanhantes.");
            }
        }

        private void btnAddAcomp_Click(object sender, EventArgs e)
        {
            acompanhante.Nome = txtNomeAcomp.Text;
            acompanhante.CPF = txtCpfAcomp.Text;
            acompanhante.Reserva = reserva;

            acompanhanteDao.SetAcompanhante(acompanhante);

            dgvAcompanhante.DataSource = acompanhanteDao.GetListAcompanhante(reserva);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MsgSucesso("Reserva realizada com sucesso!");
            tabControl.SelectedIndex = 0;
            LimparCampos();
        }

        private void MsgErro(string msg)
        {
            DialogResult result = MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MsgSucesso(string msg)
        {
            DialogResult result = MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK)
            {
                this.Hide();               
            }
        }

        private void LimparCampos()
        {
            txtQuarto.Text = "";
            txtTipoQuarto.Text = "";
            txtHospede.Text = "";
            numAcompanhante.Value = 0;
            comboPagamento.Text = "";
            lblTotal.Text = "";
            txtNomeAcomp.Text = "";
            txtCpfAcomp.Text = "";

            DataTable dt = new DataTable();
            dgvAcompanhante.DataSource = dt;

        }
    }
}
