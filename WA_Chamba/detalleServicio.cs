//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WA_Chamba
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalleServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public detalleServicio()
        {
            this.comentario = new HashSet<comentario>();
        }
    
        public int idDetalleServicio { get; set; }
        public int idpersona { get; set; }
        public int idservicio { get; set; }
        public Nullable<int> idimagen { get; set; }
        public Nullable<int> cantidadcomentario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comentario> comentario { get; set; }
        public virtual imagen imagen { get; set; }
        public virtual persona persona { get; set; }
        public virtual servicio servicio { get; set; }
    }
}