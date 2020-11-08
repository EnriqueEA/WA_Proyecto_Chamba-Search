using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WA_Proyecto_Chamba_Search
{
    public class EntidadUsuario
    {
        public int idusuario { get; set; }
        public int idtipo_usuario { get; set; }
        public string nom_usuario { get; set; }
        public string password { get; set; }
        public DateTime fechaRegistrado { get; set; }
        public string estado { get; set; }
    }
}