using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WA_Proyecto_Chamba_Search
{
    public partial class WF_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*EntidadServicio es = new EntidadServicio();
            es.idTipoServicio =  Convert.ToInt32(txtTipoServicio.Text.Trim());
            es.nom_srv = txtNombreServ.Text.Trim();
            es.descripcion = txtDescripcion.InnerText.Trim();
            es.precio = Convert.ToDouble(txtPrecio.Text.Trim(), CultureInfo.InvariantCulture);

            DaoServicio dao = new DaoServicio();
            string msj = dao.insertar_servicio(es);*/
            string msj = "";
            Response.Write("<script>alert('" + msj + "')</script>");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            EntidadPersona ep = new EntidadPersona();
            ep.nom_usuario = txtUsuario.Text.Trim();
            ep.password = txtPassw.Text.Trim();

            DaoPersona dao_usu = new DaoPersona();
            DataTable dt = new DataTable();
            dt = dao_usu.login(ep);
            if (dt.Rows.Count > 0 || 1 == 1)
            {
                //Session["nombre"] = dt.Rows[0]["nombres"];
                Response.Redirect("default.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario y contraseña inválida')</script>");
            }
        }
    }
}