using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.TipoDispositivo")]
    public class TipoDispositivo : Entity
    {
        public virtual string Descripcion { get; set; }
        public virtual long FrecuenciaMantenimiento { get; set; }
    }
}
