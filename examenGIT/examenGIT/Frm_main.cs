using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenGIT
{
    public partial class Frm_main : Form
    {
        frm_menjar menjar = new frm_menjar();
        frm_sitio sitio = new frm_sitio();  
        public Frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menjar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sitio.Show();
        }
    }
}
