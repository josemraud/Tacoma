// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 11-26-2019
// ***********************************************************************
// <copyright file="Login.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Login.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtlinea = new System.Windows.Forms.TextBox();
            this.textlinea2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 82);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // txtlinea
            // 
            this.txtlinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.txtlinea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlinea.Enabled = false;
            this.txtlinea.ForeColor = System.Drawing.Color.White;
            this.txtlinea.Location = new System.Drawing.Point(317, 114);
            this.txtlinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlinea.MaxLength = 20;
            this.txtlinea.Name = "txtlinea";
            this.txtlinea.Size = new System.Drawing.Size(413, 15);
            this.txtlinea.TabIndex = 1;
            this.txtlinea.Text = "_________________________________________________________________________________" +
    "____________________________________";
            // 
            // textlinea2
            // 
            this.textlinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.textlinea2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textlinea2.Enabled = false;
            this.textlinea2.ForeColor = System.Drawing.Color.White;
            this.textlinea2.Location = new System.Drawing.Point(317, 162);
            this.textlinea2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textlinea2.MaxLength = 20;
            this.textlinea2.Name = "textlinea2";
            this.textlinea2.Size = new System.Drawing.Size(413, 15);
            this.textlinea2.TabIndex = 2;
            this.textlinea2.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAcceder.Location = new System.Drawing.Point(317, 217);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(413, 39);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkpass.AutoSize = true;
            this.linkpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkpass.LinkColor = System.Drawing.Color.White;
            this.linkpass.Location = new System.Drawing.Point(445, 274);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(158, 17);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Olvido su contraseña?";
            this.linkpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpass_LinkClicked);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(317, 110);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(413, 15);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "USUARIO";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtCont
            // 
            this.txtCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.txtCont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCont.ForeColor = System.Drawing.Color.White;
            this.txtCont.Location = new System.Drawing.Point(317, 158);
            this.txtCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCont.MaxLength = 20;
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(413, 15);
            this.txtCont.TabIndex = 2;
            this.txtCont.Text = "CONTRASEÑA";
            this.txtCont.Enter += new System.EventHandler(this.txtCont_Enter);
            this.txtCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCont_KeyPress);
            this.txtCont.Leave += new System.EventHandler(this.txtCont_Leave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(753, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(727, 7);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.TabIndex = 9;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textlinea2);
            this.Controls.Add(this.txtlinea);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The txtlinea
        /// </summary>
        private System.Windows.Forms.TextBox txtlinea;
        /// <summary>
        /// The textlinea2
        /// </summary>
        private System.Windows.Forms.TextBox textlinea2;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The BTN acceder
        /// </summary>
        private System.Windows.Forms.Button btnAcceder;
        /// <summary>
        /// The linkpass
        /// </summary>
        private System.Windows.Forms.LinkLabel linkpass;
        /// <summary>
        /// The text user
        /// </summary>
        private System.Windows.Forms.TextBox txtUser;
        /// <summary>
        /// The text cont
        /// </summary>
        private System.Windows.Forms.TextBox txtCont;
        /// <summary>
        /// The picture box3
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox3;
        /// <summary>
        /// The BTN cerrar
        /// </summary>
        private System.Windows.Forms.PictureBox btnCerrar;
        /// <summary>
        /// The BTN minimum
        /// </summary>
        private System.Windows.Forms.PictureBox btnMin;
    }
}

