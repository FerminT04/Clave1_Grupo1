
namespace Clave1_Grupo1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.paneldiseño1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.panel_menu.Controls.Add(this.BtnUsuario);
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 450);
            this.panel_menu.TabIndex = 1;
            // 
            // paneldiseño1
            // 
            this.paneldiseño1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.paneldiseño1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldiseño1.Location = new System.Drawing.Point(200, 350);
            this.paneldiseño1.Name = "paneldiseño1";
            this.paneldiseño1.Size = new System.Drawing.Size(600, 100);
            this.paneldiseño1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 18);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuario.Image")));
            this.BtnUsuario.Location = new System.Drawing.Point(74, 357);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(46, 45);
            this.BtnUsuario.TabIndex = 4;
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneldiseño1);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.9D;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel paneldiseño1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnUsuario;
    }
}