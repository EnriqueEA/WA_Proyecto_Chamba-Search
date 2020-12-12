using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_Proyecto_Chamba_Search.Vistas.VistaMaestro
{
    public partial class NuevoServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntidadServicio es = new EntidadServicio();
            es.idTipoServicio = Convert.ToInt32(txtTipoServicio.Text.Trim());
            es.nom_srv = txtNombreServ.Text.Trim();
            es.descripcion = txtDescripcion.InnerText.Trim();
            es.precio = Convert.ToDouble(txtPrecio.Text.Trim(), CultureInfo.InvariantCulture);

            DaoServicio dao = new DaoServicio();
            string msj = dao.insertar_servicio(es);


        }
    }
}