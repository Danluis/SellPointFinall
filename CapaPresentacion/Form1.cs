using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Entidades objetoCN = new CN_Entidades();
        private String idEntidad = null;
        private bool Editar=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEntidad();
        }
        private void MostrarEntidad()
        {
            CN_Entidades objetoCN = new CN_Entidades();
            dataGridView1.DataSource = objetoCN.MostrarEnt();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false) { 
            try { 
            objetoCN.InsertarEnt(txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, txtTipoEntidad.Text, txtTipoDocumento.Text, txtNumeroDocumento.Text,
            txtTelefono.Text, txtPaginaWeb.Text, txtFacebook.Text, txtInstagram.Text, txtTwitter.Text, txtTikTok.Text, txtCodigoPostal.Text, 
            txtCoordenadasGPS.Text, txtLimiteCredito.Text, txtUserNameEntidad.Text, txtPasswordEntidad.Text, txtRolUserEntidad.Text, txtComentario.Text,
            txtStatus.Text, txtNoEliminable.Text);
            MessageBox.Show("Se inserto Correctamente");
            MostrarEntidad();
                    limpiarForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }
            }
            if(Editar == true)
            {
                try
                {
                    objetoCN.EditarEnt(txtDescripcion.Text,txtDireccion.Text,txtLocalidad.Text,txtTipoEntidad.Text,txtTipoDocumento.Text,txtNumeroDocumento.Text,
            txtTelefono.Text,txtPaginaWeb.Text,txtFacebook.Text,txtInstagram.Text,txtTwitter.Text,txtTikTok.Text,txtCodigoPostal.Text,
            txtCoordenadasGPS.Text,txtLimiteCredito.Text,txtUserNameEntidad.Text,txtPasswordEntidad.Text,txtRolUserEntidad.Text,txtComentario.Text,
            txtStatus.Text,txtNoEliminable.Text,idEntidad);
                    MessageBox.Show("Se edito Correctamente");
                    MostrarEntidad();
                    limpiarForm();
                    Editar = false;
                }
                catch(Exception ex){
                    MessageBox.Show("No se pudo editar los datos por: " + ex);

                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtLocalidad.Text = dataGridView1.CurrentRow.Cells["Localidad"].Value.ToString();
                txtTipoEntidad.Text = dataGridView1.CurrentRow.Cells["TipoEntidad"].Value.ToString();
                txtTipoDocumento.Text = dataGridView1.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                txtNumeroDocumento.Text = dataGridView1.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefonos"].Value.ToString();
                txtPaginaWeb.Text = dataGridView1.CurrentRow.Cells["URLPaginaWeb"].Value.ToString();
                txtFacebook.Text = dataGridView1.CurrentRow.Cells["URLFacebook"].Value.ToString();
                txtInstagram.Text = dataGridView1.CurrentRow.Cells["URLInstagram"].Value.ToString();
                txtTwitter.Text = dataGridView1.CurrentRow.Cells["URLTwitter"].Value.ToString();
                txtTikTok.Text = dataGridView1.CurrentRow.Cells["URLTikTok"].Value.ToString();
                txtCodigoPostal.Text = dataGridView1.CurrentRow.Cells["CodigoPostal"].Value.ToString();
                txtCoordenadasGPS.Text = dataGridView1.CurrentRow.Cells["CoordenadasGPS"].Value.ToString();
                txtLimiteCredito.Text = dataGridView1.CurrentRow.Cells["LimiteCredito"].Value.ToString();
                txtUserNameEntidad.Text = dataGridView1.CurrentRow.Cells["UserNameEntidad"].Value.ToString();
                txtPasswordEntidad.Text = dataGridView1.CurrentRow.Cells["PassworEntidad"].Value.ToString();
                txtRolUserEntidad.Text = dataGridView1.CurrentRow.Cells["RolUserEntidad"].Value.ToString();  
                txtComentario.Text = dataGridView1.CurrentRow.Cells["Comentario"].Value.ToString();
                txtStatus.Text = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
                txtNoEliminable.Text = dataGridView1.CurrentRow.Cells["NoEliminable"].Value.ToString();
                idEntidad = dataGridView1.CurrentRow.Cells["IdEntidad"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a editar");
            }
            
             }
        private void limpiarForm()
        {
            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            txtTipoEntidad.Clear();
            txtTipoDocumento.Clear();
            txtNumeroDocumento.Clear();
            txtTelefono.Clear();
            txtPaginaWeb.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtTwitter.Clear();
            txtTikTok.Clear();
            txtCodigoPostal.Clear();
            txtCoordenadasGPS.Clear();
            txtLimiteCredito.Clear();
            txtUserNameEntidad.Clear();
            txtPasswordEntidad.Clear();
            txtRolUserEntidad.Clear();
            txtComentario.Clear();
            txtStatus.Clear();
            txtNoEliminable.Clear();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idEntidad = dataGridView1.CurrentRow.Cells["IdEntidad"].Value.ToString();
                objetoCN.EliminarEnt(idEntidad);
                MessageBox.Show("Eliminado Correctamente");
                MostrarEntidad();
            }
             
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

        }
    }
}