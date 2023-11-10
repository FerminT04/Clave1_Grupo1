using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave1_Grupo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "CONTRASEÑA")
            {
                TxtContraseña.Text = "";
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            

            String Usuario, Contraseña;
            Usuario = TxtUsuario.Text;
            Contraseña = TxtContraseña.Text;
            MySqlConnection con = new MySqlConnection("Server = localhost;Database = clave1_grupo1db;User Id=root; Password = root");
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR" + ex.ToString());
                throw;
            }
            String sql = "select user, pass from users where user = " + Usuario + "And pass =" + Contraseña + "";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrectos" + Usuario);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }
    }
}
