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
    public partial class Winicio : Form
    {
        public Winicio()
        {
            InitializeComponent();
        }

        private void cmdWindowsW_Click(object sender, EventArgs e)
        {
            wwindowsm wwindowsm = new wwindowsm();
            wwindowsm.Show();
            this.Hide();
        }

        private void cmdBrowser_Click(object sender, EventArgs e)
        {
            wwebb wwebb = new wwebb();
            wwebb.Show();
            this.Hide();
        }
    }
}