using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contabilidad;
using MySql.Data.MySqlClient;

//object select2 = cmbClase.SelectedValue;          ME MUESTA EL ID DE LA BASE DE DATOS
 //txtDescripcion.Text =select2.ToString();
namespace IngresaCuenta
{
    public partial class InsertarCuenta : Form
    {
        MySqlDataReader myReader;
        Coneccion c = new Coneccion();
        String sqlCbxClase = "SELECT `id`, `nombre` FROM `clase`";
        String id = "id";
        String desc = "nombre";
        String sqlCbxSubClase = "SELECT `id`, `nombre` FROM `sub_clase`";
        public InsertarCuenta()
        {
            InitializeComponent();
            c.llenarCBX(cmbClase, sqlCbxClase,id,desc);
            c.llenarCBX(cmbSubclase, sqlCbxSubClase, id, desc);

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Código para insertar cuenta
            string nombre, clase, subclase, descripcion;
            nombre = txtNombre.Text.ToString();
           
                object select2 = cmbClase.SelectedValue;
                clase = select2.ToString();
                
           
                object select = cmbSubclase.SelectedValue;
                subclase = select2.ToString();
           
          
            descripcion = txtDescripcion.Text.ToString();

            String Sql = "INSERT INTO `cuenta`(`id`, `id_clase`, `id_sub_clase`, `nombre`, `descripcion`, `estado`) VALUES ('null','"+clase+"','"+subclase+"','"+nombre+"','"+descripcion+"','1'";
            int resultado=c.insertar(Sql);
            if (resultado == 1)
            {
                MessageBox.Show("Clase Guardada");
                txtDescripcion.Text = "";
                txtNombre.Text = "";
            }
            else 
            {
                MessageBox.Show("Error al Guardar");
            }
            
        }

        private void InsertarCuenta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
