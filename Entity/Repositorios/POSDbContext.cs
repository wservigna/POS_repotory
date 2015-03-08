
using Base.Entidades;
using System.Data.Entity;
using WSF.EntityFramework;

namespace Entity.Repositorios
{
    public class POSDbContext : WSFDbContext
    {
        public virtual IDbSet<Caja> Caja { get; set; }
        public virtual IDbSet<Estatus> Estatus { get; set; }
        public virtual IDbSet<Clientes> Cliente { get; set; }
        public virtual IDbSet<Descuento> Descuento { get; set; }
        public virtual IDbSet<Dispositivo> Dispositivos { get; set; }
        public virtual IDbSet<FormaPago> FormaPago { get; set; }
        public virtual IDbSet<PagoFactura> PagoFactura { get; set; }
        public virtual IDbSet<Factura> Factura { get; set; }
        public virtual IDbSet<Producto> Producto { get; set; }
        public virtual IDbSet<ProductoFactura> ProductoFactura { get; set; }
        public virtual IDbSet<TipoDescuento> TipoDescuento { get; set; }
        public virtual IDbSet<TipoDispositivo> TipoDispositivo { get; set; }
        public virtual IDbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual IDbSet<TipoSaldo> TipoSaldo { get; set; }

         public POSDbContext() : base("Default")
        {
        }
         public POSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
