using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionForm
{
    public partial class frmIU : Form
    {
        public frmIU()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();
           
            string nombre = this.txtNom.Text;
            this.txtMensaje.Text = conta.Saludos();
            double x = double.Parse(this.txtSaldoIni.Text);
            this.txtRes.Text = conta.getSaldos(x).ToString();
            int numMes = Int32.Parse(this.txtMes.Text);
            this.txtNombreMes.Text = CapaLogica.Utilidades.getNombreDelMes(numMes);
        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
