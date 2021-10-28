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
    public partial class FrmPrincipal : Form
    {
        FrmCadastrarHospede formCadHospede = new FrmCadastrarHospede();
        FrmListaHospede formListaHospede = new FrmListaHospede();
        FrmCadastrarFuncionario formCadFunc = new FrmCadastrarFuncionario();
        FrmListaFuncionario formListFunc = new FrmListaFuncionario();
        FrmCadastrarReserva formCadReserva = new FrmCadastrarReserva();
        FrmListaReserva formListReserv = new FrmListaReserva();
        FrmRelatorioAvaliacao formAvaliacao = new FrmRelatorioAvaliacao();
        FrmListaUsuario formUsuario = new FrmListaUsuario();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnListHospede_Click(object sender, EventArgs e)
        {
            
            CloseForms();
            VisibleForm(formListaHospede);
        }

        private void btnCadHospede_Click(object sender, EventArgs e)
        {
            
            CloseForms();
            VisibleForm(formCadHospede);
        }

        private void CloseForms()
        {
            formCadHospede.Visible = false;
            formListaHospede.Visible = false;
            formCadFunc.Visible = false;
            formListFunc.Visible = false;
            formCadReserva.Visible = false;
            formListReserv.Visible = false;
            formAvaliacao.Visible = false;
            formUsuario.Visible = false;
        }

        private void VisibleForm(Form form)
        {
            form.Show();
            form.TopLevel = false;
            pnlCentro.Controls.Add(form);           
            form.Visible = true;
            form.BringToFront();
            form.WindowState = FormWindowState.Maximized;  
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            CloseForms();
            VisibleForm(formCadFunc);
        }

        private void btnListFuncionario_Click(object sender, EventArgs e)
        {
            CloseForms();
            VisibleForm(formListFunc);
        }

        private void btnListReserva_Click(object sender, EventArgs e)
        {
            CloseForms();
            VisibleForm(formListReserv);
        }

        private void btnCadReserva_Click(object sender, EventArgs e)
        {
            CloseForms();
            VisibleForm(formCadReserva);
        }

        private void btnRelatorioAva_Click(object sender, EventArgs e)
        {
            CloseForms();
            VisibleForm(formAvaliacao);
        }

        private void btnListUsuario_Click(object sender, EventArgs e)
        {
            CloseForms();
            VisibleForm(formUsuario);
        }
    }
}
