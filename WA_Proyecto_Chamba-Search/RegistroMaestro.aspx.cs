﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WA_Proyecto_Chamba_Search
{
    public partial class RegistroMaestro : System.Web.UI.Page
    {
        void listaComboDistrito()
        {
            DaoDistrito daoDistrito = new DaoDistrito();
            DataTable dt = new DataTable();
            dt = daoDistrito.listarDistrito();
            cboDistrito.DataSource = dt;
            cboDistrito.DataTextField = "nombreDistrito";
            cboDistrito.DataValueField = "idDistrito";
            cboDistrito.DataBind();
        }
        public void mensaje(string msj)
        {
            Response.Write("<script>alert('" + msj + "')</script>");
        }

        public void registrarMaestro()
        {
            EntidadPersona ep = new EntidadPersona();
            ep.nombres = txtNombres.Text.Trim();
            ep.apePaterno = txtPaterno.Text.Trim();
            ep.apeMaterno = txtMaterno.Text.Trim();
            ep.fechaNac = txtFechaNac.Text.Trim();
            ep.sexo = rdSexo.SelectedValue.Substring(0, 1);
            ep.dni = txtDNI.Text.Trim();
            ep.idDistrito = cboDistrito.SelectedValue;
            ep.celular = txtCelular.Text.Trim();
            ep.email = txtEmail.Text.Trim();
            ep.imagen_perfil = fileupload.PostedFile.FileName;
            ep.nom_usuario = txtUsusario.Text.Trim();
            ep.password = txtPassword.Text.Trim();
            ep.idtipoCuenta = 1;

            DaoPersona usu = new DaoPersona();
            mensaje(usu.insertarPersona(ep));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaComboDistrito();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            registrarMaestro(); //agregar que envie un mensaje de error desde el sql
        }
    }
}