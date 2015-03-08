using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.Producto")]
    public class Producto : Entity
    {
        public virtual string CodigoBarra { get; set; }
        public virtual string CodigoUnico { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual float PVP { get; set; }
        public virtual float PVPMayor { get; set; }
    }
}
