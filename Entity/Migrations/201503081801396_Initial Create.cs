namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Configuracion.Caja",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Serial = c.String(),
                        EstatusCaja_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Estatus", t => t.EstatusCaja_Id)
                .Index(t => t.EstatusCaja_Id);
            
            CreateTable(
                "Maestro.Dispositivo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        serial = c.String(),
                        FechaMantenimiento = c.DateTime(nullable: false),
                        Tipo_Id = c.Int(),
                        Caja_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.TipoDispositivo", t => t.Tipo_Id)
                .ForeignKey("Configuracion.Caja", t => t.Caja_Id)
                .Index(t => t.Tipo_Id)
                .Index(t => t.Caja_Id);
            
            CreateTable(
                "Maestro.TipoDispositivo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        FrecuenciaMantenimiento = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Maestro.Estatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Maestro.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        NumeroTelefono = c.String(),
                        Email = c.String(),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Tipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.TipoDocumento", t => t.Tipo_Id)
                .Index(t => t.Tipo_Id);
            
            CreateTable(
                "Maestro.TipoSaldo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Clientes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Cliente", t => t.Clientes_Id)
                .Index(t => t.Clientes_Id);
            
            CreateTable(
                "Maestro.TipoDocumento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        EstatusDocumento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Estatus", t => t.EstatusDocumento_Id)
                .Index(t => t.EstatusDocumento_Id);
            
            CreateTable(
                "Maestro.Descuento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        monto = c.Single(nullable: false),
                        Estatus_Id = c.Int(),
                        Producto_Id = c.Int(),
                        Tipo_Id = c.Int(),
                        Factura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Estatus", t => t.Estatus_Id)
                .ForeignKey("Maestro.Producto", t => t.Producto_Id)
                .ForeignKey("Maestro.TipoDescuento", t => t.Tipo_Id)
                .ForeignKey("Transaccion.Factura", t => t.Factura_Id)
                .Index(t => t.Estatus_Id)
                .Index(t => t.Producto_Id)
                .Index(t => t.Tipo_Id)
                .Index(t => t.Factura_Id);
            
            CreateTable(
                "Maestro.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoBarra = c.String(),
                        CodigoUnico = c.String(),
                        Descripcion = c.String(),
                        PVP = c.Single(nullable: false),
                        PVPMayor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Maestro.TipoDescuento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Porcentaje = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Transaccion.Factura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaFactura = c.DateTime(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        MontoBruto = c.Single(nullable: false),
                        MontoTotal = c.Single(nullable: false),
                        MontoDescuento = c.Single(nullable: false),
                        MontoPago = c.Single(nullable: false),
                        CajaFactura_Id = c.Int(),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Configuracion.Caja", t => t.CajaFactura_Id)
                .ForeignKey("Maestro.Cliente", t => t.Cliente_Id)
                .Index(t => t.CajaFactura_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "Transacion.PagoFactura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MontoPago = c.Single(nullable: false),
                        FechaPago = c.DateTime(nullable: false),
                        EstatusPago_Id = c.Int(),
                        FormaPagos_Id = c.Int(),
                        Factura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Estatus", t => t.EstatusPago_Id)
                .ForeignKey("Maestro.FormasPago", t => t.FormaPagos_Id)
                .ForeignKey("Transaccion.Factura", t => t.Factura_Id)
                .Index(t => t.EstatusPago_Id)
                .Index(t => t.FormaPagos_Id)
                .Index(t => t.Factura_Id);
            
            CreateTable(
                "Maestro.FormasPago",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Entidad = c.String(),
                        Estatus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Estatus", t => t.Estatus_Id)
                .Index(t => t.Estatus_Id);
            
            CreateTable(
                "Transaccion.ProductoFactura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Single(nullable: false),
                        Unidades = c.Single(nullable: false),
                        Peso = c.Single(nullable: false),
                        Precio = c.Single(nullable: false),
                        Descuentos_Id = c.Int(),
                        Productos_Id = c.Int(),
                        Factura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Maestro.Descuento", t => t.Descuentos_Id)
                .ForeignKey("Maestro.Producto", t => t.Productos_Id)
                .ForeignKey("Transaccion.Factura", t => t.Factura_Id)
                .Index(t => t.Descuentos_Id)
                .Index(t => t.Productos_Id)
                .Index(t => t.Factura_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Transaccion.ProductoFactura", "Factura_Id", "Transaccion.Factura");
            DropForeignKey("Transaccion.ProductoFactura", "Productos_Id", "Maestro.Producto");
            DropForeignKey("Transaccion.ProductoFactura", "Descuentos_Id", "Maestro.Descuento");
            DropForeignKey("Transacion.PagoFactura", "Factura_Id", "Transaccion.Factura");
            DropForeignKey("Transacion.PagoFactura", "FormaPagos_Id", "Maestro.FormasPago");
            DropForeignKey("Maestro.FormasPago", "Estatus_Id", "Maestro.Estatus");
            DropForeignKey("Transacion.PagoFactura", "EstatusPago_Id", "Maestro.Estatus");
            DropForeignKey("Maestro.Descuento", "Factura_Id", "Transaccion.Factura");
            DropForeignKey("Transaccion.Factura", "Cliente_Id", "Maestro.Cliente");
            DropForeignKey("Transaccion.Factura", "CajaFactura_Id", "Configuracion.Caja");
            DropForeignKey("Maestro.Descuento", "Tipo_Id", "Maestro.TipoDescuento");
            DropForeignKey("Maestro.Descuento", "Producto_Id", "Maestro.Producto");
            DropForeignKey("Maestro.Descuento", "Estatus_Id", "Maestro.Estatus");
            DropForeignKey("Maestro.Cliente", "Tipo_Id", "Maestro.TipoDocumento");
            DropForeignKey("Maestro.TipoDocumento", "EstatusDocumento_Id", "Maestro.Estatus");
            DropForeignKey("Maestro.TipoSaldo", "Clientes_Id", "Maestro.Cliente");
            DropForeignKey("Configuracion.Caja", "EstatusCaja_Id", "Maestro.Estatus");
            DropForeignKey("Maestro.Dispositivo", "Caja_Id", "Configuracion.Caja");
            DropForeignKey("Maestro.Dispositivo", "Tipo_Id", "Maestro.TipoDispositivo");
            DropIndex("Transaccion.ProductoFactura", new[] { "Factura_Id" });
            DropIndex("Transaccion.ProductoFactura", new[] { "Productos_Id" });
            DropIndex("Transaccion.ProductoFactura", new[] { "Descuentos_Id" });
            DropIndex("Maestro.FormasPago", new[] { "Estatus_Id" });
            DropIndex("Transacion.PagoFactura", new[] { "Factura_Id" });
            DropIndex("Transacion.PagoFactura", new[] { "FormaPagos_Id" });
            DropIndex("Transacion.PagoFactura", new[] { "EstatusPago_Id" });
            DropIndex("Transaccion.Factura", new[] { "Cliente_Id" });
            DropIndex("Transaccion.Factura", new[] { "CajaFactura_Id" });
            DropIndex("Maestro.Descuento", new[] { "Factura_Id" });
            DropIndex("Maestro.Descuento", new[] { "Tipo_Id" });
            DropIndex("Maestro.Descuento", new[] { "Producto_Id" });
            DropIndex("Maestro.Descuento", new[] { "Estatus_Id" });
            DropIndex("Maestro.TipoDocumento", new[] { "EstatusDocumento_Id" });
            DropIndex("Maestro.TipoSaldo", new[] { "Clientes_Id" });
            DropIndex("Maestro.Cliente", new[] { "Tipo_Id" });
            DropIndex("Maestro.Dispositivo", new[] { "Caja_Id" });
            DropIndex("Maestro.Dispositivo", new[] { "Tipo_Id" });
            DropIndex("Configuracion.Caja", new[] { "EstatusCaja_Id" });
            DropTable("Transaccion.ProductoFactura");
            DropTable("Maestro.FormasPago");
            DropTable("Transacion.PagoFactura");
            DropTable("Transaccion.Factura");
            DropTable("Maestro.TipoDescuento");
            DropTable("Maestro.Producto");
            DropTable("Maestro.Descuento");
            DropTable("Maestro.TipoDocumento");
            DropTable("Maestro.TipoSaldo");
            DropTable("Maestro.Cliente");
            DropTable("Maestro.Estatus");
            DropTable("Maestro.TipoDispositivo");
            DropTable("Maestro.Dispositivo");
            DropTable("Configuracion.Caja");
        }
    }
}
