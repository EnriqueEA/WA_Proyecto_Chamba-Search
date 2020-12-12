using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_Proyecto_Chamba_Search.Vistas.VistaMaestro
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Image1.ImageUrl = "../.." + Session["foto"].ToString();
            lblInfo.Text = "<b>Nombre:</b> " + Session["nombresC"].ToString() + "<br>";
            lblInfo.Text += "<b>Edad:</b> " + Session["edad"].ToString() + " años<br>";
            lblInfo.Text += "<b>Correo:</b> " + Session["email"].ToString() + "<br>";
            lblInfo.Text += "<b>Celular:</b> " + Session["cel"].ToString() + "<br>";
            lblInfo.Text += "<b>Nombre de usuario:</b> " + Session["usuario"].ToString() + "<br>";
            lblInfo.Text += "<b>Tipo de Cuenta: </b><b>" + Session["tipoCuenta"].ToString() + "</b><br>";
        }
    }
}