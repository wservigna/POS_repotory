using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Transaccion.Factura")]
    public class Factura:Entity
    {
        public virtual Caja CajaFactura { get; set; }
        public virtual DateTime FechaFactura { get; set; }
        public virtual DateTime FechaCreacion { get; set; }
        public virtual List<PagoFactura> FormasPago{ get; set;}
        public virtual Clientes Cliente { get; set; }
        public virtual List<ProductoFactura> ProductosFactura {get; set;}
        public virtual float MontoBruto { get; set; }
        public virtual float MontoTotal { get; set; }
        public virtual List<Descuento> Descuentos {get; set;}
        public virtual float MontoDescuento { get; set; }
        public virtual float MontoPago { get; set; }





    }
}
