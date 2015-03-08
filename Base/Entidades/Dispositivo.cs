using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.Dispositivo")]
    public class Dispositivo: Entity
    {
        public virtual string serial { get; set; }
        public virtual TipoDispositivo Tipo {get; set;}
        public virtual DateTime FechaMantenimiento { get; set;}
                

    }
}
