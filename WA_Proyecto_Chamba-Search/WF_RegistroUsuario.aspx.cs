﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WA_Proyecto_Chamba_Search
{
    public partial class WF_RegistroUsuario : System.Web.UI.Page
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

        void GrabarUsuario()
        {
            EntidadPersona ep = new EntidadPersona();
            EntidadUsuario eu = new EntidadUsuario();
            ep.nombres_per = txtNombres.Text.Trim();
            ep.ape_paterno = txtPaterno.Text.Trim();
            ep.ape_materno = txtMaterno.Text.Trim();
            ep.fechaNac = txtFechaNac.Text.Trim();
            ep.sexo = rdSexo.SelectedValue.Substring(0, 1);
            ep.dni = txtDNI.Text.Trim();
            ep.idDistrito = cboDistrito.SelectedValue;
            ep.celular = txtCelular.Text.Trim();
            ep.email = txtEmail.Text.Trim();
            ep.imagen_perfil = fileupload.PostedFile.FileName;

        }
        protected void Page_Load(object sender, EventArgs e) 
        {
            if (!IsPostBack)
            {
                rdSexo.Items.Add("Hombre");
                rdSexo.Items.Add("Mujer");
                listaComboDistrito();            
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}