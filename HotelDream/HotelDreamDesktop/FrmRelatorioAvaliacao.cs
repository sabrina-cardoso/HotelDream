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
    public partial class FrmRelatorioAvaliacao : Form
    {
        AvaliacaoDao avaliacaoDao = new AvaliacaoDao();

        public FrmRelatorioAvaliacao()
        {
            InitializeComponent();
            GridAvaliacoes();
        }

        private void GridAvaliacoes(string busca = "")
        {
            dgvAvaliacoes.DataSource = avaliacaoDao.GetListAvaliacao(busca);
        }
    }
}
