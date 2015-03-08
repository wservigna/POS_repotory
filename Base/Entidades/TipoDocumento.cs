

using System.ComponentModel.DataAnnotations.Schema;
using WSF.Domain.Entities;
namespace Base.Entidades
{
    [Table("Maestro.TipoDocumento")]
    public class TipoDocumento:Entity
    {
        public virtual string Nombre { get; set; }
        public virtual Estatus EstatusDocumento { get; set; }
    }
}
