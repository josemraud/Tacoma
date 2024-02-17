// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-02-2019
// ***********************************************************************
// <copyright file="MateriaPrima.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class frmInventarioMateriaP.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class frmInventarioMateriaP
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
            System.Windows.Forms.Label codigo_del_productoLabel;
            System.Windows.Forms.Label nombre_del_productoLabel;
            System.Windows.Forms.Label cantidad_disponibleLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.inventarioMateriaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.errorCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.inventarioMateriaPrimaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.InventarioMateriaPrimaTableAdapter();
            this.inventarioMateriaPrimaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigo_del_productoLabel = new System.Windows.Forms.Label();
            nombre_del_productoLabel = new System.Windows.Forms.Label();
            cantidad_disponibleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioMateriaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioMateriaPrimaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_del_productoLabel
            // 
            codigo_del_productoLabel.AutoSize = true;
            codigo_del_productoLabel.Location = new System.Drawing.Point(463, 89);
            codigo_del_productoLabel.Name = "codigo_del_productoLabel";
            codigo_del_productoLabel.Size = new System.Drawing.Size(105, 13);
            codigo_del_productoLabel.TabIndex = 2;
            codigo_del_productoLabel.Text = "Codigo del producto:";
            // 
            // nombre_del_productoLabel
            // 
            nombre_del_productoLabel.AutoSize = true;
            nombre_del_productoLabel.Location = new System.Drawing.Point(463, 115);
            nombre_del_productoLabel.Name = "nombre_del_productoLabel";
            nombre_del_productoLabel.Size = new System.Drawing.Size(109, 13);
            nombre_del_productoLabel.TabIndex = 4;
            nombre_del_productoLabel.Text = "Nombre del producto:";
            // 
            // cantidad_disponibleLabel
            // 
            cantidad_disponibleLabel.AutoSize = true;
            cantidad_disponibleLabel.Location = new System.Drawing.Point(463, 141);
            cantidad_disponibleLabel.Name = "cantidad_disponibleLabel";
            cantidad_disponibleLabel.Size = new System.Drawing.Size(102, 13);
            cantidad_disponibleLabel.TabIndex = 6;
            cantidad_disponibleLabel.Text = "Cantidad disponible:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario Materia Prima";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // inventarioMateriaPrimaBindingSource
            // 
            this.inventarioMateriaPrimaBindingSource.DataMember = "InventarioMateriaPrima";
            this.inventarioMateriaPrimaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCod
            // 
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioMateriaPrimaBindingSource, "Codigo del producto", true));
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(578, 86);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioMateriaPrimaBindingSource, "Nombre del producto", true));
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(578, 112);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtcant
            // 
            this.txtcant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioMateriaPrimaBindingSource, "Cantidad disponible", true));
            this.txtcant.Location = new System.Drawing.Point(578, 138);
            this.txtcant.MaxLength = 4;
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 1;
            this.txtcant.TextChanged += new System.EventHandler(this.Txtcant_TextChanged);
            this.txtcant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcant_KeyPress);
            this.txtcant.Validating += new System.ComponentModel.CancelEventHandler(this.Txtcant_Validating);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(602, 274);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // errorCantidad
            // 
            this.errorCantidad.ContainerControl = this;
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
            // inventarioMateriaPrimaTableAdapter
            // 
            this.inventarioMateriaPrimaTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioMateriaPrimaDataGridView
            // 
            this.inventarioMateriaPrimaDataGridView.AllowUserToAddRows = false;
            this.inventarioMateriaPrimaDataGridView.AllowUserToDeleteRows = false;
            this.inventarioMateriaPrimaDataGridView.AutoGenerateColumns = false;
            this.inventarioMateriaPrimaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioMateriaPrimaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.inventarioMateriaPrimaDataGridView.DataSource = this.inventarioMateriaPrimaBindingSource;
            this.inventarioMateriaPrimaDataGridView.Location = new System.Drawing.Point(102, 86);
            this.inventarioMateriaPrimaDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inventarioMateriaPrimaDataGridView.Name = "inventarioMateriaPrimaDataGridView";
            this.inventarioMateriaPrimaDataGridView.ReadOnly = true;
            this.inventarioMateriaPrimaDataGridView.RowHeadersWidth = 51;
            this.inventarioMateriaPrimaDataGridView.RowTemplate.Height = 24;
            this.inventarioMateriaPrimaDataGridView.Size = new System.Drawing.Size(314, 210);
            this.inventarioMateriaPrimaDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo del producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo del producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre del producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre del producto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad disponible";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad disponible";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // frmInventarioMateriaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventarioMateriaPrimaDataGridView);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(codigo_del_productoLabel);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(nombre_del_productoLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(cantidad_disponibleLabel);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioMateriaP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmInventarioMateriaP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioMateriaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioMateriaPrimaDataGridView)).EndInit();
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
        /// The inventario materia prima binding source
        /// </summary>
        private System.Windows.Forms.BindingSource inventarioMateriaPrimaBindingSource;
        /// <summary>
        /// The table adapter manager
        /// </summary>
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        /// <summary>
        /// The text cod
        /// </summary>
        private System.Windows.Forms.TextBox txtCod;
        /// <summary>
        /// The text nom
        /// </summary>
        private System.Windows.Forms.TextBox txtNom;
        /// <summary>
        /// The txtcant
        /// </summary>
        private System.Windows.Forms.TextBox txtcant;
        /// <summary>
        /// The BTN actualizar
        /// </summary>
        private System.Windows.Forms.Button btnActualizar;
        /// <summary>
        /// The error cantidad
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCantidad;
        /// <summary>
        /// The inventario materia prima data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView inventarioMateriaPrimaDataGridView;
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
        /// The inventario materia prima table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.InventarioMateriaPrimaTableAdapter inventarioMateriaPrimaTableAdapter;
    }
}