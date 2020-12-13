using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionWeb
{
    public partial class Saludos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();
            this.lblMensaje.Text = conta.Saludos(nombre);
            double x = double.Parse(this.txtSaldoInicial.Text);
            this.txtRes.Text = conta.getSaldos(x).ToString();
            int numMes = Int32.Parse(this.txtNumMes.Text);
            this.txtnombreMes.Text = CapaLogica.Utilidades.getNombreDelMes(numMes);
        }
    }
}