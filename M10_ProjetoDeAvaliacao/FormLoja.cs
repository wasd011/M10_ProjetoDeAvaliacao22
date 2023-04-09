using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_ProjetoDeAvaliacao
{
    public partial class FormLoja : Form
    {
        public FormLoja()
        {
            InitializeComponent();
        }

        private void FormLoja_Load(object sender, EventArgs e)
        {

        }

        private void FormLoja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }
    }
}
