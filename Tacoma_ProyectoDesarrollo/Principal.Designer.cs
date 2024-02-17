// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-12-2019
// ***********************************************************************
// <copyright file="Principal.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Principal.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMantenimiento = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.MenuVertical.Controls.Add(this.label4);
            this.MenuVertical.Controls.Add(this.pictureBox4);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.btnVentas);
            this.MenuVertical.Controls.Add(this.btnCotizacion);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.btnClientes);
            this.MenuVertical.Controls.Add(this.btnProveedores);
            this.MenuVertical.Controls.Add(this.btnInventario);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.label2);
            this.MenuVertical.Controls.Add(this.label3);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(275, 750);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1, 694);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cerrar sesión";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(157, 671);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(117, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.MediumBlue;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 91);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(269, 65);
            this.btnVentas.TabIndex = 14;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizacion.FlatAppearance.BorderSize = 0;
            this.btnCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCotizacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizacion.Image")));
            this.btnCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizacion.Location = new System.Drawing.Point(0, 160);
            this.btnCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(269, 65);
            this.btnCotizacion.TabIndex = 15;
            this.btnCotizacion.Text = "     Cotizacion";
            this.btnCotizacion.UseVisualStyleBackColor = false;
            this.btnCotizacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.MediumBlue;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 229);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(269, 65);
            this.btnProductos.TabIndex = 16;
            this.btnProductos.Text = "    Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Visible = false;
            this.btnProductos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 298);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(269, 65);
            this.btnEmpleados.TabIndex = 17;
            this.btnEmpleados.Text = "     Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Visible = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 367);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(269, 65);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.MediumBlue;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 436);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(269, 65);
            this.btnProveedores.TabIndex = 19;
            this.btnProveedores.Text = "       Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Visible = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.MediumBlue;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 505);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(269, 65);
            this.btnInventario.TabIndex = 20;
            this.btnInventario.Text = "   Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Visible = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correo";
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.iconminimizar);
            this.barraTitulo.Controls.Add(this.pictureBox3);
            this.barraTitulo.Controls.Add(this.btnMantenimiento);
            this.barraTitulo.Controls.Add(this.iconcerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(275, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1112, 50);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(962, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.Location = new System.Drawing.Point(998, 14);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(25, 25);
            this.btnMantenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMantenimiento.TabIndex = 0;
            this.btnMantenimiento.TabStop = false;
            this.btnMantenimiento.Visible = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1069, 14);
            this.iconcerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(25, 25);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 21;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click_1);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(1033, 14);
            this.iconminimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(25, 25);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 23;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click_1);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(275, 50);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1112, 700);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1387, 750);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The menu vertical
        /// </summary>
        private System.Windows.Forms.Panel MenuVertical;
        /// <summary>
        /// The picture box1
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox1;
        /// <summary>
        /// The picture box2
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox2;
        /// <summary>
        /// The BTN ventas
        /// </summary>
        private System.Windows.Forms.Button btnVentas;
        /// <summary>
        /// The BTN cotizacion
        /// </summary>
        private System.Windows.Forms.Button btnCotizacion;
        /// <summary>
        /// The BTN productos
        /// </summary>
        private System.Windows.Forms.Button btnProductos;
        /// <summary>
        /// The BTN empleados
        /// </summary>
        private System.Windows.Forms.Button btnEmpleados;
        /// <summary>
        /// The BTN clientes
        /// </summary>
        private System.Windows.Forms.Button btnClientes;
        /// <summary>
        /// The BTN proveedores
        /// </summary>
        private System.Windows.Forms.Button btnProveedores;
        /// <summary>
        /// The BTN inventario
        /// </summary>
        private System.Windows.Forms.Button btnInventario;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The barra titulo
        /// </summary>
        private System.Windows.Forms.Panel barraTitulo;
        /// <summary>
        /// The iconcerrar
        /// </summary>
        private System.Windows.Forms.PictureBox iconcerrar;
        /// <summary>
        /// The iconminimizar
        /// </summary>
        private System.Windows.Forms.PictureBox iconminimizar;
        /// <summary>
        /// The panel contenedor
        /// </summary>
        private System.Windows.Forms.Panel panelContenedor;
        /// <summary>
        /// The BTN mantenimiento
        /// </summary>
        private System.Windows.Forms.PictureBox btnMantenimiento;
        /// <summary>
        /// The picture box3
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox3;
        /// <summary>
        /// The picture box4
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox4;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
    }
}