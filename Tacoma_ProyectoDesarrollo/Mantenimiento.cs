// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-02-2019
//
// Last Modified By : pepit
// Last Modified On : 12-12-2019
// ***********************************************************************
// <copyright file="Mantenimiento.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Mantenimiento.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Mantenimiento : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mantenimiento"/> class.
        /// </summary>
        public Mantenimiento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Mantenimiento control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Producto_Categoria' Puede moverla o quitarla según sea necesario.
            this.producto_CategoriaTableAdapter.Fill(this.tacomaDBDataSet.Producto_Categoria);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwSubcategoria' Puede moverla o quitarla según sea necesario.
            this.vwSubcategoriaTableAdapter.Fill(this.tacomaDBDataSet.VwSubcategoria);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet1.Producto_Categoria' Puede moverla o quitarla según sea necesario.
            //this.producto_CategoriaTableAdapter.Fill(this.tacomaDBDataSet1.Producto_Categoria);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.vw_RolesDepar' Puede moverla o quitarla según sea necesario.
            this.vw_RolesDeparTableAdapter.Fill(this.tacomaDBDataSet.vw_RolesDepar);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.tacomaDBDataSet.Roles);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.tacomaDBDataSet.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Rol_Sistema' Puede moverla o quitarla según sea necesario.
            this.rol_SistemaTableAdapter.Fill(this.tacomaDBDataSet.Rol_Sistema);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this.tacomaDBDataSet.Estado);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Producto_Categoria' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.tacomaDBDataSet.Pais);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCiudades' Puede moverla o quitarla según sea necesario.
            this.vwCiudadesTableAdapter.Fill(this.tacomaDBDataSet.VwCiudades);
            
            CargarCiudadesdgv();
            CargarSubcatdgv();
            CargarRolxDepar();
        }
        /// <summary>
        /// The man
        /// </summary>
        MantenimientoMetodos man = new MantenimientoMetodos();
        /// <summary>
        /// Cargars the ciudadesdgv.
        /// </summary>
        public void CargarCiudadesdgv()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwCiudades", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwCiudadesDataGridView.DataSource = dt;
            vwCiudadesBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Cargars the subcatdgv.
        /// </summary>
        public void CargarSubcatdgv()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwSubcategoria", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwSubcategoriaDataGridView.DataSource = dt;
            vwSubcategoriaBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Cargars the rolx depar.
        /// </summary>
        public void CargarRolxDepar()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * from vw_RolesDepar ", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vw_RolesDeparDataGridView.DataSource = dt;
            vw_RolesDeparBindingSource.DataSource = dt;
        }
        /// <summary>
        /// Handles the Click event of the Label1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Paint event of the SplitContainer1_Panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the TabPage7 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Paint event of the SplitContainer2_Panel2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void SplitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Handles the RefreshItems event of the VwCiudadesBindingNavigator control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VwCiudadesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the TabPage9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage9_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the TabPage8 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage8_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the BtnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            this.paisBindingSource.AddNew();
            btnAñadir.Enabled = false;
            btnGuardarPa.Enabled = true;
            panel1.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarPa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarPa_Click(object sender, EventArgs e)
        {
            man.ValidarPais(txtNomPais.Text);

            if(txtNomPais.Text=="")
            {
                errorPais.SetError(txtNomPais, "Campo Obligatorio");
            }

            if (CompartirDatos.codPais == 1)
            {
                MessageBox.Show("El pais " + txtNomPais.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNomPais.Text=="")
            {
                MessageBox.Show("Datos incompletos o incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Añadir_Pais(txtNomPais.Text);
                this.paisDataGridView.Refresh();
                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardarPa.Enabled = false;
                btnCancelar.Enabled = false;
                panel1.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtNomPais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtNomPais_TextChanged(object sender, EventArgs e)
        {
            errorPais.Clear();
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtNomPais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtNomPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnModificar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnAñadir.Enabled = false;
            btnGuardarPa.Enabled = false;
            btnGuardarCam.Enabled = true;
            btnCancelar.Enabled = true;
            panel1.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCam control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCam_Click(object sender, EventArgs e)
        {
            if (txtNomPais.Text == "")
            {
                errorPais.SetError(txtNomPais, "Campo Obligatorio");
            }

            if (CompartirDatos.codPais == 1)
            {
                MessageBox.Show("El pais " + txtNomPais.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNomPais.Text == "")
            {
                MessageBox.Show("Datos incompletos o incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Actualizar_Pais(txtNomPais.Text,int.Parse(txtCodPai.Text));
                this.paisDataGridView.Refresh();

                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardarPa.Enabled = false;
                panel1.Enabled = false;
                btnGuardarCam.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the Button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button3_Click(object sender, EventArgs e)
        {
            man.ValidarCiudad(txtNomCiudad.Text);
           

            if(this.txtNomCiudad.Text=="")
            {
                errorNomCiudad.SetError(txtNomCiudad, "Campo Obligatorio");
            }
            if(this.cmbPais.Text=="")
            {
                errorcmbPais.SetError(cmbPais, "Campo Obligatorio");
            }

            if (CompartirDatos.codCiu == 1)
            {
                MessageBox.Show("La ciudad " + txtNomCiudad.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (this.txtNomCiudad.Text == "" || this.cmbPais.Text == "")
            {
                MessageBox.Show("Datos incompletos o incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Añadir_Ciudad(this.txtNomCiudad.Text, int.Parse(this.cmbPais.SelectedValue.ToString()));
                this.vwCiudadesDataGridView.Refresh();
                btnAñadirCiudad.Enabled = true;
                btnModificarCiudad.Enabled = true;
                btnGuardarCiudad.Enabled = false;
                btnCancelarCiudad.Enabled = false;
                panel2.Enabled = false;
                CargarCiudadesdgv();
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnAñadirCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadirCiudad_Click(object sender, EventArgs e)
        {
            this.vwCiudadesBindingSource.AddNew();
            this.btnAñadirCiudad.Enabled = false;
            this.btnGuardarCiudad.Enabled = true;
            panel2.Enabled = true;
            this.btnModificarCiudad.Enabled = false;
            this.btnCancelarCiudad.Enabled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the Nombre_de_ciudadTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Nombre_de_ciudadTextBox_TextChanged(object sender, EventArgs e)
        {
            errorNomCiudad.Clear();
        }

        /// <summary>
        /// Handles the Click event of the BtnModificarCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificarCiudad_Click(object sender, EventArgs e)
        {
            btnModificarCiudad.Enabled = false;
            btnAñadirCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = false;
            btnGuardarCambiosCiudad.Enabled = true;
            btnCancelarCiudad.Enabled = true;
            panel2.Enabled = true;

        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCambiosCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCambiosCiudad_Click(object sender, EventArgs e)
        {
            

            man.ValidarCiudad(txtNomCiudad.Text);

            if (this.txtNomCiudad.Text == "")
            {
                errorNomCiudad.SetError(txtNomCiudad, "Campo Obligatorio");
            }

            if (CompartirDatos.codCiu == 1)
            {
                MessageBox.Show("La ciudad " + txtNomCiudad.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (this.txtNomCiudad.Text == "" )
            {
                MessageBox.Show("Datos incompletos o incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Actualizar_Ciudad(this.txtNomCiudad.Text, int.Parse(this.cmbPais.SelectedValue.ToString()),int.Parse(this.txtCodCiudad.Text));
                this.vwCiudadesDataGridView.Refresh();
                btnAñadirCiudad.Enabled = true;
                btnModificarCiudad.Enabled = true;
                btnGuardarCiudad.Enabled = false;
                btnCancelarCiudad.Enabled = false;
                panel2.Enabled = false;
                CargarCiudadesdgv();
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelarCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelarCiudad_Click(object sender, EventArgs e)
        {
            this.vwCiudadesBindingSource.CancelEdit();
            this.CargarCiudadesdgv();
            panel2.Enabled = false;
            btnGuardarCiudad.Enabled = false;
            btnAñadirCiudad.Enabled = true;
            btnGuardarCambiosCiudad.Enabled = false;
            btnModificarCiudad.Enabled = true;
            btnCancelarCiudad.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.paisBindingSource.CancelEdit();
           
            btnGuardarPa.Enabled = false;
            btnAñadir.Enabled = true;
            btnGuardarCam.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;

        }
        /// <summary>
        /// Cargars the paises.
        /// </summary>
        public void CargarPaises()
        {

            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM Pais", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            this.cmbPais.ValueMember = "Pais_Codigo";
            this.cmbPais.DisplayMember = "Pais_Nombre";
            this.cmbPais.DataSource = dt;
        }

        /// <summary>
        /// Handles the Click event of the CmbPais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbPais_Click(object sender, EventArgs e)
        {
            this.CargarPaises();
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the BtnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbBusqueda control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the TabPage11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage11_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarSubcat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarSubcat_Click(object sender, EventArgs e)
        {
            if (this.txtDescripSubcat.Text == "")
            {
                errorDescripSubcat.SetError(txtDescripSubcat, "Campo obligatorio");
            }
            if(this.cmbCategoria.Text=="")
            {
                errorCmbCategoria.SetError(cmbCategoria, "Campo obligatorio");
            }
            if(this.txtDescripSubcat.Text == ""|| this.cmbCategoria.Text == "")
            {
                MessageBox.Show("Campos incompletos o incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Añadir_Subcategoria(this.txtDescripSubcat.Text, int.Parse(this.cmbCategoria.SelectedValue.ToString()));
                this.vwSubcategoriaDataGridView.Refresh();
                btnAñadirSubcat.Enabled = true;
                btnModificarSubcat.Enabled = true;
                btnGuardarSubcat.Enabled = false;
                btnCancelarSubcat.Enabled = false;
                panel3.Enabled = false;
                //CargarSubcatdgv();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbPais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorcmbPais.Clear();
        }

        /// <summary>
        /// Handles the Click event of the BtnModificarSubcat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificarSubcat_Click(object sender, EventArgs e)
        {
            btnModificarSubcat.Enabled = false;
            btnAñadirSubcat.Enabled = false;
            btnGuardarSubcat.Enabled = false;
            btnGuardarCambiosSubcat.Enabled = true;
            btnCancelarSubcat.Enabled = true;
            panel3.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCambiosSubcat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCambiosSubcat_Click(object sender, EventArgs e)
        {
            if (this.txtDescripSubcat.Text == "")
            {
                errorDescripSubcat.SetError(txtDescripSubcat, "Campo obligatorio");
            }
           
            if (this.txtDescripSubcat.Text == "" )
            {
                MessageBox.Show("Campos incompletos o incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Actualizar_Subcategoria(this.txtDescripSubcat.Text, int.Parse(this.cmbCategoria.SelectedValue.ToString()),
                    int.Parse(txtCodSubcat.Text));
                this.vwSubcategoriaDataGridView.Refresh();
                btnAñadirSubcat.Enabled = true;
                btnModificarSubcat.Enabled = true;
                btnGuardarSubcat.Enabled = false;
                btnCancelarSubcat.Enabled = false;
                panel3.Enabled = false;
                //this.CargarSubcatdgv();
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtDescripSubcat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtDescripSubcat_TextChanged(object sender, EventArgs e)
        {
            errorDescripSubcat.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbCategoria control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorCmbCategoria.Clear();
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelarSubcat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelarSubcat_Click(object sender, EventArgs e)
        {
            this.vwSubcategoriaBindingSource.CancelEdit();
            panel3.Enabled = false;
            btnGuardarSubcat.Enabled = false;
            btnAñadirSubcat.Enabled = true;
            btnGuardarCambiosSubcat.Enabled = false;
            btnModificarSubcat.Enabled = true;
            btnCancelarSubcat.Enabled = false;
            //this.CargarSubcatdgv();
        }

        /// <summary>
        /// Handles the Click event of the TabPage2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Paint event of the SplitContainer3_Panel2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void SplitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Handles the SplitterMoved event of the SplitContainer3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SplitterEventArgs"/> instance containing the event data.</param>
        private void SplitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        /// <summary>
        /// Handles the CellContentClick event of the EstadoDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void EstadoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Paint event of the Panel4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }




        /// <summary>
        /// Handles the KeyPress event of the TxtNomCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtNomCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtDescripSubcat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtDescripSubcat_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the Descripcion_RSTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Descripcion_RSTextBox_TextChanged(object sender, EventArgs e)
        {
            errorDescripRol.Clear();
        }

        /// <summary>
        /// Handles the KeyPress event of the Descripcion_RSTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void Descripcion_RSTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }


        /// <summary>
        /// Handles the Click event of the BtnAñadirDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadirDepar_Click(object sender, EventArgs e)
        {
            this.departamentoBindingSource.AddNew();
            this.btnAñadirDepar.Enabled = false;
            this.btnGuardarDepar.Enabled = true;
            panel6.Enabled = true;
            this.btnModificarDepar.Enabled = false;
            this.btnCancelarDepar.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarDepar_Click(object sender, EventArgs e)
        {
            man.ValidarDepartamento(txtDeparNom.Text);

            if (this.txtDeparNom.Text == "")
            {
                errortxtDeparDescrip.SetError(txtDeparNom, "Campo Obligatorio");
            }

            if (CompartirDatos.codDep == 1)
            {
                MessageBox.Show("El departamento " + txtNomCiudad.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (this.txtDeparNom.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Añadir_Depar(this.txtDeparNom.Text);
                this.departamentoDataGridView.Refresh();
                btnAñadirDepar.Enabled = true;
                btnModificarDepar.Enabled = true;
                btnGuardarDepar.Enabled = false;
                btnCancelarDepar.Enabled = false;
                panel6.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnModificarDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificarDepar_Click(object sender, EventArgs e)
        {
            btnModificarDepar.Enabled = false;
            btnAñadirDepar.Enabled = false;
            btnGuardarDepar.Enabled = false;
            btnGuardarCambiosDepar.Enabled = true;
            btnCancelarDepar.Enabled = true;
            panel6.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCambiosDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCambiosDepar_Click(object sender, EventArgs e)
        {
            man.ValidarDepartamento(txtDeparNom.Text);

            if (this.txtDeparNom.Text == "")
            {
                errortxtDeparDescrip.SetError(txtDeparNom, "Campo Obligatorio");
            }
            if (CompartirDatos.codDep == 1)
            {
                MessageBox.Show("El departamento " + txtNomCiudad.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (this.txtDeparNom.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Actualizar_Depar(this.txtDeparNom.Text, int.Parse(this.txtCodDepar.Text));
                this.departamentoDataGridView.Refresh();
                btnAñadirDepar.Enabled = true;
                btnModificarDepar.Enabled = true;
                btnGuardarDepar.Enabled = false;
                btnCancelarDepar.Enabled = false;
                panel6.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtDeparNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtDeparNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtDeparNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtDeparNom_TextChanged(object sender, EventArgs e)
        {
            errortxtDeparDescrip.Clear();
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelarDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelarDepar_Click(object sender, EventArgs e)
        {
            this.departamentoBindingSource.CancelEdit();
            panel6.Enabled = false;
            btnGuardarDepar.Enabled = false;
            btnAñadirDepar.Enabled = true;
            btnGuardarCambiosDepar.Enabled = false;
            btnModificarDepar.Enabled = true;
            btnCancelarDepar.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelarRDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelarRDepar_Click(object sender, EventArgs e)
        {
            this.rolesBindingSource.CancelEdit();
            panel7.Enabled = false;
            btnGuardarRDepar.Enabled = false;
            btnAñadirRolDepar.Enabled = true;
            btnGuardarCambiosRDepar.Enabled = false;
            btnModificarRDepar.Enabled = true;
            btnCancelarRDepar.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the Button11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button11_Click(object sender, EventArgs e)
        {
            this.rolesBindingSource.AddNew();
            this.btnAñadirRolDepar.Enabled = false;
            this.btnGuardarRDepar.Enabled = true;
            panel7.Enabled = true;
            this.btnModificarRDepar.Enabled = false;
            this.btnCancelarRDepar.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarRDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarRDepar_Click(object sender, EventArgs e)
        {
            man.ValidarRol(txtRolNom.Text);

            if (this.txtRolNom.Text == "")
            {
                errorRolDescrip.SetError(txtRolNom, "Campo Obligatorio");
            }
            if (CompartirDatos.codRol == 1)
            {
                MessageBox.Show("El rol " + txtRolNom.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtRolNom.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Añadir_Rol(this.txtRolNom.Text);
                this.rolesDataGridView.Refresh();
                btnAñadirRolDepar.Enabled = true;
                btnModificarRDepar.Enabled = true;
                btnGuardarRDepar.Enabled = false;
                btnCancelarRDepar.Enabled = false;
                panel7.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnModificarRDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificarRDepar_Click(object sender, EventArgs e)
        {
            btnModificarRDepar.Enabled = false;
            btnAñadirRolDepar.Enabled = false;
            btnGuardarRDepar.Enabled = false;
            btnGuardarCambiosRDepar.Enabled = true;
            btnCancelarRDepar.Enabled = true;
            panel7.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCambiosRDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCambiosRDepar_Click(object sender, EventArgs e)
        {

            man.ValidarRol(txtRolNom.Text);
            if (this.txtRolNom.Text == "")
            {
                errorRolDescrip.SetError(txtRolNom, "Campo Obligatorio");
            }
            if (CompartirDatos.codRol == 1)
            {
                MessageBox.Show("El rol " + txtRolNom.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtRolNom.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                man.Actualizar_Rol(this.txtRolNom.Text,int.Parse(txtCodRol.Text));
                this.rolesDataGridView.Refresh();
                btnAñadirRolDepar.Enabled = true;
                btnModificarRDepar.Enabled = true;
                btnGuardarRDepar.Enabled = false;
                btnCancelarRDepar.Enabled = false;
                panel7.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the Button5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the BtnAñadirRolenDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadirRolenDepar_Click(object sender, EventArgs e)
        {
            this.vw_RolesDeparBindingSource.AddNew();
            this.btnAñadirRolenDepar.Enabled = false;
            this.btnGuardarRolenDepar.Enabled = true;
            this.btnEliminarRolenDepar.Enabled = false;
            this.btnCancelarRolenDepar.Enabled = true;
            panel8.Enabled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtRolNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtRolNom_TextChanged(object sender, EventArgs e)
        {
            this.errorRolDescrip.Clear();
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtRolNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtRolNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarRolenDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarRolenDepar_Click(object sender, EventArgs e)
        {
            man.Añadir_RolenDepar((int)cmbRol.SelectedValue, (int)cmbDepar.SelectedValue);

            if(cmbDepar.Text=="")
            {
                errorCmbDepar.SetError(cmbDepar, "Campo obligatorio");
            }
            if(cmbRol.Text=="")
            {
                errorCmbRol.SetError(cmbRol, "Campo obligatorio");
            }

            if (CompartirDatos.codRolD == 0)
            {
                MessageBox.Show("El rol " + cmbRol.Text + " ya pertenece al departamento de " + cmbDepar.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbDepar.Text == ""|| cmbRol.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                man.Añadir_RolenDepar((int.Parse(cmbRol.SelectedValue.ToString())), (int.Parse(cmbDepar.SelectedValue.ToString())));
                this.vw_RolesDeparDataGridView.Refresh();
                this.btnAñadirRolenDepar.Enabled = true;
                this.btnGuardarRolenDepar.Enabled = false;
                this.btnEliminarRolenDepar.Enabled = true;
                this.btnCancelarRolenDepar.Enabled = false;
                panel8.Enabled = false;
                CargarRolxDepar();
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnEliminarRolenDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnEliminarRolenDepar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este rol de este departameto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                man.Eliminar_RolenDepar(int.Parse(cmbRol.SelectedValue.ToString()), int.Parse(cmbDepar.SelectedValue.ToString()));
                this.vw_RolesDeparDataGridView.Refresh();
                CargarRolxDepar();
            }
            else
            {

            }

            

        }

        /// <summary>
        /// Handles the Click event of the BtnCancelarRolenDepar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelarRolenDepar_Click(object sender, EventArgs e)
        {
            this.btnAñadirRolenDepar.Enabled = true;
            this.btnGuardarRolenDepar.Enabled = false;
            this.btnCancelarRolenDepar.Enabled = false;
            this.vw_RolesDeparBindingSource.CancelEdit();
            panel8.Enabled = false;
            CargarRolxDepar();
        }

        /// <summary>
        /// Handles the Click event of the TabPage10 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage10_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the CellClick event of the VwCiudadesDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void VwCiudadesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodCiudad.Text= vwCiudadesDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtNomCiudad.Text = vwCiudadesDataGridView.CurrentRow.Cells[1].Value.ToString();
            cmbPais.Text = vwCiudadesDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        /// <summary>
        /// Handles the CellClick event of the VwSubcategoriaDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void VwSubcategoriaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the CellContentClick event of the VwSubcategoriaDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void VwSubcategoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the codigoTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the codigoLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the 1 event of the vwSubcategoriaDataGridView_CellContentClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vwSubcategoriaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the 1 event of the cmbCategoria_SelectedIndexChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the 1 event of the btnAñadirSubcat_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAñadirSubcat_Click_1(object sender, EventArgs e)
        {
            this.vwSubcategoriaBindingSource.AddNew();
            btnModificarSubcat.Enabled = false;
            btnAñadirSubcat.Enabled = false;
            btnGuardarSubcat.Enabled = true;
            btnGuardarCambiosSubcat.Enabled =false;
            btnCancelarSubcat.Enabled = true;
            panel3.Enabled = true;
        }

        /// <summary>
        /// Handles the 1 event of the btnGuardarSubcat_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGuardarSubcat_Click_1(object sender, EventArgs e)
        {
            MantenimientoMetodos mm = new MantenimientoMetodos();
            mm.ValidarSubcategoria(txtDescripSubcat.Text);

            if (this.txtDescripSubcat.Text == "")
            {
                errorDescripSubcat.SetError(txtDescripSubcat, "Campo obligatorio");
            }
            if (this.cmbCategoria.Text == "")
            {
                errorCmbCategoria.SetError(cmbCategoria, "Campo obligatorio");
            }
            if (CompartirDatos.codSC == 1)
            {
                MessageBox.Show("La subcategoria " + txtDescripSubcat.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtDescripSubcat.Text == "" || this.cmbCategoria.Text == "")
            {
                MessageBox.Show("Campos incompletos o incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mm.Añadir_Subcategoria(this.txtDescripSubcat.Text, int.Parse(this.cmbCategoria.SelectedIndex.ToString()));
                this.vwSubcategoriaDataGridView.Refresh();
                btnAñadirSubcat.Enabled = true;
                btnModificarSubcat.Enabled = true;
                btnGuardarSubcat.Enabled = false;
                btnCancelarSubcat.Enabled = false;
                panel3.Enabled = false;
                CargarSubcatdgv();
            }
        }

        /// <summary>
        /// Handles the 1 event of the btnModificarSubcat_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModificarSubcat_Click_1(object sender, EventArgs e)
        {
            btnModificarSubcat.Enabled = false;
            btnAñadirSubcat.Enabled = false;
            btnGuardarSubcat.Enabled = false;
            btnGuardarCambiosSubcat.Enabled = true;
            btnCancelarSubcat.Enabled = true;
            panel3.Enabled = true;
        }

        /// <summary>
        /// Handles the 1 event of the btnGuardarCambiosSubcat_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGuardarCambiosSubcat_Click_1(object sender, EventArgs e)
        {
            MantenimientoMetodos mm = new MantenimientoMetodos();
            mm.ValidarSubcategoria(txtDescripSubcat.Text);

            if (this.txtDescripSubcat.Text == "")
            {
                errorDescripSubcat.SetError(txtDescripSubcat, "Campo obligatorio");
            }

            if (CompartirDatos.codSC == 1)
            {
                MessageBox.Show("La subcategoria " + txtDescripSubcat.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtDescripSubcat.Text == "")
            {
                MessageBox.Show("Campos incompletos o incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mm.Actualizar_Subcategoria(this.txtDescripSubcat.Text, int.Parse(this.cmbCategoria.SelectedValue.ToString()),
                    int.Parse(txtCodSubcat.Text));
                this.vwSubcategoriaDataGridView.Refresh();
                btnAñadirSubcat.Enabled = true;
                btnModificarSubcat.Enabled = true;
                btnGuardarSubcat.Enabled = false;
                btnCancelarSubcat.Enabled = false;
                panel3.Enabled = false;
                this.CargarSubcatdgv();
            }
        }

        /// <summary>
        /// Handles the 1 event of the btnCancelarSubcat_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancelarSubcat_Click_1(object sender, EventArgs e)
        {
            this.vwSubcategoriaBindingSource.CancelEdit();
            panel3.Enabled = false;
            btnGuardarSubcat.Enabled = false;
            btnAñadirSubcat.Enabled = true;
            btnGuardarCambiosSubcat.Enabled = false;
            btnModificarSubcat.Enabled = true;
            btnCancelarSubcat.Enabled = false;
            this.CargarSubcatdgv();
        }

        /// <summary>
        /// Handles the CellClick event of the vw_RolesDeparDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vw_RolesDeparDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDepar.Text = vw_RolesDeparDataGridView.CurrentRow.Cells[0].Value.ToString();
            cmbRol.Text = vw_RolesDeparDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        /// <summary>
        /// Handles the 1 event of the vwSubcategoriaDataGridView_CellClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vwSubcategoriaDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodSubcat.Text = vwSubcategoriaDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtDescripSubcat.Text  =vwSubcategoriaDataGridView.CurrentRow.Cells[1].Value.ToString();
            cmbCategoria.Text = vwSubcategoriaDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
