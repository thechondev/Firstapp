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
    public partial class wwebb : Form
    {
        public wwebb()
        {
            InitializeComponent();
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmdbuscar_Click(object sender, EventArgs e)
        {
            webbrowser.Navigate(txtsearch.Text);
        }
    }
}
