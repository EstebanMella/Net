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
    public partial class LibroMayorTodo : Form
    {
        Coneccion c = new Coneccion();
        public LibroMayorTodo()
        {
            InitializeComponent();
        }

        private void LibroMayorTodo_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            dvgVerTodo.DataSource = c.mostrarMayorTodo();

        }
    }
}
