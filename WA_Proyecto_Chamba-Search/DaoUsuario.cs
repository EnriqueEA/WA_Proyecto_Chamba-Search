using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WA_Proyecto_Chamba_Search
{
    public class DaoUsuario
    {
        SqlConnection con = new SqlConnection("server=ENRIQUEEA;database=DB_ChambaSearch;integrated security=true");

        public string insertarUsuario(EntidadUsuario eu, EntidadPersona ep)
        {
            string msj = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pd_insertar_usuario_maestro";
                cmd.Parameters.AddWithValue("@tipo_usu", eu.idtipo_usuario);
                cmd.Parameters.AddWithValue("@nom_usu", eu.nom_usuario);
                cmd.Parameters.AddWithValue("@password", eu.password);
                cmd.Parameters.AddWithValue("@idDis", ep.idDistrito);
                cmd.Parameters.AddWithValue("@image", ep.imagen_perfil);
                cmd.Parameters.AddWithValue("@nombres", ep.nombres_per);
                cmd.Parameters.AddWithValue("@apePaterno", ep.ape_paterno);
                cmd.Parameters.AddWithValue("@apeMaterno", ep.ape_materno);
                cmd.Parameters.AddWithValue("@fechaNac", ep.fechaNac);
                cmd.Parameters.AddWithValue("@dni", ep.dni);
                cmd.Parameters.AddWithValue("@sexo", ep.sexo);
                cmd.Parameters.AddWithValue("@celu", ep.celular);
                cmd.Parameters.AddWithValue("@email", ep.email);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

                msj = "Registro Satisfactorio!!";
            }
            catch (SqlException ex)
            {
                msj = "ERROR: " + ex.Message;
            }

            return msj;
        }

        public DataTable login(EntidadUsuario eu)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT nom_usuario,contraseña FROM usuario " +
                "WHERE nom_usuario=@usu and contraseña=@pwd", con);
            
            da.SelectCommand.Parameters.AddWithValue("@usu", eu.nom_usuario);
            da.SelectCommand.Parameters.AddWithValue("@pwd", eu.password);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}