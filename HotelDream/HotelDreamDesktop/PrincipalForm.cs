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
    public partial class PrincipalForm : Form
    {
        CadastrarHospedeForm formCadHospede = new CadastrarHospedeForm();
        ListaHospedeForm formListaHospede = new ListaHospedeForm();

        public PrincipalForm()
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
    }
}
