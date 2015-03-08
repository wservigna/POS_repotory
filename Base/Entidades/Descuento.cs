using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.Descuento")]
    public class Descuento : Entity
    {
        public virtual TipoDescuento Tipo { get; set; }
        public virtual float monto { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
