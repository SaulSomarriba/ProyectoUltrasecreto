namespace YourLootClassLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YourLootClassLibrary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YourLootClassLibrary.Context.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(YourLootClassLibrary.Context.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Client cliente = new Client();

            cliente.Id = 1;
            cliente.Name = "Raul Lezama";
            cliente.Description = "Main zed ap";
            cliente.Address = "Universidad Centroamericana";
            cliente.DateCreation = System.DateTime.Today;
            cliente.DateModification = System.DateTime.Today;

            context.Clients.AddOrUpdate(cliente);

            Document documento = new Document();

            documento.Id = 1;
            documento.Name = "Nombre de documento";
            documento.Description = "Descripcion del documento";
            documento.DateCreation = System.DateTime.Today;
            documento.DateModification = System.DateTime.Today;

            context.Documents.AddOrUpdate(documento);

            Provider proveedor = new Provider();

            proveedor.Id = 1;
            proveedor.Name = "Nombre del proveedor";
            proveedor.Description = "Descripcion del proveedor";
            proveedor.Address = "Direccion del proveedor";
            proveedor.DateCreation = System.DateTime.Today;
            proveedor.DateModification = System.DateTime.Today;

            context.Providers.AddOrUpdate(proveedor);

            Warehouse almacen = new Warehouse();

            almacen.Id = 1;
            almacen.Name = "Nombre del almacen";
            almacen.Ubication = "ubicacion del almacen";
            almacen.Description = "Descripcion del almacen";
            almacen.DateCreation = System.DateTime.Today;
            almacen.DateModification = System.DateTime.Today;

            context.Warehouses.AddOrUpdate(almacen);

            almacen.Id = 2;
            almacen.Name = "Nombre del segundo almacen";
            almacen.Ubication = "Ubicacion del segundo almacen";
            almacen.Description = "Descripcion del segundo almacen";
            almacen.DateCreation = System.DateTime.Today;
            almacen.DateModification = System.DateTime.Today;

            context.Warehouses.AddOrUpdate(almacen);

            Batch lote = new Batch();

            lote.Id = 1;
            lote.Name = "Nombre del lote";
            lote.Description = "Descripcion del lote";
            lote.WarehouseId = 1;
            lote.DateCreation = System.DateTime.Today;
            lote.DateModification = System.DateTime.Today;

            context.Batchs.AddOrUpdate(lote);

            lote.Id = 2;
            lote.Name = "nombre del lote2";
            lote.Description = "Descripcion del lote2";
            lote.WarehouseId = 1;
            lote.DateCreation = System.DateTime.Today;
            lote.DateModification = System.DateTime.Today;

            context.Batchs.AddOrUpdate(lote);

            lote.Id = 3;
            lote.Name = "Nombre del lote 3";
            lote.Description = "Descripcion del lote 3";
            lote.WarehouseId = 2;
            lote.DateCreation = System.DateTime.Today;
            lote.DateModification = System.DateTime.Today;

            context.Batchs.AddOrUpdate(lote);

            Product producto = new Product();

            producto.Id = 1;
            producto.Name = "Nombre del producto";
            producto.FullName = "Nombre completo del producto";
            producto.Description = "Descripcion del producto";
            producto.Cost = 220.54f;
            producto.SellPrice = 250.25f;
            producto.BatchId = 1;
            producto.DateCreation = System.DateTime.Today;
            producto.DateModification = System.DateTime.Today;

            context.Products.AddOrUpdate(producto);

            producto.Id = 2;
            producto.Name = "Nombre del producto2";
            producto.FullName = "Nombre completo del producto2";
            producto.Description = "Descripcion del producto2";
            producto.Cost = 10.54f;
            producto.SellPrice = 550.25f;
            producto.BatchId = 1;
            producto.DateCreation = System.DateTime.Today;
            producto.DateModification = System.DateTime.Today;

            context.Products.AddOrUpdate(producto);

            producto.Id = 3;
            producto.Name = "Nombre del producto3";
            producto.FullName = "Nombre completo del producto3";
            producto.Description = "Descripcion del producto3";
            producto.Cost = 20.54f;
            producto.SellPrice = 50.25f;
            producto.BatchId = 2;
            producto.DateCreation = System.DateTime.Today;
            producto.DateModification = System.DateTime.Today;

            context.Products.AddOrUpdate(producto);

            producto.Id = 4;
            producto.Name = "Nombre del producto4";
            producto.FullName = "Nombre completo del producto4";
            producto.Description = "Descripcion del producto4";
            producto.Cost = 1220.54f;
            producto.SellPrice = 5550.25f;
            producto.BatchId = 3;
            producto.DateCreation = System.DateTime.Today;
            producto.DateModification = System.DateTime.Today;

            context.Products.AddOrUpdate(producto);











        }
    }
}
