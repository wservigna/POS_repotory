using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Transacion.PagoFactura")]
    public class PagoFactura: Entity
    {
        public virtual FormaPago FormaPagos { get; set; }
        public virtual float MontoPago { get; set; }
        public virtual Estatus EstatusPago { get; set; }
        public virtual DateTime FechaPago { get; set; }
    }
}
