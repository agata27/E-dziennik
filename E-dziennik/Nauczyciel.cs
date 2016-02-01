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
    public partial class Nauczyciel : Form
    {
        string zawartosc = null;

        public Nauczyciel()
        {
            InitializeComponent();
        }

        public Nauczyciel(string login, string rola)
        {
            InitializeComponent();
            zawartosc = login + ", " + rola;
            this.Text += " (Zalogowany jako: " + zawartosc + ")";
        }

        public void przekazrole(string rolapobrana)
        {
            Form.ActiveForm.Text = rolapobrana;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Nauczyciel.ActiveForm.Hide();
            form.Show();
        }

        private void Nauczyciel_Load(object sender, EventArgs e)
        {

        }
    }
}
