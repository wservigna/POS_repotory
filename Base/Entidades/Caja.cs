using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Configuracion.Caja")]
    public class Caja: Entity
    {
        public virtual string Serial { get; set; }
        public virtual Estatus EstatusCaja { get; set; }
        public virtual List<Dispositivo> Dispositivos { get; set; }
    }
}
