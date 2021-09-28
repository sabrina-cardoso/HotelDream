using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using System;
using System.Windows.Forms;

namespace HotelDreamDesktop
{

    public partial class FrmListaFuncionario : Form
    {
        FuncionarioDao funcionarioDao = new FuncionarioDao();
        EnderecoDao enderecoDao = new EnderecoDao();

        public FrmListaFuncionario()
        {
            InitializeComponent();
            GridFuncionario();
        }

        private void FrmListaFuncionario_Load(object sender, EventArgs e)
        {
            comboSetor.DisplayMember = "SETOR_DESC";
            comboSetor.ValueMember = "ID";
            comboSetor.DataSource = funcionarioDao.GetSetor();
            comboSetor.SelectedItem = null;

            comboSituacao.DisplayMember = "SITUACAO_DESC";
            comboSituacao.ValueMember = "ID";
            comboSituacao.DataSource = funcionarioDao.GetSituacao();
            comboSituacao.SelectedItem = null;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e) => dgvFuncionario.DataSource = funcionarioDao.GetListFuncionario(txtBusca.Text);

        private void btnAtualizar_Click(object sender, EventArgs e) => dgvFuncionario.DataSource = funcionarioDao.GetListFuncionario();

        private void GridFuncionario()
        {
            dgvFuncionario.DataSource = funcionarioDao.GetListFuncionario();

            dgvFuncionario.Columns["colExcluir"].Width = 30;
            dgvFuncionario.Columns["colExcluir"].DisplayIndex = 5;
            dgvFuncionario.Columns["colEditar"].Width = 30;
            dgvFuncionario.Columns["colEditar"].DisplayIndex = 4;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            EnderecoModel endereco = new EnderecoModel();


            //Set Funcionario

            endereco.Id = int.Parse(txtId.Text);
            endereco.CEP = txtCep.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Rua = txtRua.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;


            enderecoDao.SetEndereco(endereco);
            //popUp.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //popUp.Visible = false;
            tabControl.SelectedIndex = 0;
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvFuncionario.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            if (dgvFuncionario.Columns[e.ColumnIndex] == dgvFuncionario.Columns["colEditar"])
            {
                var funcionario = funcionarioDao.GetFuncionario(id);
                var enderecoHospede = enderecoDao.GetEndereco(id);

                txtId.Text = id;
                txtNome.Text = funcionario.Nome;
                txtCpf.Text = funcionario.CPF;
                txtRg.Text = funcionario.RG;
                dateNasc.Value = funcionario.DataNasc;
                txtTelefone.Text = funcionario.Telefone;
                comboSetor.SelectedValue = funcionario.Setor;
                comboSituacao.SelectedValue = funcionario.Situacao;
                dateAdm.Value = funcionario.DataAdm;
                dateDemi.Value = funcionario.DataDem;
                txtSalario.Text = funcionario.Salario.ToString();

                txtCep.Text = enderecoHospede.CEP;
                txtEstado.Text = enderecoHospede.Estado;
                txtCidade.Text = enderecoHospede.Cidade;
                txtBairro.Text = enderecoHospede.Bairro;
                txtRua.Text = enderecoHospede.Rua;
                txtNumero.Text = enderecoHospede.Numero;
                txtComplemento.Text = enderecoHospede.Complemento;

                GridFuncionario();
                tabControl.SelectedIndex = 1;
            }

            if (dgvFuncionario.Columns[e.ColumnIndex] == dgvFuncionario.Columns["colExcluir"])
            {
                if (MsgCerteza())
                {
                    funcionarioDao.DeleteFuncionario(id);
                    GridFuncionario();
                }
            }
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

    }
}
