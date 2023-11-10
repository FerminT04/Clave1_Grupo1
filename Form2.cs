using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
            
        }
        bool val = false;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void subMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subMenu.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subMenu.Visible = false;


        }

        private void BtnLocales_Click(object sender, EventArgs e)
        {
            subMenu.Visible = true;
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            subreserva.Visible = true;

        }

        private void BtnResCerrada_Click(object sender, EventArgs e)
        {
            subreserva.Visible = false;
        }

        private void BtnResAbierta_Click(object sender, EventArgs e)
        {
            subreserva.Visible = false;
        }
    }
}
