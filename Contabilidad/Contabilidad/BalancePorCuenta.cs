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
    public partial class BalancePorCuenta : Form
    {
        public BalancePorCuenta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cuenta;
            try
            {
                cuenta = cmbCuenta.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
        }
    }
}
