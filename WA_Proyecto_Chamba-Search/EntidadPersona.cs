using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WA_Proyecto_Chamba_Search
{
    public class EntidadPersona
    {
        public int idPersona { get; set; }
        public int idusuario { get; set; }
        public string idDistrito { get; set; }
        public string nombres_per { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public string fechaNac { get; set; }
        public string sexo { get; set; }
        public string dni { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string imagen_perfil { get; set; }
    }
}