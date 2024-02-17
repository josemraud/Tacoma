// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-02-2019
//
// Last Modified By : pepit
// Last Modified On : 12-11-2019
// ***********************************************************************
// <copyright file="Proveedores.cs" company="">
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
using System.Text.RegularExpressions;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Proveedores.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Proveedores : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Proveedores"/> class.
        /// </summary>
        public Proveedores()
        {
            InitializeComponent();


        }


        /// <summary>
        /// The bas
        /// </summary>
        BaseDeDatos bas = new BaseDeDatos();

        /// <summary>
        /// Handles the Load event of the Proveedores control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProveedores' Puede moverla o quitarla según sea necesario.
            this.vwProveedoresTableAdapter.Fill(this.tacomaDBDataSet.VwProveedores);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.tacomaDBDataSet.Ciudad);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.tacomaDBDataSet.Pais);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProveedores' Puede moverla o quitarla según sea necesario.
            //  this.vwProveedoresTableAdapter.Fill(this.tacomaDBDataSet.VwProveedores);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Pais' Puede moverla o quitarla según sea necesario.
            //  this.paisTableAdapter.Fill(this.tacomaDBDataSet.Pais);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            //  this.proveedoresTableAdapter.Fill(this.tacomaDBDataSet.Proveedores);

            if (txtCodigo.Text== "")
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }
        }

        /// <summary>
        /// Datas the gr.
        /// </summary>
        public void DataGr()
        {
            bas.Conectar();
            SqlCommand coma = new SqlCommand("select * from VwProveedores", bas.cone);
            SqlDataAdapter da = new SqlDataAdapter(coma);
            DataTable tab = new DataTable();
            da.Fill(tab);
            proveedoresDataGridView.DataSource = tab;
            proveedoresBindingSource.DataSource = tab;
            bas.Cerrar();
        }

        /// <summary>
        /// Cargas the ciudad.
        /// </summary>
        /// <param name="codPai">The cod pai.</param>
        public void carga_ciudad(string codPai)
        {
            bas.Conectar();
            SqlCommand coma = new SqlCommand("select b.Ciudad_codigo, b.Ciudad_Nombre from Ciudad b inner join Pais a on a.[Pais_Codigo] =  b.[Pais_Codigo]" +
            "where a.Pais_Nombre = @codPai", bas.cone);
            coma.Parameters.AddWithValue("@codPai", codPai);
            SqlDataAdapter data = new SqlDataAdapter(coma);
            DataTable dt = new DataTable();
            data.Fill(dt);
            bas.Cerrar();

            cmbCiudad.ValueMember = "Ciudad_codigo";
            cmbCiudad.DisplayMember = "Ciudad_Nombre";
            cmbCiudad.DataSource = dt;
        }

        /// <summary>
        /// Handles the Click event of the btnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.DataGr();
            this.proveedoresBindingSource.AddNew();
            btnAñadir.Enabled = false;
            btnGuardarNuevo.Enabled = true;
            panel1.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtNumero.Clear();
            txtCodigo.Clear();
        }

        /// <summary>
        /// Handles the Click event of the btnguardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnguardar_Click(object sender, EventArgs e)
        {
            ProveedoresMetodos pr = new ProveedoresMetodos();
            pr.ModificarCorreo(txtCorreo.Text);
            pr.ModificarTelefono(int.Parse(txtNumero.Text));
            pr.ModificarProveedor(txtNombre.Text);


            if (txtNombre.Text == "" || txtNombre.Text.StartsWith(" "))
                errorNombre.SetError(txtNombre, "Campo obligatorio");

            if (txtNombre.TextLength < 3)
                errorNombre.SetError(txtNombre, "Minimo 3 caracteres");

            if (txtDireccion.Text == "" || txtDireccion.Text.StartsWith(" "))
                errorDirre.SetError(txtDireccion, "Campo obligatorio");

            if (txtDireccion.TextLength < 8)
                errorDirre.SetError(txtDireccion, "Minimo 8 caracteres");

            if (txtNumero.Text != "" && txtNumero.TextLength != 8)
            {
                errorNumer.SetError(txtNumero, "Telefono Invalido");
            }
            else
                if (txtNumero.Text.StartsWith("1") || txtNumero.Text.StartsWith("4")
                || txtNumero.Text.StartsWith("5") || txtNumero.Text.StartsWith("6")
                || txtNumero.Text.StartsWith("0") || txtNumero.Text.Equals("00000000"))
            {
                errorNumer.SetError(txtNumero, "Telefono invalido hola");
            }

            if (txtCorreo.Text == "")
                errorCorr.SetError(txtCorreo, "Campo obligatorio");

            if (txtNumero.Text == "")
                errorNumer.SetError(txtNumero, "Campo obligatorio");

            if (cmbPais.Text == "")
                errorPais.SetError(cmbPais, "Campo obligatorio");

            if (cmbCiudad.Text == "")
                errorCiudad.SetError(cmbCiudad, "Campo obligatorio");

            if (txtNumero.TextLength < 8)
                errorNumer.SetError(txtNumero, "Ingresar un número de telefono válido");
            if (txtNombre.Text != label2.Text)
            {
                if (CompartirDatos.sumPro >= 1)
                {
                    MessageBox.Show("El proveedor " + txtNumero.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNombre.Text == "" || txtDireccion.Text == "" || txtNumero.Text == "" || txtNumero.TextLength < 8 ||
                    txtCorreo.Text == "" || cmbCiudad.Text == "" || cmbPais.Text == "" || txtNombre.Text.StartsWith(" ") || txtNombre.TextLength < 3
                    || txtDireccion.Text.StartsWith(" ") || txtDireccion.TextLength < 8 || (txtNumero.Text != "" && txtNumero.TextLength != 8)
                    || txtNumero.Text.StartsWith("1") || txtNumero.Text.StartsWith("4")
                    || txtNumero.Text.StartsWith("5") || txtNumero.Text.StartsWith("6")
                    || txtNumero.Text.StartsWith("0") || txtNumero.Text.Equals("00000000")
                    )
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtNumero.Text != label3.Text)
            {
                if (CompartirDatos.sumTelPro >= 1)
                {
                    MessageBox.Show("El numero " + txtNumero.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNombre.Text == "" || txtDireccion.Text == "" || txtNumero.Text == "" || txtNumero.TextLength < 8 ||
                    txtCorreo.Text == "" || cmbCiudad.Text == "" || cmbPais.Text == "" || txtNombre.Text.StartsWith(" ") || txtNombre.TextLength < 3
                    || txtDireccion.Text.StartsWith(" ") || txtDireccion.TextLength < 8 || (txtNumero.Text != "" && txtNumero.TextLength != 8)
                    || txtNumero.Text.StartsWith("1") || txtNumero.Text.StartsWith("4")
                    || txtNumero.Text.StartsWith("5") || txtNumero.Text.StartsWith("6")
                    || txtNumero.Text.StartsWith("0") || txtNumero.Text.Equals("00000000")
                    )
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtCorreo.Text != label4.Text)
            { if (CompartirDatos.sumCorPro >= 1)
                {
                    MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNombre.Text == "" || txtDireccion.Text == "" || txtNumero.Text == "" || txtNumero.TextLength < 8 ||
                    txtCorreo.Text == "" || cmbCiudad.Text == "" || cmbPais.Text == "" || txtNombre.Text.StartsWith(" ") || txtNombre.TextLength < 3
                    || txtDireccion.Text.StartsWith(" ") || txtDireccion.TextLength < 8 || (txtNumero.Text != "" && txtNumero.TextLength != 8)
                    || txtNumero.Text.StartsWith("1") || txtNumero.Text.StartsWith("4")
                    || txtNumero.Text.StartsWith("5") || txtNumero.Text.StartsWith("6")
                    || txtNumero.Text.StartsWith("0") || txtNumero.Text.Equals("00000000")
                    )
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ProveedoresMetodos me = new ProveedoresMetodos();
                me.ActualizarProveedores(int.Parse(txtCodigo.Text), txtNombre.Text, txtDireccion.Text, txtCorreo.Text,
                txtNumero.Text, (int)this.cmbCiudad.SelectedValue);

                this.proveedoresDataGridView.Refresh();
                this.DataGr();

                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardarNuevo.Enabled = false;
                panel1.Enabled = false;
                btnguardar.Enabled = false;
                btnCancelar.Enabled = false;

            }
        }

        /// <summary>
        /// Handles the Click event of the btnAceptar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedoresMetodos pr = new ProveedoresMetodos();
            pr.ValidarCorreo(txtCorreo.Text);
            pr.ValidarTelefono(txtNumero.Text);
            pr.ValidarProveedor(txtNombre.Text);


            if (txtNombre.Text == "" || txtNombre.Text.StartsWith(" "))
                errorNombre.SetError(txtNombre, "Campo obligatorio");

            if (txtNombre.TextLength < 3)
                errorNombre.SetError(txtNombre, "Minimo 3 caracteres");

            if (txtDireccion.Text == "" || txtDireccion.Text.StartsWith(" "))
                errorDirre.SetError(txtDireccion, "Campo obligatorio");

            if (txtDireccion.TextLength < 8)
                errorDirre.SetError(txtDireccion, "Minimo 8 caracteres");

            if (txtNumero.Text != "" && txtNumero.TextLength != 8)
            {
                errorNumer.SetError(txtNumero, "Telefono Invalido");
            }
            else
                if (txtNumero.Text.StartsWith("1") || txtNumero.Text.StartsWith("4")
                || txtNumero.Text.StartsWith("5") || txtNumero.Text.StartsWith("6")
                || txtNumero.Text.StartsWith("0") || txtNumero.Text.Equals("00000000"))
            {
                errorNumer.SetError(txtNumero, "Telefono invalido hola");
            }

            if (txtCorreo.Text == "")
                errorCorr.SetError(txtCorreo, "Campo obligatorio");

            if (txtNumero.Text == "")
                errorNumer.SetError(txtNumero, "Campo obligatorio");

            if (cmbPais.Text == "")
                errorPais.SetError(cmbPais, "Campo obligatorio");

            if (cmbCiudad.Text == "")
                errorCiudad.SetError(cmbCiudad, "Campo obligatorio");

            if (txtNumero.TextLength < 8)
                errorNumer.SetError(txtNumero, "Ingresar un número de telefono válido");

            if (CompartirDatos.codPro == 1)
            {
                MessageBox.Show("El nombre " + txtNombre.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CompartirDatos.codT == 1)
            {
                MessageBox.Show("El numero " + txtNumero.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CompartirDatos.codC == 1)
            {
                MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNombre.Text == "" || txtDireccion.Text == "" || txtNumero.Text == "" || txtNumero.TextLength < 8 || cmbCiudad.Text == "" || cmbPais.Text == ""
                || txtNombre.Text.StartsWith(" ") || txtNombre.TextLength < 3
                || txtDireccion.Text.StartsWith(" ") || txtDireccion.TextLength < 8 || (txtNumero.Text != "" && txtNumero.TextLength != 8)
                || txtNumero.Text.StartsWith("1") || txtNumero.Text.StartsWith("4")
                || txtNumero.Text.StartsWith("5") || txtNumero.Text.StartsWith("6")
                || txtNumero.Text.StartsWith("0") || txtNumero.Text.Equals("00000000"))
            {
                MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProveedoresMetodos pro = new ProveedoresMetodos();
                pro.AñadirProveedor(txtNombre.Text, txtDireccion.Text, txtCorreo.Text,
                    txtNumero.Text, (int)cmbCiudad.SelectedValue);

                this.proveedoresDataGridView.Refresh();
                this.DataGr();
                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardarNuevo.Enabled = false;
                btnCancelar.Enabled = false;
                panel1.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text == "Código")
            {
                try
                {
                    BuscarPorCodigo(int.Parse(this.txtBuscar.Text));
                    this.btnAñadir.Enabled = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un código de empleado válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbBusqueda.Text == "Nombre")
            {
                try
                {
                    BuscarPorNombre(this.txtBuscar.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        /// <summary>
        /// Buscars the por codigo.
        /// </summary>
        /// <param name="codi">The codi.</param>
        private void BuscarPorCodigo(int codi)
        {
            try
            {
                BaseDeDatos bas = new BaseDeDatos();
                bas.Conectar();
                SqlCommand coma = new SqlCommand("select * from VwProveedores where [Codigo de proveedor] =@cod ", bas.cone);
                coma.Parameters.AddWithValue("@cod", codi);
                SqlDataAdapter tab = new SqlDataAdapter(coma);
                DataTable dt = new DataTable();
                tab.Fill(dt);
                proveedoresDataGridView.DataSource = dt;
                proveedoresBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un código correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Buscars the por nombre.
        /// </summary>
        /// <param name="nom">The nom.</param>
        private void BuscarPorNombre(string nom)
        {
            BaseDeDatos bas = new BaseDeDatos();
            bas.Conectar();
            try
            {
                SqlCommand coma = new SqlCommand("SELECT * FROM VwProveedores WHERE [Nombre] like'%" + @nom + "%'", bas.cone);
                coma.Parameters.AddWithValue("@nom", nom);
                SqlDataAdapter da = new SqlDataAdapter(coma);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proveedoresDataGridView.DataSource = dt;
                proveedoresBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un nombre válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        /// <summary>
        /// Handles the Click event of the btnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.CancelEdit();
            this.DataGr();
            btnGuardarNuevo.Enabled = false;
            btnAñadir.Enabled = true;
            btnguardar.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            panel1.Enabled = false;
            this.txtCodigo.Clear();
            this.txtCorreo.Clear();
            this.txtDireccion.Clear();
            this.txtNombre.Clear();
            this.txtNumero.Clear();
            this.cmbCiudad.Text = "";
            this.cmbPais.Text = "";
        }



        /// <summary>
        /// Handles the Click event of the btnModificar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnAñadir.Enabled = false;
            btnGuardarNuevo.Enabled = false;
            btnguardar.Enabled = true;
            btnCancelar.Enabled = true;
            panel1.Enabled = true;

            label2.Text = txtNombre.Text;
            label3.Text = txtNumero.Text;
            label4.Text = txtCorreo.Text;
        }



        /// <summary>
        /// Handles the CellContentClick event of the proveedoresDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void proveedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the 1 event of the cmbPais_SelectedIndexChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            errorPais.Clear();
            if (cmbPais.Text.ToString() != null)
            {
                string codPai = cmbPais.Text.ToString();
                this.carga_ciudad(codPai);
            }
        }


        /// <summary>
        /// Handles the TextChanged event of the txtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the KeyPress event of the txtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cmbBusqueda.Text == "Código")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbBusqueda control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBusqueda.Text == "Todos los empleados")
            {
                this.txtBuscar.Clear();
                this.txtBuscar.Enabled = false;
                this.btnBuscar.Enabled = false;
                this.DataGr();
            }
            else
            {
                this.txtBuscar.Enabled = true;
                this.btnBuscar.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the correo_electronicoTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void correo_electronicoTextBox_TextChanged(object sender, EventArgs e)
        {
            errorCorr.Clear();
        }

        /// <summary>
        /// Handles the CellClick event of the proveedoresDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void proveedoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = proveedoresDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = proveedoresDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtNumero.Text = proveedoresDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = proveedoresDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = proveedoresDataGridView.CurrentRow.Cells[4].Value.ToString();
            cmbPais.Text = proveedoresDataGridView.CurrentRow.Cells[5].Value.ToString();
            cmbCiudad.Text = proveedoresDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbPais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Validating event of the txtCorreo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            Regex email = new Regex(@"^[a-zA-Z][[\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtCorreo.Text.Length > 0)
            {
                if (!email.IsMatch(txtCorreo.Text))
                {
                    MessageBox.Show("Email invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the txtNumero control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

        }

        /// <summary>
        /// Handles the KeyPress event of the txtDireccion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the txtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the txtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorNombre.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtNumero control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            errorNumer.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtDireccion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            errorDirre.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorCiudad.Clear();
        }
    }
}
