﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if(TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(TxtUsuario.Text=="")
            {
                TxtUsuario.Text = "USUARIO";
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text== "CONTRASEÑA")
            {
                TxtContraseña.Text = "";
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "CONTRASEÑA";
            }
        }
    }
}
