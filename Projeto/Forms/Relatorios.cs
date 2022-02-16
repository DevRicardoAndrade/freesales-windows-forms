using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Relatorios : Form
    {
        public Principal frmChamador;
        public Relatorios(Principal frmChamador)
        {
            this.frmChamador = frmChamador;
            InitializeComponent();
        }



        private void Relatorios_Load(object sender, EventArgs e)
        {
            frmChamador.relatoriosAtivo = true;

        }

        private void Relatorios_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChamador.relatoriosAtivo = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

