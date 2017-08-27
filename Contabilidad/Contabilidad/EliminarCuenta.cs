using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Contabilidad;

namespace IngresaCuenta
{
     
    public partial class EliminarCuenta : Form
    {
        String sqlCbxClase = "SELECT `id`, `nombre` FROM `clase`";
        String id = "id";
        String desc = "nombre";
        MySqlDataReader myReader;
        Coneccion c = new Coneccion();
        public EliminarCuenta()
        {
            InitializeComponent();
            c.llenarCBX(cmbNombre, sqlCbxClase, id, desc);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Código para eliminar cuenta
            object select2 = cmbNombre.SelectedValue;
            String clase = select2.ToString();
            string sql = "UPDATE `cuenta` SET `estado`='0' WHERE `id`=='"+clase+"' ";
            int result = c.insertar(sql);
            if(result==1){
                MessageBox.Show("Cuenta Eliminada");
            }
            else{
                MessageBox.Show("Error Cuenta no pudo ser eliminada");
            }
        }


    }
}
