using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WA_Proyecto_Chamba_Search
{
    public class EntidadPersona
    {
        public int idPersona { get; set; }
        public string idDistrito { get; set; }
        public string nombres { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public string fechaNac { get; set; }
        public string sexo { get; set; }
        public string dni { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string imagen_perfil { get; set; }
        public int idtipoCuenta { get; set; }
        public string nom_usuario { get; set; }
        public string password { get; set; }
        public DateTime fechaRegistrado { get; set; }
        public string estado_cuenta { get; set; }
    }
}