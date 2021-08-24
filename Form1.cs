using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var sqliteConnection = new SQLiteConnection("Data Source=c:\\users\\marcelo\\source\\repos\\windowsformscadastro\\bancodedados.db;");
            sqliteConnection.Open();
           var comando = sqliteConnection.CreateCommand();
            comando.CommandText =
            $"INSERT INTO Clientes(Nome, Idade, Email, Telefone, Objetivo) values('{textNome.Text}', '{textIdade.Text}', '{textEmail.Text}', '{textFone.Text}', '{textObjetivo.Text}')";
            comando.ExecuteNonQuery();
            LimpaCadastro(this.Controls);
        }
        private void LimpaCadastro(Control.ControlCollection controle)
        {
            foreach (Control ctrl in controle)
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
