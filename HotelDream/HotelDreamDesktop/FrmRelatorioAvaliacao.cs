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
            GetEstatisticas();
        }

        private void GridAvaliacoes(string busca = "")
        {
            dgvAvaliacoes.DataSource = avaliacaoDao.GetListAvaliacao(busca);
        }

        private void GetEstatisticas()
        {
            var notas = avaliacaoDao.GetNotaEstatistica();

            lblAtendRuim.Text = notas.NotaAtendimentoRuim.ToString("F") + " %";
            lblAtendReg.Text = notas.NotaAtendimentoRegular.ToString("F") + " %";
            lblAtendBom.Text = notas.NotaAtendimentoBom.ToString("F") + " %";
            lblAtendOtimo.Text = notas.NotaAtendimentoOtimo.ToString("F") + " %";
            lblAtendMedia.Text = notas.NotaAtendimentoMedia.ToString();

            lblAcomRuim.Text = notas.NotaAcomodacaoRuim.ToString("F") + " %";
            lblAcomReg.Text = notas.NotaAcomodacaoRegular.ToString("F") + " %";
            lblAcomBom.Text = notas.NotaAcomodacaoBom.ToString("F") + " %";
            lblAcomOtimo.Text = notas.NotaAcomodacaoOtimo.ToString("F") + " %";
            lblAcomMedia.Text = notas.NotaAcomodacaoMedia.ToString();

            lblRecoRuim.Text = notas.NotaRecomendacaoRuim.ToString("F") + " %";
            lblRecoReg.Text = notas.NotaRecomendacaoRegular.ToString("F") + " %";
            lblRecoBom.Text = notas.NotaRecomendacaoBom.ToString("F") + " %";
            lblRecoOtimo.Text = notas.NotaRecomendacaoOtimo.ToString("F") + " %";
            lblRecoMedia.Text = notas.NotaRecomendacaoMedia.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GridAvaliacoes(txtBusca.Text);
        }
    }
}
