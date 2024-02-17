// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-11-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="OpcionCotizacion.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class OpcionCotizacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class OpcionCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionCotizacion));
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnCotizacion);
            this.panel.Controls.Add(this.btnHistorial);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1239, 745);
            this.panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(440, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cotización";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizacion.Image")));
            this.btnCotizacion.Location = new System.Drawing.Point(278, 268);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(224, 230);
            this.btnCotizacion.TabIndex = 8;
            this.btnCotizacion.Text = "Cotizar";
            this.btnCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.Location = new System.Drawing.Point(627, 268);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(219, 230);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // OpcionCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 745);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionCotizacion";
            this.Text = "OpcionCotizacion";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The panel
        /// </summary>
        private System.Windows.Forms.Panel panel;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The BTN cotizacion
        /// </summary>
        private System.Windows.Forms.Button btnCotizacion;
        /// <summary>
        /// The BTN historial
        /// </summary>
        private System.Windows.Forms.Button btnHistorial;
    }
}