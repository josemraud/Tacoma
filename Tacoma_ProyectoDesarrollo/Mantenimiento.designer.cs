// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-02-2019
//
// Last Modified By : pepit
// Last Modified On : 12-10-2019
// ***********************************************************************
// <copyright file="Mantenimiento.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Mantenimiento.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Mantenimiento
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
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label codigo_SubcategoriaLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label rol_DescripcionLabel;
            System.Windows.Forms.Label rol_CodigoLabel;
            System.Windows.Forms.Label departamento_DescripcionLabel;
            System.Windows.Forms.Label departamento_IDLabel;
            System.Windows.Forms.Label nombre_de_ciudadLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label codigo_de_ciudadLabel;
            System.Windows.Forms.Label pais_NombreLabel;
            System.Windows.Forms.Label pais_CodigoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.vwCiudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rol_SistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RolesDeparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorPais = new System.Windows.Forms.ErrorProvider(this.components);
            this.vwCiudadesTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwCiudadesTableAdapter();
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.paisTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.PaisTableAdapter();
            this.errorNomCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcmbPais = new System.Windows.Forms.ErrorProvider(this.components);
            this.tacomaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorDescripSubcat = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCmbCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.estadoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.EstadoTableAdapter();
            this.rol_SistemaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Rol_SistemaTableAdapter();
            this.errorDescripRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.departamentoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.DepartamentoTableAdapter();
            this.errorCodDepar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtDeparDescrip = new System.Windows.Forms.ErrorProvider(this.components);
            this.rolesTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.RolesTableAdapter();
            this.errorRolDescrip = new System.Windows.Forms.ErrorProvider(this.components);
            this.vw_RolesDeparTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.vw_RolesDeparTableAdapter();
            this.errorCmbDepar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCmbRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.vwSubcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSubcategoriaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwSubcategoriaTableAdapter();
            this.productoCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_CategoriaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Producto_CategoriaTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripSubcat = new System.Windows.Forms.TextBox();
            this.txtCodSubcat = new System.Windows.Forms.TextBox();
            this.btnAñadirSubcat = new System.Windows.Forms.Button();
            this.btnModificarSubcat = new System.Windows.Forms.Button();
            this.btnGuardarSubcat = new System.Windows.Forms.Button();
            this.btnGuardarCambiosSubcat = new System.Windows.Forms.Button();
            this.btnCancelarSubcat = new System.Windows.Forms.Button();
            this.vwSubcategoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.vw_RolesDeparDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.cmbDepar = new System.Windows.Forms.ComboBox();
            this.btnAñadirRolenDepar = new System.Windows.Forms.Button();
            this.btnGuardarRolenDepar = new System.Windows.Forms.Button();
            this.btnCancelarRolenDepar = new System.Windows.Forms.Button();
            this.btnEliminarRolenDepar = new System.Windows.Forms.Button();
            this.btnAñadirRDepar = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.rolesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRolNom = new System.Windows.Forms.TextBox();
            this.txtCodRol = new System.Windows.Forms.TextBox();
            this.btnAñadirRolDepar = new System.Windows.Forms.Button();
            this.btnModificarRDepar = new System.Windows.Forms.Button();
            this.btnGuardarRDepar = new System.Windows.Forms.Button();
            this.btnGuardarCambiosRDepar = new System.Windows.Forms.Button();
            this.btnCancelarRDepar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.departamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDeparNom = new System.Windows.Forms.TextBox();
            this.txtCodDepar = new System.Windows.Forms.TextBox();
            this.btnAñadirDepar = new System.Windows.Forms.Button();
            this.btnModificarDepar = new System.Windows.Forms.Button();
            this.btnGuardarDepar = new System.Windows.Forms.Button();
            this.btnGuardarCambiosDepar = new System.Windows.Forms.Button();
            this.btnCancelarDepar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.vwCiudadesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNomCiudad = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtCodCiudad = new System.Windows.Forms.TextBox();
            this.btnAñadirCiudad = new System.Windows.Forms.Button();
            this.btnModificarCiudad = new System.Windows.Forms.Button();
            this.btnGuardarCiudad = new System.Windows.Forms.Button();
            this.btnGuardarCambiosCiudad = new System.Windows.Forms.Button();
            this.btnCancelarCiudad = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.lblPaises = new System.Windows.Forms.Label();
            this.paisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomPais = new System.Windows.Forms.TextBox();
            this.txtCodPai = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardarPa = new System.Windows.Forms.Button();
            this.btnGuardarCam = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabPayCi = new System.Windows.Forms.TabControl();
            categoriaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            codigo_SubcategoriaLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            rol_DescripcionLabel = new System.Windows.Forms.Label();
            rol_CodigoLabel = new System.Windows.Forms.Label();
            departamento_DescripcionLabel = new System.Windows.Forms.Label();
            departamento_IDLabel = new System.Windows.Forms.Label();
            nombre_de_ciudadLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            codigo_de_ciudadLabel = new System.Windows.Forms.Label();
            pais_NombreLabel = new System.Windows.Forms.Label();
            pais_CodigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCiudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rol_SistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_RolesDeparBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcmbPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripSubcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCmbCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodDepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtDeparDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRolDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCmbDepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCmbRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubcategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoCategoriaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubcategoriaDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_RolesDeparDataGridView)).BeginInit();
            this.panel8.SuspendLayout();
            this.btnAñadirRDepar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCiudadesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPayCi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCiudadesBindingSource
            // 
            this.vwCiudadesBindingSource.DataMember = "VwCiudades";
            this.vwCiudadesBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // paisBindingSource1
            // 
            this.paisBindingSource1.DataMember = "Pais";
            this.paisBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // rol_SistemaBindingSource
            // 
            this.rol_SistemaBindingSource.DataMember = "Rol_Sistema";
            this.rol_SistemaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vw_RolesDeparBindingSource
            // 
            this.vw_RolesDeparBindingSource.DataMember = "vw_RolesDepar";
            this.vw_RolesDeparBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // errorPais
            // 
            this.errorPais.ContainerControl = this;
            // 
            // vwCiudadesTableAdapter
            // 
            this.vwCiudadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CiudadTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Cotizacion_DetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.EsclavoTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ISV_HistoricoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = this.paisTableAdapter;
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
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // errorNomCiudad
            // 
            this.errorNomCiudad.ContainerControl = this;
            // 
            // errorcmbPais
            // 
            this.errorcmbPais.ContainerControl = this;
            // 
            // tacomaDBDataSetBindingSource
            // 
            this.tacomaDBDataSetBindingSource.DataSource = this.tacomaDBDataSet;
            this.tacomaDBDataSetBindingSource.Position = 0;
            // 
            // errorDescripSubcat
            // 
            this.errorDescripSubcat.ContainerControl = this;
            // 
            // errorCmbCategoria
            // 
            this.errorCmbCategoria.ContainerControl = this;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // rol_SistemaTableAdapter
            // 
            this.rol_SistemaTableAdapter.ClearBeforeFill = true;
            // 
            // errorDescripRol
            // 
            this.errorDescripRol.ContainerControl = this;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // errorCodDepar
            // 
            this.errorCodDepar.ContainerControl = this;
            // 
            // errortxtDeparDescrip
            // 
            this.errortxtDeparDescrip.ContainerControl = this;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // errorRolDescrip
            // 
            this.errorRolDescrip.ContainerControl = this;
            // 
            // vw_RolesDeparTableAdapter
            // 
            this.vw_RolesDeparTableAdapter.ClearBeforeFill = true;
            // 
            // errorCmbDepar
            // 
            this.errorCmbDepar.ContainerControl = this;
            // 
            // errorCmbRol
            // 
            this.errorCmbRol.ContainerControl = this;
            // 
            // vwSubcategoriaBindingSource
            // 
            this.vwSubcategoriaBindingSource.DataMember = "VwSubcategoria";
            this.vwSubcategoriaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwSubcategoriaTableAdapter
            // 
            this.vwSubcategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // productoCategoriaBindingSource
            // 
            this.productoCategoriaBindingSource.DataMember = "Producto_Categoria";
            this.productoCategoriaBindingSource.DataSource = this.tacomaDBDataSetBindingSource;
            // 
            // producto_CategoriaTableAdapter
            // 
            this.producto_CategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.vwSubcategoriaDataGridView);
            this.tabPage2.Controls.Add(this.btnCancelarSubcat);
            this.tabPage2.Controls.Add(this.btnGuardarCambiosSubcat);
            this.tabPage2.Controls.Add(this.btnGuardarSubcat);
            this.tabPage2.Controls.Add(this.btnModificarSubcat);
            this.tabPage2.Controls.Add(this.btnAñadirSubcat);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 436);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Sub Categoria";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(codigo_SubcategoriaLabel);
            this.panel3.Controls.Add(this.txtCodSubcat);
            this.panel3.Controls.Add(descripcionLabel);
            this.panel3.Controls.Add(this.txtDescripSubcat);
            this.panel3.Controls.Add(categoriaLabel);
            this.panel3.Controls.Add(this.cmbCategoria);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(593, 115);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 213);
            this.panel3.TabIndex = 46;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwSubcategoriaBindingSource, "Categoria", true));
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwSubcategoriaBindingSource, "Categoria", true));
            this.cmbCategoria.DataSource = this.productoCategoriaBindingSource;
            this.cmbCategoria.DisplayMember = "Categoria_Descripcion";
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(182, 123);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.ValueMember = "Categoria_ID";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(32, 126);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(73, 17);
            categoriaLabel.TabIndex = 4;
            categoriaLabel.Text = "Categoria:";
            // 
            // txtDescripSubcat
            // 
            this.txtDescripSubcat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwSubcategoriaBindingSource, "Descripcion", true));
            this.txtDescripSubcat.Location = new System.Drawing.Point(182, 95);
            this.txtDescripSubcat.Name = "txtDescripSubcat";
            this.txtDescripSubcat.Size = new System.Drawing.Size(121, 22);
            this.txtDescripSubcat.TabIndex = 3;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(32, 98);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // txtCodSubcat
            // 
            this.txtCodSubcat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwSubcategoriaBindingSource, "Codigo Subcategoria", true));
            this.txtCodSubcat.Enabled = false;
            this.txtCodSubcat.Location = new System.Drawing.Point(182, 60);
            this.txtCodSubcat.Name = "txtCodSubcat";
            this.txtCodSubcat.Size = new System.Drawing.Size(121, 22);
            this.txtCodSubcat.TabIndex = 6;
            // 
            // codigo_SubcategoriaLabel
            // 
            codigo_SubcategoriaLabel.AutoSize = true;
            codigo_SubcategoriaLabel.Location = new System.Drawing.Point(32, 63);
            codigo_SubcategoriaLabel.Name = "codigo_SubcategoriaLabel";
            codigo_SubcategoriaLabel.Size = new System.Drawing.Size(144, 17);
            codigo_SubcategoriaLabel.TabIndex = 5;
            codigo_SubcategoriaLabel.Text = "Codigo Subcategoria:";
            // 
            // btnAñadirSubcat
            // 
            this.btnAñadirSubcat.Location = new System.Drawing.Point(45, 373);
            this.btnAñadirSubcat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirSubcat.Name = "btnAñadirSubcat";
            this.btnAñadirSubcat.Size = new System.Drawing.Size(76, 28);
            this.btnAñadirSubcat.TabIndex = 47;
            this.btnAñadirSubcat.Text = "Añadir";
            this.btnAñadirSubcat.UseVisualStyleBackColor = true;
            this.btnAñadirSubcat.Click += new System.EventHandler(this.btnAñadirSubcat_Click_1);
            // 
            // btnModificarSubcat
            // 
            this.btnModificarSubcat.Location = new System.Drawing.Point(367, 373);
            this.btnModificarSubcat.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarSubcat.Name = "btnModificarSubcat";
            this.btnModificarSubcat.Size = new System.Drawing.Size(93, 28);
            this.btnModificarSubcat.TabIndex = 48;
            this.btnModificarSubcat.Text = "Modificar";
            this.btnModificarSubcat.UseVisualStyleBackColor = true;
            this.btnModificarSubcat.Click += new System.EventHandler(this.btnModificarSubcat_Click_1);
            // 
            // btnGuardarSubcat
            // 
            this.btnGuardarSubcat.Enabled = false;
            this.btnGuardarSubcat.Location = new System.Drawing.Point(129, 373);
            this.btnGuardarSubcat.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarSubcat.Name = "btnGuardarSubcat";
            this.btnGuardarSubcat.Size = new System.Drawing.Size(224, 28);
            this.btnGuardarSubcat.TabIndex = 49;
            this.btnGuardarSubcat.Text = "Guardar Subcategoria nueva";
            this.btnGuardarSubcat.UseVisualStyleBackColor = true;
            this.btnGuardarSubcat.Click += new System.EventHandler(this.btnGuardarSubcat_Click_1);
            // 
            // btnGuardarCambiosSubcat
            // 
            this.btnGuardarCambiosSubcat.Enabled = false;
            this.btnGuardarCambiosSubcat.Location = new System.Drawing.Point(469, 373);
            this.btnGuardarCambiosSubcat.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambiosSubcat.Name = "btnGuardarCambiosSubcat";
            this.btnGuardarCambiosSubcat.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarCambiosSubcat.TabIndex = 50;
            this.btnGuardarCambiosSubcat.Text = "Guardar cambios";
            this.btnGuardarCambiosSubcat.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosSubcat.Click += new System.EventHandler(this.btnGuardarCambiosSubcat_Click_1);
            // 
            // btnCancelarSubcat
            // 
            this.btnCancelarSubcat.Enabled = false;
            this.btnCancelarSubcat.Location = new System.Drawing.Point(622, 373);
            this.btnCancelarSubcat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarSubcat.Name = "btnCancelarSubcat";
            this.btnCancelarSubcat.Size = new System.Drawing.Size(93, 28);
            this.btnCancelarSubcat.TabIndex = 52;
            this.btnCancelarSubcat.Text = "Cancelar";
            this.btnCancelarSubcat.UseVisualStyleBackColor = true;
            this.btnCancelarSubcat.Click += new System.EventHandler(this.btnCancelarSubcat_Click_1);
            // 
            // vwSubcategoriaDataGridView
            // 
            this.vwSubcategoriaDataGridView.AllowUserToAddRows = false;
            this.vwSubcategoriaDataGridView.AllowUserToDeleteRows = false;
            this.vwSubcategoriaDataGridView.AutoGenerateColumns = false;
            this.vwSubcategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwSubcategoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vwSubcategoriaDataGridView.DataSource = this.vwSubcategoriaBindingSource;
            this.vwSubcategoriaDataGridView.Location = new System.Drawing.Point(84, 108);
            this.vwSubcategoriaDataGridView.Name = "vwSubcategoriaDataGridView";
            this.vwSubcategoriaDataGridView.ReadOnly = true;
            this.vwSubcategoriaDataGridView.RowHeadersWidth = 51;
            this.vwSubcategoriaDataGridView.RowTemplate.Height = 24;
            this.vwSubcategoriaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwSubcategoriaDataGridView.Size = new System.Drawing.Size(433, 220);
            this.vwSubcategoriaDataGridView.TabIndex = 51;
            this.vwSubcategoriaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwSubcategoriaDataGridView_CellClick_1);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Codigo Subcategoria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo Subcategoria";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1027, 436);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Departamentos y Roles";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.btnAñadirRDepar);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnEliminarRolenDepar);
            this.tabPage7.Controls.Add(this.btnCancelarRolenDepar);
            this.tabPage7.Controls.Add(this.btnGuardarRolenDepar);
            this.tabPage7.Controls.Add(this.btnAñadirRolenDepar);
            this.tabPage7.Controls.Add(this.panel8);
            this.tabPage7.Controls.Add(this.vw_RolesDeparDataGridView);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1004, 393);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Roles por Departamento";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Click += new System.EventHandler(this.TabPage7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Roles por departamento";
            // 
            // vw_RolesDeparDataGridView
            // 
            this.vw_RolesDeparDataGridView.AllowUserToAddRows = false;
            this.vw_RolesDeparDataGridView.AllowUserToDeleteRows = false;
            this.vw_RolesDeparDataGridView.AutoGenerateColumns = false;
            this.vw_RolesDeparDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_RolesDeparDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.vw_RolesDeparDataGridView.DataSource = this.vw_RolesDeparBindingSource;
            this.vw_RolesDeparDataGridView.Location = new System.Drawing.Point(52, 59);
            this.vw_RolesDeparDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vw_RolesDeparDataGridView.Name = "vw_RolesDeparDataGridView";
            this.vw_RolesDeparDataGridView.ReadOnly = true;
            this.vw_RolesDeparDataGridView.RowHeadersWidth = 51;
            this.vw_RolesDeparDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vw_RolesDeparDataGridView.Size = new System.Drawing.Size(400, 235);
            this.vw_RolesDeparDataGridView.TabIndex = 3;
            this.vw_RolesDeparDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vw_RolesDeparDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Rol";
            this.dataGridViewTextBoxColumn18.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn17.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(departamentoLabel);
            this.panel8.Controls.Add(this.cmbDepar);
            this.panel8.Controls.Add(rolLabel);
            this.panel8.Controls.Add(this.cmbRol);
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(533, 59);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(413, 235);
            this.panel8.TabIndex = 4;
            // 
            // cmbRol
            // 
            this.cmbRol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vw_RolesDeparBindingSource, "Rol", true));
            this.cmbRol.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vw_RolesDeparBindingSource, "Rol", true));
            this.cmbRol.DataSource = this.rolesBindingSource;
            this.cmbRol.DisplayMember = "Rol_Descripcion";
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(177, 110);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(160, 24);
            this.cmbRol.TabIndex = 3;
            this.cmbRol.ValueMember = "Rol_Codigo";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Location = new System.Drawing.Point(67, 113);
            rolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(33, 17);
            rolLabel.TabIndex = 2;
            rolLabel.Text = "Rol:";
            // 
            // cmbDepar
            // 
            this.cmbDepar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vw_RolesDeparBindingSource, "Departamento", true));
            this.cmbDepar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vw_RolesDeparBindingSource, "Departamento", true));
            this.cmbDepar.DataSource = this.departamentoBindingSource;
            this.cmbDepar.DisplayMember = "Departamento_Descripcion";
            this.cmbDepar.FormattingEnabled = true;
            this.cmbDepar.Location = new System.Drawing.Point(177, 76);
            this.cmbDepar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepar.Name = "cmbDepar";
            this.cmbDepar.Size = new System.Drawing.Size(160, 24);
            this.cmbDepar.TabIndex = 1;
            this.cmbDepar.ValueMember = "Departamento_ID";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(67, 80);
            departamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(102, 17);
            departamentoLabel.TabIndex = 0;
            departamentoLabel.Text = "Departamento:";
            // 
            // btnAñadirRolenDepar
            // 
            this.btnAñadirRolenDepar.Location = new System.Drawing.Point(53, 335);
            this.btnAñadirRolenDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirRolenDepar.Name = "btnAñadirRolenDepar";
            this.btnAñadirRolenDepar.Size = new System.Drawing.Size(76, 28);
            this.btnAñadirRolenDepar.TabIndex = 66;
            this.btnAñadirRolenDepar.Text = "Añadir";
            this.btnAñadirRolenDepar.UseVisualStyleBackColor = true;
            this.btnAñadirRolenDepar.Click += new System.EventHandler(this.BtnAñadirRolenDepar_Click);
            // 
            // btnGuardarRolenDepar
            // 
            this.btnGuardarRolenDepar.Enabled = false;
            this.btnGuardarRolenDepar.Location = new System.Drawing.Point(137, 335);
            this.btnGuardarRolenDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarRolenDepar.Name = "btnGuardarRolenDepar";
            this.btnGuardarRolenDepar.Size = new System.Drawing.Size(259, 28);
            this.btnGuardarRolenDepar.TabIndex = 68;
            this.btnGuardarRolenDepar.Text = "Guardar rol en departamento";
            this.btnGuardarRolenDepar.UseVisualStyleBackColor = true;
            this.btnGuardarRolenDepar.Click += new System.EventHandler(this.BtnGuardarRolenDepar_Click);
            // 
            // btnCancelarRolenDepar
            // 
            this.btnCancelarRolenDepar.Enabled = false;
            this.btnCancelarRolenDepar.Location = new System.Drawing.Point(649, 335);
            this.btnCancelarRolenDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarRolenDepar.Name = "btnCancelarRolenDepar";
            this.btnCancelarRolenDepar.Size = new System.Drawing.Size(93, 28);
            this.btnCancelarRolenDepar.TabIndex = 70;
            this.btnCancelarRolenDepar.Text = "Cancelar";
            this.btnCancelarRolenDepar.UseVisualStyleBackColor = true;
            this.btnCancelarRolenDepar.Click += new System.EventHandler(this.BtnCancelarRolenDepar_Click);
            // 
            // btnEliminarRolenDepar
            // 
            this.btnEliminarRolenDepar.Location = new System.Drawing.Point(435, 335);
            this.btnEliminarRolenDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarRolenDepar.Name = "btnEliminarRolenDepar";
            this.btnEliminarRolenDepar.Size = new System.Drawing.Size(207, 28);
            this.btnEliminarRolenDepar.TabIndex = 71;
            this.btnEliminarRolenDepar.Text = "Eliminar rol en departamento";
            this.btnEliminarRolenDepar.UseVisualStyleBackColor = true;
            this.btnEliminarRolenDepar.Click += new System.EventHandler(this.BtnEliminarRolenDepar_Click);
            // 
            // btnAñadirRDepar
            // 
            this.btnAñadirRDepar.AutoScroll = true;
            this.btnAñadirRDepar.Controls.Add(this.btnCancelarRDepar);
            this.btnAñadirRDepar.Controls.Add(this.btnGuardarCambiosRDepar);
            this.btnAñadirRDepar.Controls.Add(this.btnGuardarRDepar);
            this.btnAñadirRDepar.Controls.Add(this.btnModificarRDepar);
            this.btnAñadirRDepar.Controls.Add(this.btnAñadirRolDepar);
            this.btnAñadirRDepar.Controls.Add(this.panel7);
            this.btnAñadirRDepar.Controls.Add(this.rolesDataGridView);
            this.btnAñadirRDepar.Controls.Add(this.label8);
            this.btnAñadirRDepar.Location = new System.Drawing.Point(4, 25);
            this.btnAñadirRDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirRDepar.Name = "btnAñadirRDepar";
            this.btnAñadirRDepar.Padding = new System.Windows.Forms.Padding(4);
            this.btnAñadirRDepar.Size = new System.Drawing.Size(1004, 393);
            this.btnAñadirRDepar.TabIndex = 1;
            this.btnAñadirRDepar.Text = "Roles";
            this.btnAñadirRDepar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Roles";
            // 
            // rolesDataGridView
            // 
            this.rolesDataGridView.AllowUserToAddRows = false;
            this.rolesDataGridView.AllowUserToDeleteRows = false;
            this.rolesDataGridView.AutoGenerateColumns = false;
            this.rolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.rolesDataGridView.DataSource = this.rolesBindingSource;
            this.rolesDataGridView.Location = new System.Drawing.Point(29, 111);
            this.rolesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.rolesDataGridView.Name = "rolesDataGridView";
            this.rolesDataGridView.ReadOnly = true;
            this.rolesDataGridView.RowHeadersWidth = 51;
            this.rolesDataGridView.Size = new System.Drawing.Size(411, 161);
            this.rolesDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Rol_Descripcion";
            this.dataGridViewTextBoxColumn16.HeaderText = "Descripcion de Rol";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Rol_Codigo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Codigo de Rol";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(rol_CodigoLabel);
            this.panel7.Controls.Add(this.txtCodRol);
            this.panel7.Controls.Add(rol_DescripcionLabel);
            this.panel7.Controls.Add(this.txtRolNom);
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(539, 111);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(363, 161);
            this.panel7.TabIndex = 59;
            // 
            // txtRolNom
            // 
            this.txtRolNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Rol_Descripcion", true));
            this.txtRolNom.Location = new System.Drawing.Point(179, 81);
            this.txtRolNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtRolNom.Name = "txtRolNom";
            this.txtRolNom.Size = new System.Drawing.Size(132, 22);
            this.txtRolNom.TabIndex = 3;
            this.txtRolNom.TextChanged += new System.EventHandler(this.TxtRolNom_TextChanged);
            this.txtRolNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRolNom_KeyPress);
            // 
            // rol_DescripcionLabel
            // 
            rol_DescripcionLabel.AutoSize = true;
            rol_DescripcionLabel.Location = new System.Drawing.Point(57, 85);
            rol_DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rol_DescripcionLabel.Name = "rol_DescripcionLabel";
            rol_DescripcionLabel.Size = new System.Drawing.Size(111, 17);
            rol_DescripcionLabel.TabIndex = 2;
            rol_DescripcionLabel.Text = "Rol Descripcion:";
            // 
            // txtCodRol
            // 
            this.txtCodRol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Rol_Codigo", true));
            this.txtCodRol.Enabled = false;
            this.txtCodRol.Location = new System.Drawing.Point(179, 49);
            this.txtCodRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodRol.Name = "txtCodRol";
            this.txtCodRol.Size = new System.Drawing.Size(132, 22);
            this.txtCodRol.TabIndex = 1;
            // 
            // rol_CodigoLabel
            // 
            rol_CodigoLabel.AutoSize = true;
            rol_CodigoLabel.Location = new System.Drawing.Point(57, 53);
            rol_CodigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rol_CodigoLabel.Name = "rol_CodigoLabel";
            rol_CodigoLabel.Size = new System.Drawing.Size(81, 17);
            rol_CodigoLabel.TabIndex = 0;
            rol_CodigoLabel.Text = "Rol Codigo:";
            // 
            // btnAñadirRolDepar
            // 
            this.btnAñadirRolDepar.Location = new System.Drawing.Point(39, 309);
            this.btnAñadirRolDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirRolDepar.Name = "btnAñadirRolDepar";
            this.btnAñadirRolDepar.Size = new System.Drawing.Size(76, 28);
            this.btnAñadirRolDepar.TabIndex = 61;
            this.btnAñadirRolDepar.Text = "Añadir";
            this.btnAñadirRolDepar.UseVisualStyleBackColor = true;
            this.btnAñadirRolDepar.Click += new System.EventHandler(this.Button11_Click);
            // 
            // btnModificarRDepar
            // 
            this.btnModificarRDepar.Location = new System.Drawing.Point(389, 309);
            this.btnModificarRDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarRDepar.Name = "btnModificarRDepar";
            this.btnModificarRDepar.Size = new System.Drawing.Size(93, 28);
            this.btnModificarRDepar.TabIndex = 62;
            this.btnModificarRDepar.Text = "Modificar";
            this.btnModificarRDepar.UseVisualStyleBackColor = true;
            this.btnModificarRDepar.Click += new System.EventHandler(this.BtnModificarRDepar_Click);
            // 
            // btnGuardarRDepar
            // 
            this.btnGuardarRDepar.Enabled = false;
            this.btnGuardarRDepar.Location = new System.Drawing.Point(123, 309);
            this.btnGuardarRDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarRDepar.Name = "btnGuardarRDepar";
            this.btnGuardarRDepar.Size = new System.Drawing.Size(259, 28);
            this.btnGuardarRDepar.TabIndex = 63;
            this.btnGuardarRDepar.Text = "Guardar rol de departamento nuevo";
            this.btnGuardarRDepar.UseVisualStyleBackColor = true;
            this.btnGuardarRDepar.Click += new System.EventHandler(this.BtnGuardarRDepar_Click);
            // 
            // btnGuardarCambiosRDepar
            // 
            this.btnGuardarCambiosRDepar.Enabled = false;
            this.btnGuardarCambiosRDepar.Location = new System.Drawing.Point(491, 309);
            this.btnGuardarCambiosRDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambiosRDepar.Name = "btnGuardarCambiosRDepar";
            this.btnGuardarCambiosRDepar.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarCambiosRDepar.TabIndex = 64;
            this.btnGuardarCambiosRDepar.Text = "Guardar cambios";
            this.btnGuardarCambiosRDepar.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosRDepar.Click += new System.EventHandler(this.BtnGuardarCambiosRDepar_Click);
            // 
            // btnCancelarRDepar
            // 
            this.btnCancelarRDepar.Enabled = false;
            this.btnCancelarRDepar.Location = new System.Drawing.Point(644, 309);
            this.btnCancelarRDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarRDepar.Name = "btnCancelarRDepar";
            this.btnCancelarRDepar.Size = new System.Drawing.Size(93, 28);
            this.btnCancelarRDepar.TabIndex = 65;
            this.btnCancelarRDepar.Text = "Cancelar";
            this.btnCancelarRDepar.UseVisualStyleBackColor = true;
            this.btnCancelarRDepar.Click += new System.EventHandler(this.BtnCancelarRDepar_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.btnCancelarDepar);
            this.tabPage5.Controls.Add(this.btnGuardarCambiosDepar);
            this.tabPage5.Controls.Add(this.btnGuardarDepar);
            this.tabPage5.Controls.Add(this.btnModificarDepar);
            this.tabPage5.Controls.Add(this.btnAñadirDepar);
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Controls.Add(this.departamentoDataGridView);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1004, 393);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Departamento";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Departamento";
            // 
            // departamentoDataGridView
            // 
            this.departamentoDataGridView.AllowUserToAddRows = false;
            this.departamentoDataGridView.AllowUserToDeleteRows = false;
            this.departamentoDataGridView.AutoGenerateColumns = false;
            this.departamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.departamentoDataGridView.DataSource = this.departamentoBindingSource;
            this.departamentoDataGridView.Location = new System.Drawing.Point(40, 76);
            this.departamentoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.departamentoDataGridView.Name = "departamentoDataGridView";
            this.departamentoDataGridView.ReadOnly = true;
            this.departamentoDataGridView.RowHeadersWidth = 51;
            this.departamentoDataGridView.Size = new System.Drawing.Size(400, 191);
            this.departamentoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Departamento_Descripcion";
            this.dataGridViewTextBoxColumn14.HeaderText = "Nombre de Departamento";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Departamento_ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "Codigo de Departamento";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(departamento_IDLabel);
            this.panel6.Controls.Add(this.txtCodDepar);
            this.panel6.Controls.Add(departamento_DescripcionLabel);
            this.panel6.Controls.Add(this.txtDeparNom);
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(541, 87);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(409, 180);
            this.panel6.TabIndex = 4;
            // 
            // txtDeparNom
            // 
            this.txtDeparNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentoBindingSource, "Departamento_Descripcion", true));
            this.txtDeparNom.Location = new System.Drawing.Point(233, 89);
            this.txtDeparNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeparNom.Name = "txtDeparNom";
            this.txtDeparNom.Size = new System.Drawing.Size(132, 22);
            this.txtDeparNom.TabIndex = 3;
            this.txtDeparNom.TextChanged += new System.EventHandler(this.TxtDeparNom_TextChanged);
            this.txtDeparNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDeparNom_KeyPress);
            // 
            // departamento_DescripcionLabel
            // 
            departamento_DescripcionLabel.AutoSize = true;
            departamento_DescripcionLabel.Location = new System.Drawing.Point(44, 92);
            departamento_DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            departamento_DescripcionLabel.Name = "departamento_DescripcionLabel";
            departamento_DescripcionLabel.Size = new System.Drawing.Size(180, 17);
            departamento_DescripcionLabel.TabIndex = 2;
            departamento_DescripcionLabel.Text = "Departamento Descripcion:";
            // 
            // txtCodDepar
            // 
            this.txtCodDepar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentoBindingSource, "Departamento_ID", true));
            this.txtCodDepar.Enabled = false;
            this.txtCodDepar.Location = new System.Drawing.Point(233, 57);
            this.txtCodDepar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodDepar.Name = "txtCodDepar";
            this.txtCodDepar.Size = new System.Drawing.Size(132, 22);
            this.txtCodDepar.TabIndex = 1;
            // 
            // departamento_IDLabel
            // 
            departamento_IDLabel.AutoSize = true;
            departamento_IDLabel.Location = new System.Drawing.Point(44, 60);
            departamento_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            departamento_IDLabel.Name = "departamento_IDLabel";
            departamento_IDLabel.Size = new System.Drawing.Size(119, 17);
            departamento_IDLabel.TabIndex = 0;
            departamento_IDLabel.Text = "Departamento ID:";
            // 
            // btnAñadirDepar
            // 
            this.btnAñadirDepar.Location = new System.Drawing.Point(43, 324);
            this.btnAñadirDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirDepar.Name = "btnAñadirDepar";
            this.btnAñadirDepar.Size = new System.Drawing.Size(76, 28);
            this.btnAñadirDepar.TabIndex = 56;
            this.btnAñadirDepar.Text = "Añadir";
            this.btnAñadirDepar.UseVisualStyleBackColor = true;
            this.btnAñadirDepar.Click += new System.EventHandler(this.BtnAñadirDepar_Click);
            // 
            // btnModificarDepar
            // 
            this.btnModificarDepar.Location = new System.Drawing.Point(365, 324);
            this.btnModificarDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDepar.Name = "btnModificarDepar";
            this.btnModificarDepar.Size = new System.Drawing.Size(93, 28);
            this.btnModificarDepar.TabIndex = 57;
            this.btnModificarDepar.Text = "Modificar";
            this.btnModificarDepar.UseVisualStyleBackColor = true;
            this.btnModificarDepar.Click += new System.EventHandler(this.BtnModificarDepar_Click);
            // 
            // btnGuardarDepar
            // 
            this.btnGuardarDepar.Enabled = false;
            this.btnGuardarDepar.Location = new System.Drawing.Point(127, 324);
            this.btnGuardarDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDepar.Name = "btnGuardarDepar";
            this.btnGuardarDepar.Size = new System.Drawing.Size(224, 28);
            this.btnGuardarDepar.TabIndex = 58;
            this.btnGuardarDepar.Text = "Guardar departamento nuevo";
            this.btnGuardarDepar.UseVisualStyleBackColor = true;
            this.btnGuardarDepar.Click += new System.EventHandler(this.BtnGuardarDepar_Click);
            // 
            // btnGuardarCambiosDepar
            // 
            this.btnGuardarCambiosDepar.Enabled = false;
            this.btnGuardarCambiosDepar.Location = new System.Drawing.Point(467, 324);
            this.btnGuardarCambiosDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambiosDepar.Name = "btnGuardarCambiosDepar";
            this.btnGuardarCambiosDepar.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarCambiosDepar.TabIndex = 59;
            this.btnGuardarCambiosDepar.Text = "Guardar cambios";
            this.btnGuardarCambiosDepar.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosDepar.Click += new System.EventHandler(this.BtnGuardarCambiosDepar_Click);
            // 
            // btnCancelarDepar
            // 
            this.btnCancelarDepar.Enabled = false;
            this.btnCancelarDepar.Location = new System.Drawing.Point(620, 324);
            this.btnCancelarDepar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarDepar.Name = "btnCancelarDepar";
            this.btnCancelarDepar.Size = new System.Drawing.Size(93, 28);
            this.btnCancelarDepar.TabIndex = 60;
            this.btnCancelarDepar.Text = "Cancelar";
            this.btnCancelarDepar.UseVisualStyleBackColor = true;
            this.btnCancelarDepar.Click += new System.EventHandler(this.BtnCancelarDepar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1027, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paises";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(8, 6);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1008, 422);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.AutoScroll = true;
            this.tabPage9.Controls.Add(this.btnCancelarCiudad);
            this.tabPage9.Controls.Add(this.btnGuardarCambiosCiudad);
            this.tabPage9.Controls.Add(this.btnGuardarCiudad);
            this.tabPage9.Controls.Add(this.btnModificarCiudad);
            this.tabPage9.Controls.Add(this.btnAñadirCiudad);
            this.tabPage9.Controls.Add(this.panel2);
            this.tabPage9.Controls.Add(this.vwCiudadesDataGridView);
            this.tabPage9.Controls.Add(this.label2);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(1000, 393);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Ciudades";
            this.tabPage9.UseVisualStyleBackColor = true;
            this.tabPage9.Click += new System.EventHandler(this.TabPage9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ciudades";
            // 
            // vwCiudadesDataGridView
            // 
            this.vwCiudadesDataGridView.AllowUserToAddRows = false;
            this.vwCiudadesDataGridView.AllowUserToDeleteRows = false;
            this.vwCiudadesDataGridView.AutoGenerateColumns = false;
            this.vwCiudadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwCiudadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vwCiudadesDataGridView.DataSource = this.vwCiudadesBindingSource;
            this.vwCiudadesDataGridView.Location = new System.Drawing.Point(28, 94);
            this.vwCiudadesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwCiudadesDataGridView.Name = "vwCiudadesDataGridView";
            this.vwCiudadesDataGridView.ReadOnly = true;
            this.vwCiudadesDataGridView.RowHeadersWidth = 51;
            this.vwCiudadesDataGridView.Size = new System.Drawing.Size(459, 182);
            this.vwCiudadesDataGridView.TabIndex = 7;
            this.vwCiudadesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VwCiudadesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre de ciudad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de ciudad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo de ciudad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo de ciudad";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCodCiudad);
            this.panel2.Controls.Add(codigo_de_ciudadLabel);
            this.panel2.Controls.Add(this.cmbPais);
            this.panel2.Controls.Add(paisLabel);
            this.panel2.Controls.Add(nombre_de_ciudadLabel);
            this.panel2.Controls.Add(this.txtNomCiudad);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(564, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 182);
            this.panel2.TabIndex = 13;
            // 
            // txtNomCiudad
            // 
            this.txtNomCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCiudadesBindingSource, "Nombre de ciudad", true));
            this.txtNomCiudad.Location = new System.Drawing.Point(143, 55);
            this.txtNomCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomCiudad.Name = "txtNomCiudad";
            this.txtNomCiudad.Size = new System.Drawing.Size(160, 22);
            this.txtNomCiudad.TabIndex = 10;
            this.txtNomCiudad.TextChanged += new System.EventHandler(this.Nombre_de_ciudadTextBox_TextChanged);
            this.txtNomCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomCiudad_KeyPress);
            // 
            // nombre_de_ciudadLabel
            // 
            nombre_de_ciudadLabel.AutoSize = true;
            nombre_de_ciudadLabel.Location = new System.Drawing.Point(5, 59);
            nombre_de_ciudadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombre_de_ciudadLabel.Name = "nombre_de_ciudadLabel";
            nombre_de_ciudadLabel.Size = new System.Drawing.Size(128, 17);
            nombre_de_ciudadLabel.TabIndex = 9;
            nombre_de_ciudadLabel.Text = "Nombre de ciudad:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(5, 91);
            paisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(39, 17);
            paisLabel.TabIndex = 11;
            paisLabel.Text = "Pais:";
            // 
            // cmbPais
            // 
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCiudadesBindingSource, "Pais", true));
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwCiudadesBindingSource, "Pais", true));
            this.cmbPais.DataSource = this.paisBindingSource1;
            this.cmbPais.DisplayMember = "Pais_Nombre";
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(143, 87);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(160, 24);
            this.cmbPais.TabIndex = 12;
            this.cmbPais.ValueMember = "Pais_Codigo";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.CmbPais_SelectedIndexChanged);
            this.cmbPais.Click += new System.EventHandler(this.CmbPais_Click);
            // 
            // codigo_de_ciudadLabel
            // 
            codigo_de_ciudadLabel.AutoSize = true;
            codigo_de_ciudadLabel.Location = new System.Drawing.Point(5, 27);
            codigo_de_ciudadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_de_ciudadLabel.Name = "codigo_de_ciudadLabel";
            codigo_de_ciudadLabel.Size = new System.Drawing.Size(122, 17);
            codigo_de_ciudadLabel.TabIndex = 7;
            codigo_de_ciudadLabel.Text = "Codigo de ciudad:";
            // 
            // txtCodCiudad
            // 
            this.txtCodCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCiudadesBindingSource, "Codigo de ciudad", true));
            this.txtCodCiudad.Enabled = false;
            this.txtCodCiudad.Location = new System.Drawing.Point(143, 23);
            this.txtCodCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCiudad.Name = "txtCodCiudad";
            this.txtCodCiudad.Size = new System.Drawing.Size(81, 22);
            this.txtCodCiudad.TabIndex = 8;
            // 
            // btnAñadirCiudad
            // 
            this.btnAñadirCiudad.Location = new System.Drawing.Point(33, 331);
            this.btnAñadirCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirCiudad.Name = "btnAñadirCiudad";
            this.btnAñadirCiudad.Size = new System.Drawing.Size(83, 28);
            this.btnAñadirCiudad.TabIndex = 40;
            this.btnAñadirCiudad.Text = "Añadir";
            this.btnAñadirCiudad.UseVisualStyleBackColor = true;
            this.btnAñadirCiudad.Click += new System.EventHandler(this.BtnAñadirCiudad_Click);
            // 
            // btnModificarCiudad
            // 
            this.btnModificarCiudad.Location = new System.Drawing.Point(315, 331);
            this.btnModificarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarCiudad.Name = "btnModificarCiudad";
            this.btnModificarCiudad.Size = new System.Drawing.Size(100, 28);
            this.btnModificarCiudad.TabIndex = 41;
            this.btnModificarCiudad.Text = "Modificar";
            this.btnModificarCiudad.UseVisualStyleBackColor = true;
            this.btnModificarCiudad.Click += new System.EventHandler(this.BtnModificarCiudad_Click);
            // 
            // btnGuardarCiudad
            // 
            this.btnGuardarCiudad.Enabled = false;
            this.btnGuardarCiudad.Location = new System.Drawing.Point(124, 331);
            this.btnGuardarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCiudad.Name = "btnGuardarCiudad";
            this.btnGuardarCiudad.Size = new System.Drawing.Size(183, 28);
            this.btnGuardarCiudad.TabIndex = 42;
            this.btnGuardarCiudad.Text = "Guardar ciudad nueva";
            this.btnGuardarCiudad.UseVisualStyleBackColor = true;
            this.btnGuardarCiudad.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnGuardarCambiosCiudad
            // 
            this.btnGuardarCambiosCiudad.Enabled = false;
            this.btnGuardarCambiosCiudad.Location = new System.Drawing.Point(416, 331);
            this.btnGuardarCambiosCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambiosCiudad.Name = "btnGuardarCambiosCiudad";
            this.btnGuardarCambiosCiudad.Size = new System.Drawing.Size(145, 28);
            this.btnGuardarCambiosCiudad.TabIndex = 43;
            this.btnGuardarCambiosCiudad.Text = "Guardar cambios";
            this.btnGuardarCambiosCiudad.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosCiudad.Click += new System.EventHandler(this.BtnGuardarCambiosCiudad_Click);
            // 
            // btnCancelarCiudad
            // 
            this.btnCancelarCiudad.Enabled = false;
            this.btnCancelarCiudad.Location = new System.Drawing.Point(569, 331);
            this.btnCancelarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarCiudad.Name = "btnCancelarCiudad";
            this.btnCancelarCiudad.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarCiudad.TabIndex = 44;
            this.btnCancelarCiudad.Text = "Cancelar";
            this.btnCancelarCiudad.UseVisualStyleBackColor = true;
            this.btnCancelarCiudad.Click += new System.EventHandler(this.BtnCancelarCiudad_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btnCancelar);
            this.tabPage8.Controls.Add(this.btnGuardarCam);
            this.tabPage8.Controls.Add(this.btnGuardarPa);
            this.tabPage8.Controls.Add(this.btnModificar);
            this.tabPage8.Controls.Add(this.btnAñadir);
            this.tabPage8.Controls.Add(this.panel1);
            this.tabPage8.Controls.Add(this.paisDataGridView);
            this.tabPage8.Controls.Add(this.lblPaises);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(1000, 393);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Pais";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.TabPage8_Click);
            // 
            // lblPaises
            // 
            this.lblPaises.AutoSize = true;
            this.lblPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaises.Location = new System.Drawing.Point(416, 16);
            this.lblPaises.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaises.Name = "lblPaises";
            this.lblPaises.Size = new System.Drawing.Size(96, 31);
            this.lblPaises.TabIndex = 6;
            this.lblPaises.Text = "Paises";
            // 
            // paisDataGridView
            // 
            this.paisDataGridView.AllowUserToAddRows = false;
            this.paisDataGridView.AllowUserToDeleteRows = false;
            this.paisDataGridView.AutoGenerateColumns = false;
            this.paisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.paisDataGridView.DataSource = this.paisBindingSource;
            this.paisDataGridView.Location = new System.Drawing.Point(61, 84);
            this.paisDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.paisDataGridView.Name = "paisDataGridView";
            this.paisDataGridView.ReadOnly = true;
            this.paisDataGridView.RowHeadersWidth = 51;
            this.paisDataGridView.Size = new System.Drawing.Size(324, 208);
            this.paisDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pais_Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pais_Codigo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Codigo de Pais";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(pais_CodigoLabel);
            this.panel1.Controls.Add(this.txtCodPai);
            this.panel1.Controls.Add(pais_NombreLabel);
            this.panel1.Controls.Add(this.txtNomPais);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(488, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 76);
            this.panel1.TabIndex = 8;
            // 
            // txtNomPais
            // 
            this.txtNomPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "Pais_Nombre", true));
            this.txtNomPais.Location = new System.Drawing.Point(125, 42);
            this.txtNomPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomPais.Name = "txtNomPais";
            this.txtNomPais.Size = new System.Drawing.Size(132, 22);
            this.txtNomPais.TabIndex = 9;
            this.txtNomPais.TextChanged += new System.EventHandler(this.TxtNomPais_TextChanged);
            this.txtNomPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomPais_KeyPress);
            // 
            // pais_NombreLabel
            // 
            pais_NombreLabel.AutoSize = true;
            pais_NombreLabel.Location = new System.Drawing.Point(9, 46);
            pais_NombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pais_NombreLabel.Name = "pais_NombreLabel";
            pais_NombreLabel.Size = new System.Drawing.Size(109, 17);
            pais_NombreLabel.TabIndex = 8;
            pais_NombreLabel.Text = "Nombre de Pais";
            // 
            // txtCodPai
            // 
            this.txtCodPai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "Pais_Codigo", true));
            this.txtCodPai.Enabled = false;
            this.txtCodPai.Location = new System.Drawing.Point(125, 10);
            this.txtCodPai.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPai.Name = "txtCodPai";
            this.txtCodPai.ReadOnly = true;
            this.txtCodPai.Size = new System.Drawing.Size(81, 22);
            this.txtCodPai.TabIndex = 7;
            // 
            // pais_CodigoLabel
            // 
            pais_CodigoLabel.AutoSize = true;
            pais_CodigoLabel.Location = new System.Drawing.Point(9, 14);
            pais_CodigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pais_CodigoLabel.Name = "pais_CodigoLabel";
            pais_CodigoLabel.Size = new System.Drawing.Size(107, 17);
            pais_CodigoLabel.TabIndex = 6;
            pais_CodigoLabel.Text = "Codigo de Pais:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(119, 348);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(76, 28);
            this.btnAñadir.TabIndex = 35;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(400, 348);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 28);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnGuardarPa
            // 
            this.btnGuardarPa.Enabled = false;
            this.btnGuardarPa.Location = new System.Drawing.Point(209, 348);
            this.btnGuardarPa.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPa.Name = "btnGuardarPa";
            this.btnGuardarPa.Size = new System.Drawing.Size(176, 28);
            this.btnGuardarPa.TabIndex = 37;
            this.btnGuardarPa.Text = "Guardar pais nuevo";
            this.btnGuardarPa.UseVisualStyleBackColor = true;
            this.btnGuardarPa.Click += new System.EventHandler(this.BtnGuardarPa_Click);
            // 
            // btnGuardarCam
            // 
            this.btnGuardarCam.Enabled = false;
            this.btnGuardarCam.Location = new System.Drawing.Point(501, 348);
            this.btnGuardarCam.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCam.Name = "btnGuardarCam";
            this.btnGuardarCam.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarCam.TabIndex = 38;
            this.btnGuardarCam.Text = "Guardar cambios";
            this.btnGuardarCam.UseVisualStyleBackColor = true;
            this.btnGuardarCam.Click += new System.EventHandler(this.BtnGuardarCam_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(655, 348);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 28);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // tabPayCi
            // 
            this.tabPayCi.Controls.Add(this.tabPage1);
            this.tabPayCi.Controls.Add(this.tabPage4);
            this.tabPayCi.Controls.Add(this.tabPage2);
            this.tabPayCi.Location = new System.Drawing.Point(16, 74);
            this.tabPayCi.Margin = new System.Windows.Forms.Padding(4);
            this.tabPayCi.Name = "tabPayCi";
            this.tabPayCi.SelectedIndex = 0;
            this.tabPayCi.Size = new System.Drawing.Size(1035, 465);
            this.tabPayCi.TabIndex = 1;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabPayCi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCiudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rol_SistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_RolesDeparBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcmbPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripSubcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCmbCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodDepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtDeparDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRolDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCmbDepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCmbRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubcategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoCategoriaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubcategoriaDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_RolesDeparDataGridView)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.btnAñadirRDepar.ResumeLayout(false);
            this.btnAñadirRDepar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCiudadesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPayCi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw ciudades binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwCiudadesBindingSource;
        /// <summary>
        /// The vw ciudades table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwCiudadesTableAdapter vwCiudadesTableAdapter;
        /// <summary>
        /// The table adapter manager
        /// </summary>
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        /// <summary>
        /// The pais table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        /// <summary>
        /// The pais binding source
        /// </summary>
        private System.Windows.Forms.BindingSource paisBindingSource;
        /// <summary>
        /// The error pais
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorPais;
        /// <summary>
        /// The pais binding source1
        /// </summary>
        private System.Windows.Forms.BindingSource paisBindingSource1;
        /// <summary>
        /// The error nom ciudad
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorNomCiudad;
        /// <summary>
        /// The errorcmb pais
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorcmbPais;
        /// <summary>
        /// The tacoma database data set binding source
        /// </summary>
        private System.Windows.Forms.BindingSource tacomaDBDataSetBindingSource;
        /// <summary>
        /// The error descrip subcat
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorDescripSubcat;
        /// <summary>
        /// The error CMB categoria
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCmbCategoria;
        /// <summary>
        /// The estado binding source
        /// </summary>
        private System.Windows.Forms.BindingSource estadoBindingSource;
        /// <summary>
        /// The estado table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        /// <summary>
        /// The rol sistema binding source
        /// </summary>
        private System.Windows.Forms.BindingSource rol_SistemaBindingSource;
        /// <summary>
        /// The rol sistema table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.Rol_SistemaTableAdapter rol_SistemaTableAdapter;
        /// <summary>
        /// The error descrip rol
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorDescripRol;
        /// <summary>
        /// The departamento binding source
        /// </summary>
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        /// <summary>
        /// The departamento table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        /// <summary>
        /// The error cod depar
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCodDepar;
        /// <summary>
        /// The errortxt depar descrip
        /// </summary>
        private System.Windows.Forms.ErrorProvider errortxtDeparDescrip;
        /// <summary>
        /// The roles binding source
        /// </summary>
        private System.Windows.Forms.BindingSource rolesBindingSource;
        /// <summary>
        /// The roles table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        /// <summary>
        /// The error rol descrip
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorRolDescrip;
        /// <summary>
        /// The vw roles depar binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vw_RolesDeparBindingSource;
        /// <summary>
        /// The vw roles depar table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.vw_RolesDeparTableAdapter vw_RolesDeparTableAdapter;
        /// <summary>
        /// The error CMB depar
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCmbDepar;
        /// <summary>
        /// The error CMB rol
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCmbRol;
        /// <summary>
        /// The vw subcategoria binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwSubcategoriaBindingSource;
        /// <summary>
        /// The vw subcategoria table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwSubcategoriaTableAdapter vwSubcategoriaTableAdapter;
        /// <summary>
        /// The producto categoria binding source
        /// </summary>
        private System.Windows.Forms.BindingSource productoCategoriaBindingSource;
        /// <summary>
        /// The producto categoria table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.Producto_CategoriaTableAdapter producto_CategoriaTableAdapter;
        /// <summary>
        /// The tab pay ci
        /// </summary>
        private System.Windows.Forms.TabControl tabPayCi;
        /// <summary>
        /// The tab page1
        /// </summary>
        private System.Windows.Forms.TabPage tabPage1;
        /// <summary>
        /// The tab control2
        /// </summary>
        private System.Windows.Forms.TabControl tabControl2;
        /// <summary>
        /// The tab page8
        /// </summary>
        private System.Windows.Forms.TabPage tabPage8;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        /// <summary>
        /// The BTN guardar cam
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCam;
        /// <summary>
        /// The BTN guardar pa
        /// </summary>
        private System.Windows.Forms.Button btnGuardarPa;
        /// <summary>
        /// The BTN modificar
        /// </summary>
        private System.Windows.Forms.Button btnModificar;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The text cod pai
        /// </summary>
        private System.Windows.Forms.TextBox txtCodPai;
        /// <summary>
        /// The text nom pais
        /// </summary>
        private System.Windows.Forms.TextBox txtNomPais;
        /// <summary>
        /// The pais data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView paisDataGridView;
        /// <summary>
        /// The data grid view text box column4
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        /// <summary>
        /// The data grid view text box column5
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        /// <summary>
        /// The label paises
        /// </summary>
        private System.Windows.Forms.Label lblPaises;
        /// <summary>
        /// The tab page9
        /// </summary>
        private System.Windows.Forms.TabPage tabPage9;
        /// <summary>
        /// The BTN cancelar ciudad
        /// </summary>
        private System.Windows.Forms.Button btnCancelarCiudad;
        /// <summary>
        /// The BTN guardar cambios ciudad
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCambiosCiudad;
        /// <summary>
        /// The BTN guardar ciudad
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCiudad;
        /// <summary>
        /// The BTN modificar ciudad
        /// </summary>
        private System.Windows.Forms.Button btnModificarCiudad;
        /// <summary>
        /// The BTN añadir ciudad
        /// </summary>
        private System.Windows.Forms.Button btnAñadirCiudad;
        /// <summary>
        /// The panel2
        /// </summary>
        private System.Windows.Forms.Panel panel2;
        /// <summary>
        /// The text cod ciudad
        /// </summary>
        private System.Windows.Forms.TextBox txtCodCiudad;
        /// <summary>
        /// The CMB pais
        /// </summary>
        private System.Windows.Forms.ComboBox cmbPais;
        /// <summary>
        /// The text nom ciudad
        /// </summary>
        private System.Windows.Forms.TextBox txtNomCiudad;
        /// <summary>
        /// The vw ciudades data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwCiudadesDataGridView;
        /// <summary>
        /// The data grid view text box column1
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        /// <summary>
        /// The data grid view text box column2
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        /// <summary>
        /// The data grid view text box column3
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The tab page4
        /// </summary>
        private System.Windows.Forms.TabPage tabPage4;
        /// <summary>
        /// The tab control1
        /// </summary>
        private System.Windows.Forms.TabControl tabControl1;
        /// <summary>
        /// The tab page5
        /// </summary>
        private System.Windows.Forms.TabPage tabPage5;
        /// <summary>
        /// The BTN cancelar depar
        /// </summary>
        private System.Windows.Forms.Button btnCancelarDepar;
        /// <summary>
        /// The BTN guardar cambios depar
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCambiosDepar;
        /// <summary>
        /// The BTN guardar depar
        /// </summary>
        private System.Windows.Forms.Button btnGuardarDepar;
        /// <summary>
        /// The BTN modificar depar
        /// </summary>
        private System.Windows.Forms.Button btnModificarDepar;
        /// <summary>
        /// The BTN añadir depar
        /// </summary>
        private System.Windows.Forms.Button btnAñadirDepar;
        /// <summary>
        /// The panel6
        /// </summary>
        private System.Windows.Forms.Panel panel6;
        /// <summary>
        /// The text cod depar
        /// </summary>
        private System.Windows.Forms.TextBox txtCodDepar;
        /// <summary>
        /// The text depar nom
        /// </summary>
        private System.Windows.Forms.TextBox txtDeparNom;
        /// <summary>
        /// The departamento data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView departamentoDataGridView;
        /// <summary>
        /// The data grid view text box column13
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        /// <summary>
        /// The data grid view text box column14
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        /// <summary>
        /// The label7
        /// </summary>
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// The BTN añadir r depar
        /// </summary>
        private System.Windows.Forms.TabPage btnAñadirRDepar;
        /// <summary>
        /// The BTN cancelar r depar
        /// </summary>
        private System.Windows.Forms.Button btnCancelarRDepar;
        /// <summary>
        /// The BTN guardar cambios r depar
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCambiosRDepar;
        /// <summary>
        /// The BTN guardar r depar
        /// </summary>
        private System.Windows.Forms.Button btnGuardarRDepar;
        /// <summary>
        /// The BTN modificar r depar
        /// </summary>
        private System.Windows.Forms.Button btnModificarRDepar;
        /// <summary>
        /// The BTN añadir rol depar
        /// </summary>
        private System.Windows.Forms.Button btnAñadirRolDepar;
        /// <summary>
        /// The panel7
        /// </summary>
        private System.Windows.Forms.Panel panel7;
        /// <summary>
        /// The text cod rol
        /// </summary>
        private System.Windows.Forms.TextBox txtCodRol;
        /// <summary>
        /// The text rol nom
        /// </summary>
        private System.Windows.Forms.TextBox txtRolNom;
        /// <summary>
        /// The roles data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView rolesDataGridView;
        /// <summary>
        /// The data grid view text box column15
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        /// <summary>
        /// The data grid view text box column16
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        /// <summary>
        /// The label8
        /// </summary>
        private System.Windows.Forms.Label label8;
        /// <summary>
        /// The tab page7
        /// </summary>
        private System.Windows.Forms.TabPage tabPage7;
        /// <summary>
        /// The BTN eliminar rolen depar
        /// </summary>
        private System.Windows.Forms.Button btnEliminarRolenDepar;
        /// <summary>
        /// The BTN cancelar rolen depar
        /// </summary>
        private System.Windows.Forms.Button btnCancelarRolenDepar;
        /// <summary>
        /// The BTN guardar rolen depar
        /// </summary>
        private System.Windows.Forms.Button btnGuardarRolenDepar;
        /// <summary>
        /// The BTN añadir rolen depar
        /// </summary>
        private System.Windows.Forms.Button btnAñadirRolenDepar;
        /// <summary>
        /// The panel8
        /// </summary>
        private System.Windows.Forms.Panel panel8;
        /// <summary>
        /// The CMB depar
        /// </summary>
        private System.Windows.Forms.ComboBox cmbDepar;
        /// <summary>
        /// The CMB rol
        /// </summary>
        private System.Windows.Forms.ComboBox cmbRol;
        /// <summary>
        /// The vw roles depar data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vw_RolesDeparDataGridView;
        /// <summary>
        /// The data grid view text box column17
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        /// <summary>
        /// The data grid view text box column18
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        /// <summary>
        /// The label9
        /// </summary>
        private System.Windows.Forms.Label label9;
        /// <summary>
        /// The tab page2
        /// </summary>
        private System.Windows.Forms.TabPage tabPage2;
        /// <summary>
        /// The vw subcategoria data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwSubcategoriaDataGridView;
        /// <summary>
        /// The data grid view text box column6
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        /// <summary>
        /// The data grid view text box column7
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        /// <summary>
        /// The data grid view text box column8
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        /// <summary>
        /// The BTN cancelar subcat
        /// </summary>
        private System.Windows.Forms.Button btnCancelarSubcat;
        /// <summary>
        /// The BTN guardar cambios subcat
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCambiosSubcat;
        /// <summary>
        /// The BTN guardar subcat
        /// </summary>
        private System.Windows.Forms.Button btnGuardarSubcat;
        /// <summary>
        /// The BTN modificar subcat
        /// </summary>
        private System.Windows.Forms.Button btnModificarSubcat;
        /// <summary>
        /// The BTN añadir subcat
        /// </summary>
        private System.Windows.Forms.Button btnAñadirSubcat;
        /// <summary>
        /// The panel3
        /// </summary>
        private System.Windows.Forms.Panel panel3;
        /// <summary>
        /// The text cod subcat
        /// </summary>
        private System.Windows.Forms.TextBox txtCodSubcat;
        /// <summary>
        /// The text descrip subcat
        /// </summary>
        private System.Windows.Forms.TextBox txtDescripSubcat;
        /// <summary>
        /// The CMB categoria
        /// </summary>
        private System.Windows.Forms.ComboBox cmbCategoria;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
    }
}