using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using System;
using System.Windows.Forms;

namespace HotelDreamDesktop
{
    public partial class FrmListaHospede : Form
    {
        HospedeDao hospedeDao = new HospedeDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        public FrmListaHospede()
        {
            InitializeComponent();
            GridHospede();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e) => dgvHospede.DataSource = hospedeDao.GetListHospede(txtBusca.Text);

        private void btnAtualizar_Click(object sender, EventArgs e) => dgvHospede.DataSource = hospedeDao.GetListHospede();

        private void GridHospede()
        {
            dgvHospede.DataSource = hospedeDao.GetListHospede();

            dgvHospede.Columns["colExcluir"].Width = 30;
            dgvHospede.Columns["colExcluir"].DisplayIndex = 5;
            dgvHospede.Columns["colEditar"].Width = 30;
            dgvHospede.Columns["colEditar"].DisplayIndex = 4;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                HospedeModel hospede = new HospedeModel();
                EnderecoModel endereco = new EnderecoModel();

                hospede.Id = int.Parse(txtId.Text);
                hospede.Nome = txtNome.Text;
                hospede.CPF = txtCpf.Text;
                hospede.RG = txtRg.Text;
                hospede.DataNasc = dateNasc.Value;
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
                MsgSucesso();
            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCpf.Text) || String.IsNullOrEmpty(txtRg.Text) ||
                String.IsNullOrEmpty(txtTelefone.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtCep.Text) ||
                String.IsNullOrEmpty(txtNumero.Text))
            {
                MsgErro("Preencha todos os campos!");
                return false;
            }
            return true;

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
                dateNasc.Value = hospede.DataNasc;
                txtTelefone.Text = hospede.Telefone;
                txtEmail.Text = hospede.Email;

                txtCep.Text = enderecoHospede.CEP;
                txtEstado.Text = enderecoHospede.Estado;
                txtCidade.Text = enderecoHospede.Cidade;
                txtBairro.Text = enderecoHospede.Bairro;
                txtRua.Text = enderecoHospede.Rua;
                txtNumero.Text = enderecoHospede.Numero;
                txtComplemento.Text = enderecoHospede.Complemento;

                GridHospede();
                tabControl.SelectedIndex = 1;
            }

            if (dgvHospede.Columns[e.ColumnIndex] == dgvHospede.Columns["colExcluir"])
            {
                if (MsgCerteza())
                {
                    hospedeDao.DeleteHospede(id);
                    GridHospede();
                }                   
            }
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

        private void MsgErro(string msg)
        {
            string title = "";
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool MsgCerteza()
        {
            string title = "Aviso";
            DialogResult result = MessageBox.Show("Deseja realmente apagar o registro?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {

            HotelDreamLib.Services.Correios buscaCep = new HotelDreamLib.Services.Correios();
            var retorno = buscaCep.BuscarCep(txtCep.Text);

            txtEstado.Text = retorno.Estado;
            txtCidade.Text = retorno.Cidade;
            txtBairro.Text = retorno.Bairro;
            txtRua.Text = retorno.Rua;
        }
    }

}

