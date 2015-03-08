using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.TipoSaldo")]
    public class TipoSaldo : Entity
    {
        public virtual string Descripcion { get; set; }
    }
}
