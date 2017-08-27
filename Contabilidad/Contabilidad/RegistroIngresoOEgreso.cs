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

namespace SistemaControlyRegistro
{
    public partial class Form2 : Form
    {
        String sqlCbxCuenta = "SELECT `id`, `nombre` FROM `cuenta`";
        String sqlCbxIngreEgre = "SELECT `id`, `nombre` FROM `ingre_egre`";
        String id = "id";
        String desc = "nombre";
        MySqlDataReader myReader;
        Coneccion c = new Coneccion();
        public Form2()
        {
            InitializeComponent();
            c.llenarCBX(cmbCuenta, sqlCbxCuenta, id, desc);
            c.llenarCBX(cmbIngreEgre, sqlCbxIngreEgre, id, desc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMonto.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese sólo números.");
                txtMonto.Text = txtMonto.Text.Substring(0, txtMonto.Text.Length - 1);
                txtMonto.SelectionStart = txtMonto.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtComprobante.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese sólo números.");
                txtComprobante.Text = txtComprobante.Text.Substring(0, txtComprobante.Text.Length - 1);
                txtComprobante.SelectionStart = txtComprobante.Text.Length;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fecha, cuenta, descripcion, monto, comprobante,ingreEgre;
            fecha = dtFecha.Text.ToString();//Guarda fecha en formato dd-mm-aaaa

            descripcion = txtDescripcion.Text.ToString();
            monto = txtMonto.Text.ToString();
            comprobante = txtComprobante.Text.ToString();
            object select2 = cmbCuenta.SelectedValue;
            cuenta = select2.ToString();
            select2 = cmbIngreEgre.SelectedValue;
            ingreEgre = select2.ToString();

            if (txtMonto.Text.ToString() == null || txtMonto.Text.ToString() == "")//Si no hay nada en txtMonto
            {
                MessageBox.Show("Ingrese monto");
            }

            else if (txtComprobante.Text.ToString() == null || txtComprobante.Text.ToString() == "")//Si no hay nada en txtComprobante
            {
                MessageBox.Show("Ingrese número de comprobante");
            }
            else 
            {
                String sql2 = " VALUES ('null','" + cuenta + "','" + ingreEgre + "','" + fecha + "','" + comprobante + "','" + monto + "','" + descripcion + "','1')";
                String sql = "INSERT INTO `ingreso`(`id`, `id_cuenta`, `id_ingre_egre`, `fecha`, `n_comprobante`, `monto`, `descripcion`, `estado`)"+sql2;
                int result = c.insertar(sql);
                if (result == 1)
                {
                    MessageBox.Show("Registro guardado");
                    txtComprobante.Text = "";
                    txtDescripcion.Text = "";
                    txtMonto.Text = "";
                }
                else
                {
                    MessageBox.Show("Error registro no guardado");
                }
                

            }
        }
    }
}
