//using IngresaCuenta;
using IngresaCuenta;
using SistemaControlyRegistro;
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
    public partial class Contabilidad : Form
    {
        public Contabilidad()
        {
            InitializeComponent();
        }

        private void insertarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            InsertarCuenta frm = new InsertarCuenta();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void eliminarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EliminarCuenta frm = new EliminarCuenta();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void registrarIngresoegresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form2 frm = new Form2();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void buscarPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BuscarLibroDiarioFecha frm = new BuscarLibroDiarioFecha();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void buscarPorFechaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BalancePorCuenta frm = new BalancePorCuenta();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void buscarPorFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LibroMayorPorFechas frm = new LibroMayorPorFechas();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LibroDiarioVerTodo frm = new LibroDiarioVerTodo();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }

        private void verTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LibroMayorTodo frm = new LibroMayorTodo();
            frm.TopLevel = false;
            frm.Parent = panel1;
            frm.Show();
        }
    }
}
