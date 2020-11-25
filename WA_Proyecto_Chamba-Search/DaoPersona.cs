using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WA_Proyecto_Chamba_Search
{
    public class DaoPersona
    {
        SqlConnection con = new SqlConnection("server=ENRIQUEEA;database=DB_ChambaSearch;integrated security=true");

        public string insertarPersona(EntidadPersona ep)
        {
            string msj = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pd_insertar_persona";
                cmd.Parameters.AddWithValue("@idtipoCuenta", ep.idtipoCuenta);
                cmd.Parameters.AddWithValue("@nom_usu", ep.nom_usuario);
                cmd.Parameters.AddWithValue("@password", ep.password);
                cmd.Parameters.AddWithValue("@idDistrito", ep.idDistrito);
                cmd.Parameters.AddWithValue("@imagenPerfil", ep.imagen_perfil);
                cmd.Parameters.AddWithValue("@nombres", ep.nombres);
                cmd.Parameters.AddWithValue("@apePaterno", ep.apePaterno);
                cmd.Parameters.AddWithValue("@apeMaterno", ep.apeMaterno);
                cmd.Parameters.AddWithValue("@fechaNac", ep.fechaNac);
                cmd.Parameters.AddWithValue("@dni", ep.dni);
                cmd.Parameters.AddWithValue("@sexo", ep.sexo);
                cmd.Parameters.AddWithValue("@celular", ep.celular);
                cmd.Parameters.AddWithValue("@email", ep.email);
                cmd.Parameters.AddWithValue("@estadoCuenta", ep.estado_cuenta);

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

        public DataTable login(EntidadPersona ep)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT nombres,nom_usuario,password FROM persona " +
                "WHERE nom_usuario=@usu and password=@pwd", con);

            da.SelectCommand.Parameters.AddWithValue("@usu", ep.nom_usuario);
            da.SelectCommand.Parameters.AddWithValue("@pwd", ep.password);
            da.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}