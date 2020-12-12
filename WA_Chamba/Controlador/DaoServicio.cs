using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WA_Proyecto_Chamba_Search
{
    public class DaoServicio
    {
        SqlConnection con = new SqlConnection("server=ENRIQUEEA;database=DB_ChambaSearch;integrated security= true");

        public string insertar_servicio(EntidadServicio es)
        {
            string msj="";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pd_insertar_servicio";
                cmd.Parameters.AddWithValue("@idTipoServicio", es.idTipoServicio);
                cmd.Parameters.AddWithValue("@nom_srv",  es.nom_srv);
                cmd.Parameters.AddWithValue("@desc", es.descripcion);
                cmd.Parameters.AddWithValue("@prec_srv", es.precio);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                msj = "Exito!!";
            }
            catch (SqlException ex)
            {
                msj = "ERROR: " + ex.Message;
            }
            return msj;
        }
    }
}