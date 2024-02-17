// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="frmEstadisticas.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class frmEstadisticas.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class frmEstadisticas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas));
            this.tabProdcuto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHastaProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesdeProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vwEstadisticaProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwEstadisticaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.btnBuscarRTN = new System.Windows.Forms.Button();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.vwEstadisticaClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwEstadisticaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHastaCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesdeCli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.tabEmpleado = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtHastaEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesdeEmp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vwEstadisticaEmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwEstadisticaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vwEstadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.vwEstadisticaProductoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwEstadisticaProductoTableAdapter();
            this.vwEstadisticaClienteTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwEstadisticaClienteTableAdapter();
            this.vwEstadisticaEmpleadoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwEstadisticaEmpleadoTableAdapter();
            this.tacomaDBDataSet1 = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAñoActual = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tabProdcuto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaProductoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaClienteBindingSource)).BeginInit();
            this.tabEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaEmpleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(416, 97);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 17);
            label1.TabIndex = 47;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(395, 97);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 17);
            label3.TabIndex = 47;
            label3.Text = "Codigo de Producto:";
            // 
            // tabProdcuto
            // 
            this.tabProdcuto.Controls.Add(this.tabPage1);
            this.tabProdcuto.Controls.Add(this.tabClientes);
            this.tabProdcuto.Controls.Add(this.tabEmpleado);
            this.tabProdcuto.Location = new System.Drawing.Point(56, 97);
            this.tabProdcuto.Margin = new System.Windows.Forms.Padding(4);
            this.tabProdcuto.Name = "tabProdcuto";
            this.tabProdcuto.SelectedIndex = 0;
            this.tabProdcuto.Size = new System.Drawing.Size(1036, 534);
            this.tabProdcuto.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtHastaProd);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtDesdeProd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.vwEstadisticaProductoDataGridView);
            this.tabPage1.Controls.Add(this.txtCodProd);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Controls.Add(this.btnBuscarRTN);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1028, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prodcutos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 53;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHastaProd
            // 
            this.txtHastaProd.Location = new System.Drawing.Point(579, 58);
            this.txtHastaProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaProd.Name = "txtHastaProd";
            this.txtHastaProd.Size = new System.Drawing.Size(53, 22);
            this.txtHastaProd.TabIndex = 52;
            this.txtHastaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaProd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Hasta:";
            // 
            // txtDesdeProd
            // 
            this.txtDesdeProd.Location = new System.Drawing.Point(457, 58);
            this.txtDesdeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesdeProd.Name = "txtDesdeProd";
            this.txtDesdeProd.Size = new System.Drawing.Size(53, 22);
            this.txtDesdeProd.TabIndex = 50;
            this.txtDesdeProd.TextChanged += new System.EventHandler(this.TxtDesdeProd_TextChanged);
            this.txtDesdeProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesdeProd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Desde:";
            // 
            // vwEstadisticaProductoDataGridView
            // 
            this.vwEstadisticaProductoDataGridView.AllowUserToAddRows = false;
            this.vwEstadisticaProductoDataGridView.AllowUserToDeleteRows = false;
            this.vwEstadisticaProductoDataGridView.AutoGenerateColumns = false;
            this.vwEstadisticaProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwEstadisticaProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
            this.vwEstadisticaProductoDataGridView.DataSource = this.vwEstadisticaProductoBindingSource;
            this.vwEstadisticaProductoDataGridView.Location = new System.Drawing.Point(120, 190);
            this.vwEstadisticaProductoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwEstadisticaProductoDataGridView.Name = "vwEstadisticaProductoDataGridView";
            this.vwEstadisticaProductoDataGridView.ReadOnly = true;
            this.vwEstadisticaProductoDataGridView.RowHeadersWidth = 51;
            this.vwEstadisticaProductoDataGridView.Size = new System.Drawing.Size(792, 271);
            this.vwEstadisticaProductoDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo de Producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo de Producto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total Vendido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Vendido";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // vwEstadisticaProductoBindingSource
            // 
            this.vwEstadisticaProductoBindingSource.DataMember = "VwEstadisticaProducto";
            this.vwEstadisticaProductoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(541, 94);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProd.MaxLength = 14;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(91, 22);
            this.txtCodProd.TabIndex = 48;
            this.txtCodProd.TextChanged += new System.EventHandler(this.TxtCodProd_TextChanged);
            this.txtCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodProd_KeyPress);
            // 
            // btnBuscarRTN
            // 
            this.btnBuscarRTN.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarRTN.Image")));
            this.btnBuscarRTN.Location = new System.Drawing.Point(399, 135);
            this.btnBuscarRTN.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRTN.Name = "btnBuscarRTN";
            this.btnBuscarRTN.Size = new System.Drawing.Size(235, 28);
            this.btnBuscarRTN.TabIndex = 45;
            this.btnBuscarRTN.UseVisualStyleBackColor = true;
            this.btnBuscarRTN.Click += new System.EventHandler(this.BtnBuscarRTN_Click);
            // 
            // tabClientes
            // 
            this.tabClientes.AutoScroll = true;
            this.tabClientes.Controls.Add(this.button2);
            this.tabClientes.Controls.Add(this.vwEstadisticaClienteDataGridView);
            this.tabClientes.Controls.Add(this.txtHastaCli);
            this.tabClientes.Controls.Add(this.label7);
            this.tabClientes.Controls.Add(this.txtDesdeCli);
            this.tabClientes.Controls.Add(this.label8);
            this.tabClientes.Controls.Add(this.txtNombre);
            this.tabClientes.Controls.Add(this.btnBuscarCliente);
            this.tabClientes.Controls.Add(label1);
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tabClientes.Size = new System.Drawing.Size(1028, 505);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 57;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vwEstadisticaClienteDataGridView
            // 
            this.vwEstadisticaClienteDataGridView.AllowUserToAddRows = false;
            this.vwEstadisticaClienteDataGridView.AllowUserToDeleteRows = false;
            this.vwEstadisticaClienteDataGridView.AutoGenerateColumns = false;
            this.vwEstadisticaClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwEstadisticaClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7});
            this.vwEstadisticaClienteDataGridView.DataSource = this.vwEstadisticaClienteBindingSource;
            this.vwEstadisticaClienteDataGridView.Location = new System.Drawing.Point(160, 196);
            this.vwEstadisticaClienteDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwEstadisticaClienteDataGridView.Name = "vwEstadisticaClienteDataGridView";
            this.vwEstadisticaClienteDataGridView.ReadOnly = true;
            this.vwEstadisticaClienteDataGridView.RowHeadersWidth = 51;
            this.vwEstadisticaClienteDataGridView.Size = new System.Drawing.Size(728, 271);
            this.vwEstadisticaClienteDataGridView.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RTN";
            this.dataGridViewTextBoxColumn5.HeaderText = "RTN";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cantidad de Facturas";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad de Facturas";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total Comprado";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Comprado";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // vwEstadisticaClienteBindingSource
            // 
            this.vwEstadisticaClienteBindingSource.DataMember = "VwEstadisticaCliente";
            this.vwEstadisticaClienteBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // txtHastaCli
            // 
            this.txtHastaCli.Location = new System.Drawing.Point(568, 62);
            this.txtHastaCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaCli.Name = "txtHastaCli";
            this.txtHastaCli.Size = new System.Drawing.Size(53, 22);
            this.txtHastaCli.TabIndex = 56;
            this.txtHastaCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaCli_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Hasta:";
            // 
            // txtDesdeCli
            // 
            this.txtDesdeCli.Location = new System.Drawing.Point(447, 62);
            this.txtDesdeCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesdeCli.Name = "txtDesdeCli";
            this.txtDesdeCli.Size = new System.Drawing.Size(53, 22);
            this.txtDesdeCli.TabIndex = 54;
            this.txtDesdeCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesdeCli_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Desde:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(485, 94);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 14;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 22);
            this.txtNombre.TabIndex = 49;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtRTN_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(388, 142);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(235, 28);
            this.btnBuscarCliente.TabIndex = 48;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.AutoScroll = true;
            this.tabEmpleado.Controls.Add(this.button3);
            this.tabEmpleado.Controls.Add(this.txtHastaEmp);
            this.tabEmpleado.Controls.Add(this.label9);
            this.tabEmpleado.Controls.Add(this.txtDesdeEmp);
            this.tabEmpleado.Controls.Add(this.label10);
            this.tabEmpleado.Controls.Add(this.vwEstadisticaEmpleadoDataGridView);
            this.tabEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.tabEmpleado.Controls.Add(this.txtNomEmp);
            this.tabEmpleado.Controls.Add(this.label2);
            this.tabEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tabEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.Padding = new System.Windows.Forms.Padding(4);
            this.tabEmpleado.Size = new System.Drawing.Size(1028, 505);
            this.tabEmpleado.TabIndex = 2;
            this.tabEmpleado.Text = "Empleado";
            this.tabEmpleado.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(805, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 61;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtHastaEmp
            // 
            this.txtHastaEmp.Location = new System.Drawing.Point(575, 76);
            this.txtHastaEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaEmp.Name = "txtHastaEmp";
            this.txtHastaEmp.Size = new System.Drawing.Size(53, 22);
            this.txtHastaEmp.TabIndex = 60;
            this.txtHastaEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHastaEmp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Hasta:";
            // 
            // txtDesdeEmp
            // 
            this.txtDesdeEmp.Location = new System.Drawing.Point(453, 76);
            this.txtDesdeEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesdeEmp.Name = "txtDesdeEmp";
            this.txtDesdeEmp.Size = new System.Drawing.Size(53, 22);
            this.txtDesdeEmp.TabIndex = 58;
            this.txtDesdeEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesdeEmp_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Desde:";
            // 
            // vwEstadisticaEmpleadoDataGridView
            // 
            this.vwEstadisticaEmpleadoDataGridView.AllowUserToAddRows = false;
            this.vwEstadisticaEmpleadoDataGridView.AllowUserToDeleteRows = false;
            this.vwEstadisticaEmpleadoDataGridView.AutoGenerateColumns = false;
            this.vwEstadisticaEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwEstadisticaEmpleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn12});
            this.vwEstadisticaEmpleadoDataGridView.DataSource = this.vwEstadisticaEmpleadoBindingSource;
            this.vwEstadisticaEmpleadoDataGridView.Location = new System.Drawing.Point(155, 208);
            this.vwEstadisticaEmpleadoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwEstadisticaEmpleadoDataGridView.Name = "vwEstadisticaEmpleadoDataGridView";
            this.vwEstadisticaEmpleadoDataGridView.ReadOnly = true;
            this.vwEstadisticaEmpleadoDataGridView.RowHeadersWidth = 51;
            this.vwEstadisticaEmpleadoDataGridView.Size = new System.Drawing.Size(725, 271);
            this.vwEstadisticaEmpleadoDataGridView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Cantidad de Facturas";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cantidad de Facturas";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Total Vendido";
            this.dataGridViewTextBoxColumn14.HeaderText = "Total Vendido";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // vwEstadisticaEmpleadoBindingSource
            // 
            this.vwEstadisticaEmpleadoBindingSource.DataMember = "VwEstadisticaEmpleado";
            this.vwEstadisticaEmpleadoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(395, 156);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(235, 28);
            this.btnBuscarEmpleado.TabIndex = 49;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.BtnBuscarEmpleado_Click);
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new System.Drawing.Point(475, 108);
            this.txtNomEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(132, 22);
            this.txtNomEmp.TabIndex = 2;
            this.txtNomEmp.TextChanged += new System.EventHandler(this.TxtnombreEmp_TextChanged);
            this.txtNomEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoEmp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CiudadTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Cotizacion_DetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.EsclavoTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ISV_HistoricoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.Producto_CategoriaTableAdapter = null;
            this.tableAdapterManager.Producto_SubcategoriaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Proveedores_ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Rol_SistemaTableAdapter = null;
            this.tableAdapterManager.Roles_DepartamentosTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoDePagoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vwEstadisticaProductoTableAdapter
            // 
            this.vwEstadisticaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // vwEstadisticaClienteTableAdapter
            // 
            this.vwEstadisticaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // vwEstadisticaEmpleadoTableAdapter
            // 
            this.vwEstadisticaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tacomaDBDataSet1
            // 
            this.tacomaDBDataSet1.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Año:";
            // 
            // lblAñoActual
            // 
            this.lblAñoActual.AutoSize = true;
            this.lblAñoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoActual.Location = new System.Drawing.Point(535, 57);
            this.lblAñoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoActual.Name = "lblAñoActual";
            this.lblAñoActual.Size = new System.Drawing.Size(0, 36);
            this.lblAñoActual.TabIndex = 2;
            this.lblAñoActual.Click += new System.EventHandler(this.LblAñoActual_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(409, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 46);
            this.label11.TabIndex = 3;
            this.label11.Text = "Estadisticas";
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 668);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAñoActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabProdcuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.tabProdcuto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaProductoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaClienteBindingSource)).EndInit();
            this.tabEmpleado.ResumeLayout(false);
            this.tabEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaEmpleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstadisticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw estadistica binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwEstadisticaBindingSource;
        //private TacomaDBDataSetTableAdapters.VwEstadisticaTableAdapter vwEstadisticaTableAdapter;
        /// <summary>
        /// The table adapter manager
        /// </summary>
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        /// <summary>
        /// The tab prodcuto
        /// </summary>
        private System.Windows.Forms.TabControl tabProdcuto;
        /// <summary>
        /// The tab clientes
        /// </summary>
        private System.Windows.Forms.TabPage tabClientes;
        /// <summary>
        /// The vw estadistica producto binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwEstadisticaProductoBindingSource;
        /// <summary>
        /// The vw estadistica producto table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwEstadisticaProductoTableAdapter vwEstadisticaProductoTableAdapter;
        /// <summary>
        /// The tab page1
        /// </summary>
        private System.Windows.Forms.TabPage tabPage1;
        /// <summary>
        /// The BTN buscar RTN
        /// </summary>
        private System.Windows.Forms.Button btnBuscarRTN;
        /// <summary>
        /// The vw estadistica cliente binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwEstadisticaClienteBindingSource;
        /// <summary>
        /// The vw estadistica cliente table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwEstadisticaClienteTableAdapter vwEstadisticaClienteTableAdapter;
        /// <summary>
        /// The text nombre
        /// </summary>
        private System.Windows.Forms.TextBox txtNombre;
        /// <summary>
        /// The BTN buscar cliente
        /// </summary>
        private System.Windows.Forms.Button btnBuscarCliente;
        /// <summary>
        /// The tab empleado
        /// </summary>
        private System.Windows.Forms.TabPage tabEmpleado;
        /// <summary>
        /// The vw estadistica empleado binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwEstadisticaEmpleadoBindingSource;
        /// <summary>
        /// The vw estadistica empleado table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwEstadisticaEmpleadoTableAdapter vwEstadisticaEmpleadoTableAdapter;
        /// <summary>
        /// The BTN buscar empleado
        /// </summary>
        private System.Windows.Forms.Button btnBuscarEmpleado;
        /// <summary>
        /// The text codigo emp
        /// </summary>
        private System.Windows.Forms.TextBox txtNomEmp;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The text cod product
        /// </summary>
        private System.Windows.Forms.TextBox txtCodProd;
        /// <summary>
        /// The tacoma database data set1
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet1;
        //private System.Windows.Forms.BindingSource vwEstadisticaFechaBindingSource;
        //private TacomaDBDataSetTableAdapters.VwEstadisticaFechaTableAdapter vwEstadisticaFechaTableAdapter;
        /// <summary>
        /// The text hasta product
        /// </summary>
        private System.Windows.Forms.TextBox txtHastaProd;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label label6;
        /// <summary>
        /// The text desde product
        /// </summary>
        private System.Windows.Forms.TextBox txtDesdeProd;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The vw estadistica producto data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwEstadisticaProductoDataGridView;
        /// <summary>
        /// The data grid view text box column1
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        /// <summary>
        /// The data grid view text box column3
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        /// <summary>
        /// The data grid view text box column4
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        /// <summary>
        /// The data grid view text box column2
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        /// <summary>
        /// The text hasta cli
        /// </summary>
        private System.Windows.Forms.TextBox txtHastaCli;
        /// <summary>
        /// The label7
        /// </summary>
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// The text desde cli
        /// </summary>
        private System.Windows.Forms.TextBox txtDesdeCli;
        /// <summary>
        /// The label8
        /// </summary>
        private System.Windows.Forms.Label label8;
        /// <summary>
        /// The vw estadistica cliente data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwEstadisticaClienteDataGridView;
        /// <summary>
        /// The data grid view text box column5
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        /// <summary>
        /// The data grid view text box column6
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        /// <summary>
        /// The data grid view text box column8
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        /// <summary>
        /// The data grid view text box column9
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        /// <summary>
        /// The data grid view text box column7
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        /// <summary>
        /// The text hasta emp
        /// </summary>
        private System.Windows.Forms.TextBox txtHastaEmp;
        /// <summary>
        /// The label9
        /// </summary>
        private System.Windows.Forms.Label label9;
        /// <summary>
        /// The text desde emp
        /// </summary>
        private System.Windows.Forms.TextBox txtDesdeEmp;
        /// <summary>
        /// The label10
        /// </summary>
        private System.Windows.Forms.Label label10;
        /// <summary>
        /// The vw estadistica empleado data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwEstadisticaEmpleadoDataGridView;
        /// <summary>
        /// The data grid view text box column10
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        /// <summary>
        /// The data grid view text box column11
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        /// <summary>
        /// The data grid view text box column13
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        /// <summary>
        /// The data grid view text box column14
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        /// <summary>
        /// The data grid view text box column12
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The label año actual
        /// </summary>
        private System.Windows.Forms.Label lblAñoActual;
        /// <summary>
        /// The label11
        /// </summary>
        private System.Windows.Forms.Label label11;
        /// <summary>
        /// The button1
        /// </summary>
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// The button2
        /// </summary>
        private System.Windows.Forms.Button button2;
        /// <summary>
        /// The button3
        /// </summary>
        private System.Windows.Forms.Button button3;
    }
}