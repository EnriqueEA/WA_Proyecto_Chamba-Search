using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_Proyecto_Chamba_Search.Vistas.VistaMaestro
{
    public partial class Maestro : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text += Session["nombre"].ToString();
        }
    }
}