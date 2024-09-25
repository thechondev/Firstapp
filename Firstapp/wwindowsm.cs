using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstapp
{
    public partial class wwindowsm : Form
    {
        private string lruta = "";
        public wwindowsm()
        {
            InitializeComponent();
        }


        private void cmdcargar_Click(object sender, EventArgs e)
        {
            if(ofdcargador.ShowDialog() == DialogResult.OK)
            {
                lruta = ofdcargador.FileName;
                lblruta.Text = lruta;
            }
        }

        private void cmdpause_Click(object sender, EventArgs e)
        {
            reproductorwmp.Ctlcontrols.pause();
        }

        private void cmdstop_Click(object sender, EventArgs e)
        {
            reproductorwmp.Ctlcontrols.stop();
        }

        private void cmdstart_Click(object sender, EventArgs e)
        {
            reproductorwmp.URL = lruta;
            reproductorwmp.Ctlcontrols.play();
        }
    }
}
