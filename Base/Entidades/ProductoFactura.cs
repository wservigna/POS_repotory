using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Transaccion.ProductoFactura")]
    public class ProductoFactura: Entity
    {
        public virtual Producto Productos { get; set; }
        public virtual float Cantidad { get; set; }
        public virtual float Unidades { get; set; }
        public virtual float Peso { get; set; }
        public virtual float Precio { get; set; }
        public virtual Descuento Descuentos { get; set; }
    }
}
