using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class LibroMayorPorFechas : Form
    {
        Coneccion c = new Coneccion();
        public LibroMayorPorFechas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string desde,hasta;
            desde = dtDesde.Text.ToString();//Guarda fecha en formato dd-mm-aaaa
            hasta = dtHasta.Text.ToString();
            dvtDesdeHasta.DataSource = c.mostrarMayorFecha(desde, hasta);
        }
    }
}
