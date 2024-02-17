// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-26-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="RecuperacionContraseña.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class RecuperacionContraseña.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class RecuperacionContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperacionContraseña));
            this.btnRest = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRest.FlatAppearance.BorderSize = 0;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRest.Location = new System.Drawing.Point(86, 163);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(296, 47);
            this.btnRest.TabIndex = 0;
            this.btnRest.Text = "Restablecer";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtUser.Location = new System.Drawing.Point(86, 98);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(296, 16);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUser_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recuperacion de contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(435, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // RecuperacionContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(460, 296);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnRest);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperacionContraseña";
            this.Text = "RecuperacionContraseña";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecuperacionContraseña_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The BTN rest
        /// </summary>
        private System.Windows.Forms.Button btnRest;
        /// <summary>
        /// The text user
        /// </summary>
        private System.Windows.Forms.TextBox txtUser;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The BTN cerrar
        /// </summary>
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}