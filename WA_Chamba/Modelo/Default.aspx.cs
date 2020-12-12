using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_Proyecto_Chamba_Search.Model
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/imagenes/" + FileUpload1.FileName));
                lblSalida.Text = "Cargado con éxito <br />";
                lblSalida.Text += "<img src=/archhivos/" + FileUpload1.FileName +" />";
            }
            else
            {
                lblSalida.Text = "Debe seleccionar un archivo";
            }
        }
    }
}