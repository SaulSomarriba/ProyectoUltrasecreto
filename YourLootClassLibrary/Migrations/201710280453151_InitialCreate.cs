namespace YourLootClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.batch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.warehouse", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.WarehouseId);
            
            CreateTable(
                "dbo.warehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Ubication = c.Int(nullable: false),
                        Description = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.document",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.entry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeDocumentEntry = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ProviderId = c.Int(nullable: false),
                        DocumentId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.document", t => t.DocumentId, cascadeDelete: true)
                .ForeignKey("dbo.provider", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId)
                .Index(t => t.DocumentId);
            
            CreateTable(
                "dbo.provider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.entryDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        EntryId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.entry", t => t.EntryId, cascadeDelete: true)
                .ForeignKey("dbo.product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.EntryId);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Cost = c.String(nullable: false),
                        SellPrice = c.String(nullable: false),
                        BatchId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.batch", t => t.BatchId, cascadeDelete: true)
                .Index(t => t.BatchId);
            
            CreateTable(
                "dbo.inventary",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeInventary = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ProductId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.translationtDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        ProductId = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        TraslationId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.translation", t => t.TraslationId, cascadeDelete: true)
                .Index(t => t.TraslationId);
            
            CreateTable(
                "dbo.translation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        DocumentId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.document", t => t.DocumentId, cascadeDelete: true)
                .Index(t => t.DocumentId);
            
            CreateTable(
                "dbo.outputDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        OutputId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.output", t => t.OutputId, cascadeDelete: true)
                .ForeignKey("dbo.product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OutputId);
            
            CreateTable(
                "dbo.output",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeDocumentOutput = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ClientId = c.Int(nullable: false),
                        DocumentId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.document", t => t.DocumentId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.DocumentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.outputDetail", "ProductId", "dbo.product");
            DropForeignKey("dbo.outputDetail", "OutputId", "dbo.output");
            DropForeignKey("dbo.output", "DocumentId", "dbo.document");
            DropForeignKey("dbo.output", "ClientId", "dbo.client");
            DropForeignKey("dbo.translationtDetail", "TraslationId", "dbo.translation");
            DropForeignKey("dbo.translation", "DocumentId", "dbo.document");
            DropForeignKey("dbo.inventary", "ProductId", "dbo.product");
            DropForeignKey("dbo.entryDetail", "ProductId", "dbo.product");
            DropForeignKey("dbo.product", "BatchId", "dbo.batch");
            DropForeignKey("dbo.entryDetail", "EntryId", "dbo.entry");
            DropForeignKey("dbo.entry", "ProviderId", "dbo.provider");
            DropForeignKey("dbo.entry", "DocumentId", "dbo.document");
            DropForeignKey("dbo.batch", "WarehouseId", "dbo.warehouse");
            DropIndex("dbo.output", new[] { "DocumentId" });
            DropIndex("dbo.output", new[] { "ClientId" });
            DropIndex("dbo.outputDetail", new[] { "OutputId" });
            DropIndex("dbo.outputDetail", new[] { "ProductId" });
            DropIndex("dbo.translation", new[] { "DocumentId" });
            DropIndex("dbo.translationtDetail", new[] { "TraslationId" });
            DropIndex("dbo.inventary", new[] { "ProductId" });
            DropIndex("dbo.product", new[] { "BatchId" });
            DropIndex("dbo.entryDetail", new[] { "EntryId" });
            DropIndex("dbo.entryDetail", new[] { "ProductId" });
            DropIndex("dbo.entry", new[] { "DocumentId" });
            DropIndex("dbo.entry", new[] { "ProviderId" });
            DropIndex("dbo.batch", new[] { "WarehouseId" });
            DropTable("dbo.output");
            DropTable("dbo.outputDetail");
            DropTable("dbo.translation");
            DropTable("dbo.translationtDetail");
            DropTable("dbo.inventary");
            DropTable("dbo.product");
            DropTable("dbo.entryDetail");
            DropTable("dbo.provider");
            DropTable("dbo.entry");
            DropTable("dbo.document");
            DropTable("dbo.client");
            DropTable("dbo.warehouse");
            DropTable("dbo.batch");
        }
    }
}
