
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WSF.Domain.Entities;

namespace Base.Entidades
{
    [Table("Maestro.Cliente")]
    public class Clientes : Entity
    {
        public virtual string Documento { get; set;  }
        public virtual TipoDocumento Tipo { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string NumeroTelefono { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime FechaRegistro { get; set; }
        public virtual DateTime FechaActualizacion { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual List<TipoSaldo> Saldos { get; set; }


    }
}
