namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("Maestro.Descuento", "Factura_Id", c => c.Int());
            AddColumn("Transacion.PagoFactura", "Factura_Id", c => c.Int());
            AddColumn("Transaccion.ProductoFactura", "Factura_Id", c => c.Int());
            CreateIndex("Maestro.Descuento", "Factura_Id");
            CreateIndex("Transacion.PagoFactura", "Factura_Id");
            CreateIndex("Transaccion.ProductoFactura", "Factura_Id");
            AddForeignKey("Maestro.Descuento", "Factura_Id", "Transaccion.Factura", "Id");
            AddForeignKey("Transacion.PagoFactura", "Factura_Id", "Transaccion.Factura", "Id");
            AddForeignKey("Transaccion.ProductoFactura", "Factura_Id", "Transaccion.Factura", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Transaccion.ProductoFactura", "Factura_Id", "Transaccion.Factura");
            DropForeignKey("Transacion.PagoFactura", "Factura_Id", "Transaccion.Factura");
            DropForeignKey("Maestro.Descuento", "Factura_Id", "Transaccion.Factura");
            DropForeignKey("Transaccion.Factura", "Cliente_Id", "Maestro.Cliente");
            DropForeignKey("Transaccion.Factura", "CajaFactura_Id", "Configuracion.Caja");
            DropIndex("Transaccion.ProductoFactura", new[] { "Factura_Id" });
            DropIndex("Transacion.PagoFactura", new[] { "Factura_Id" });
            DropIndex("Transaccion.Factura", new[] { "Cliente_Id" });
            DropIndex("Transaccion.Factura", new[] { "CajaFactura_Id" });
            DropIndex("Maestro.Descuento", new[] { "Factura_Id" });
            DropColumn("Transaccion.ProductoFactura", "Factura_Id");
            DropColumn("Transacion.PagoFactura", "Factura_Id");
            DropColumn("Maestro.Descuento", "Factura_Id");
            DropTable("Transaccion.Factura");
        }
    }
}
