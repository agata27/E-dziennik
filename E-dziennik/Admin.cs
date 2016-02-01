using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_dziennik
{
    public partial class Admin : Form
    {
        string zawartosc = null;

        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string login, string rola)
        {
            InitializeComponent();
            zawartosc = login + ", " + rola;
            this.Text += " (Zalogowany jako: " + zawartosc + ")";
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Admin.ActiveForm.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
