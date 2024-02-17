// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-07-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="OpcionFacturacion.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class OpcionFacturacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class OpcionFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionFacturacion));
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnFacturar);
            this.panel.Controls.Add(this.btnHistorial);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1239, 745);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(440, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facturación";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.Location = new System.Drawing.Point(278, 268);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(224, 230);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.Location = new System.Drawing.Point(627, 268);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(219, 230);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // OpcionFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 745);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionFacturacion";
            this.Text = "OpcionFacturacion";
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
        /// The BTN facturar
        /// </summary>
        private System.Windows.Forms.Button btnFacturar;
        /// <summary>
        /// The BTN historial
        /// </summary>
        private System.Windows.Forms.Button btnHistorial;
    }
}