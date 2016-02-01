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
    public partial class Uczen : Form
    {
        string zawartosc = null;

        public Uczen()
        {
            InitializeComponent();
        }

        public Uczen(string login, string rola)
        {
            InitializeComponent();
            zawartosc = login + ", " + rola;
            this.Text += " (Zalogowany jako: " + zawartosc + ")";
        }

        private void Uczen_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Uczen.ActiveForm.Hide();
            form.Show();
        }
    }
}
