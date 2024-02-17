// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-11-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="OpcionProveedor.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class OpcionProveedor.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class OpcionProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionProveedor));
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnProPro = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnProveedor);
            this.panel.Controls.Add(this.btnProPro);
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
            this.label1.Location = new System.Drawing.Point(428, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Proveedor";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.Location = new System.Drawing.Point(242, 258);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(224, 263);
            this.btnProveedor.TabIndex = 8;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnProPro
            // 
            this.btnProPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProPro.Image = ((System.Drawing.Image)(resources.GetObject("btnProPro.Image")));
            this.btnProPro.Location = new System.Drawing.Point(591, 258);
            this.btnProPro.Name = "btnProPro";
            this.btnProPro.Size = new System.Drawing.Size(219, 263);
            this.btnProPro.TabIndex = 7;
            this.btnProPro.Text = "Proveedor por Producto";
            this.btnProPro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProPro.UseVisualStyleBackColor = true;
            this.btnProPro.Click += new System.EventHandler(this.btnProPro_Click);
            // 
            // OpcionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 745);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionProveedor";
            this.Text = "OpcionProveedor";
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
        /// The BTN proveedor
        /// </summary>
        private System.Windows.Forms.Button btnProveedor;
        /// <summary>
        /// The BTN pro pro
        /// </summary>
        private System.Windows.Forms.Button btnProPro;
    }
}