using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_dziennik
{
    public partial class Form1 : Form
    {
        string rolapobrana = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string haslopobrane = null;
            OleDbConnection polaczenie = new OleDbConnection();
            polaczenie.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Agata\\Desktop\\baza.accdb;Persist Security Info=False;";
            OleDbCommand zapytanie = new OleDbCommand();
            OleDbCommand zapytanie1 = new OleDbCommand();
            zapytanie.Connection = polaczenie;
            zapytanie1.Connection = polaczenie;
            zapytanie.CommandText = "SELECT haslo FROM Tabela1 WHERE (login = @login)";
            zapytanie1.CommandText = "SELECT rola FROM Tabela1 WHERE (login = @login)";
            zapytanie.Parameters.AddWithValue("@login", textBox1.Text);
            zapytanie1.Parameters.AddWithValue("@login", textBox1.Text);


            try
            {
                polaczenie.Open();
                OleDbDataReader reader = zapytanie.ExecuteReader();
                while (reader.Read())
                {
                    haslopobrane = reader.GetString(0);
                }

                OleDbDataReader reader1 = zapytanie1.ExecuteReader();
                while (reader1.Read())
                {
                    rolapobrana = reader1.GetString(0);
                }


                if (rolapobrana == "A")
                {
                    Form1.ActiveForm.Hide();
                    Admin admin = new Admin(textBox1.Text, rolapobrana);
                    admin.Show();
                }

                else if(rolapobrana == "N")
                {
                    Form1.ActiveForm.Hide();
                    Nauczyciel nauczyciel = new Nauczyciel(textBox1.Text, rolapobrana);
                    nauczyciel.Show();
                }

                else if(rolapobrana == "U")
                {
                    Form1.ActiveForm.Hide();
                    Uczen uczen = new Uczen(textBox1.Text, rolapobrana);
                    uczen.Show();
                }
                
                reader.Close();
                polaczenie.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Nie powiodło się!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
