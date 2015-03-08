using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.FormasPago")]
    public class FormaPago: Entity
    {
        public virtual string Descripcion { get; set; }
        public virtual string Entidad { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}
