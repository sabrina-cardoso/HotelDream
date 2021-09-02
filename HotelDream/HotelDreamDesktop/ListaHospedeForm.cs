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
    public partial class ListaHospedeForm : Form
    {
        HospedeDao hospedeDao = new HospedeDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        public ListaHospedeForm()
        {
            InitializeComponent();
            GridHospede();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e) => dgvHospede.DataSource = hospedeDao.GetListHospede(txtBusca.Text);

        private void btnAtualizar_Click(object sender, EventArgs e) => dgvHospede.DataSource = hospedeDao.GetListHospede();

        private void GridHospede()
        {
            dgvHospede.DataSource = hospedeDao.GetListHospede();

            dgvHospede.Columns["colExcluir"].Width = 40;
            dgvHospede.Columns["colExcluir"].DisplayIndex = 5;
            dgvHospede.Columns["colEditar"].Width = 50;
            dgvHospede.Columns["colEditar"].DisplayIndex = 4;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            HospedeModel hospede = new HospedeModel();
            EnderecoModel endereco = new EnderecoModel();

            hospede.Id = int.Parse(txtId.Text);
            hospede.Nome = txtNome.Text;
            hospede.CPF = txtCpf.Text;
            hospede.RG = txtRg.Text;
            hospede.DataNasc = txtDataNasc.Text;
            hospede.Telefone = txtTelefone.Text;
            hospede.Email = txtEmail.Text;

            endereco.Id = int.Parse(txtId.Text);
            endereco.CEP = txtCep.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Rua = txtRua.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;

            hospedeDao.SetHospede(hospede);
            enderecoDao.SetEndereco(endereco);
            popUp.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popUp.Visible = false;
            tabControl.SelectedIndex = 0;
        }

        private void dgvHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvHospede.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            if (dgvHospede.Columns[e.ColumnIndex] == dgvHospede.Columns["colEditar"])
            {
                var hospede = hospedeDao.GetHospede(id);
                var enderecoHospede = enderecoDao.GetEndereco(id);

                txtId.Text = id;
                txtNome.Text = hospede.Nome;
                txtCpf.Text = hospede.CPF;
                txtRg.Text = hospede.RG;
                txtDataNasc.Text = hospede.DataNasc;
                txtTelefone.Text = hospede.Telefone;
                txtEmail.Text = hospede.Email;

                txtCep.Text = enderecoHospede.CEP;
                txtEstado.Text = enderecoHospede.Estado;
                txtCidade.Text = enderecoHospede.Cidade;
                txtBairro.Text = enderecoHospede.Bairro;
                txtRua.Text = enderecoHospede.Rua;
                txtNumero.Text = enderecoHospede.Numero;
                txtComplemento.Text = enderecoHospede.Complemento;

                tabControl.SelectedIndex = 1;

            }
        }

        
    }
}
