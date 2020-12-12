using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_Proyecto_Chamba_Search.Vistas.VistaMaestro
{
    public partial class LoginMaestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            EntidadPersona ep = new EntidadPersona();
            ep.nom_usuario = txtUsuario.Text.Trim();
            ep.password = txtPassw.Text.Trim();

            DaoPersona dao_usu = new DaoPersona();
            DataTable dt = new DataTable();
            dt = dao_usu.login(ep);
            if (dt.Rows.Count > 0)
            {

                string[] fecha = dt.Rows[0]["fechaNacimiento"].ToString().Split('/');
                int tc = Convert.ToInt32(dt.Rows[0]["idTipoCuenta"]);

                Session["nombresC"] = dt.Rows[0]["apePaterno"] + " " + dt.Rows[0]["apeMaterno"] + ", " + dt.Rows[0]["nombres"];
                Session["edad"] = Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(fecha[2].Substring(0,4));
                Session["dni"] = dt.Rows[0]["dni"];
                Session["cel"] = dt.Rows[0]["celular"];
                Session["email"] = dt.Rows[0]["email"];
                Session["foto"] = dt.Rows[0]["imagenPerfil"];
                Session["estado"] = dt.Rows[0]["estadoCuenta"];
                Session["nombre"] = dt.Rows[0]["nombres"];
                Session["usuario"] = dt.Rows[0]["nom_usuario"];
                
                
                if (tc == 1)
                {
                    Session["tipoCuenta"] = "Administrador";
                    Response.Redirect("VistaAdmin/Default.aspx");
                }
                else if (tc == 2)
                {
                    Session["tipoCuenta"] = "Maestro";
                    Response.Redirect("VistaMaestro/Default.aspx");
                }
                else
                {
                    Session["tipoCuenta"] = "Visitante";
                }
            }
            else
            {
                Response.Write("<script>alert('Usuario y contraseña inválida')</script>");
            }
        }
    }
}