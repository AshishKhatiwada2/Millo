namespace Millo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedaccountandsocialclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Affiliations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NID = c.String(),
                        Status = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AffiliationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        College = c.String(),
                        HighSchool = c.String(),
                        Work = c.String(),
                        Geography = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        BillName = c.String(),
                        GoodsReceivedNoteId = c.Int(nullable: false),
                        VendorDONumber = c.String(),
                        VendorInvoiceNumber = c.String(),
                        BillDate = c.DateTimeOffset(nullable: false, precision: 7),
                        BillDueDate = c.DateTimeOffset(nullable: false, precision: 7),
                        BillTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.BillTypes",
                c => new
                    {
                        BillTypeId = c.Int(nullable: false, identity: true),
                        BillTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BillTypeId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(nullable: false),
                        Description = c.String(),
                        CurrencyId = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.CashBanks",
                c => new
                    {
                        CashBankId = c.Int(nullable: false, identity: true),
                        CashBankName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CashBankId);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyId = c.Int(nullable: false, identity: true),
                        CurrencyName = c.String(nullable: false),
                        CurrencyCode = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CurrencyId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        CustomerTypeId = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        CustomerTypeId = c.Int(nullable: false, identity: true),
                        CustomerTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CustomerTypeId);
            
            CreateTable(
                "dbo.ErrorViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventMemberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FriendRelations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreFriends = c.Boolean(nullable: false),
                        UserId1 = c.String(),
                        UserId2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Unspecified = c.String(),
                        Male = c.Boolean(nullable: false),
                        Female = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoodsReceivedNotes",
                c => new
                    {
                        GoodsReceivedNoteId = c.Int(nullable: false, identity: true),
                        GoodsReceivedNoteName = c.String(),
                        PurchaseOrderId = c.Int(nullable: false),
                        GRNDate = c.DateTimeOffset(nullable: false, precision: 7),
                        VendorDONumber = c.String(),
                        VendorInvoiceNumber = c.String(),
                        WarehouseId = c.Int(nullable: false),
                        IsFullReceive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GoodsReceivedNoteId);
            
            CreateTable(
                "dbo.GroupMemberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        GroupId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceName = c.String(),
                        ShipmentId = c.Int(nullable: false),
                        InvoiceDate = c.DateTimeOffset(nullable: false, precision: 7),
                        InvoiceDueDate = c.DateTimeOffset(nullable: false, precision: 7),
                        InvoiceTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "dbo.InvoiceTypes",
                c => new
                    {
                        InvoiceTypeId = c.Int(nullable: false, identity: true),
                        InvoiceTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceTypeId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LookingFors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dating = c.String(),
                        Friendship = c.String(),
                        RandomPlay = c.String(),
                        Relationship = c.String(),
                        Unspecified = c.String(),
                        WhateverIcanGet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotReplied = c.String(),
                        Member = c.String(),
                        Officer = c.String(),
                        Admin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MilloEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Creator = c.String(),
                        Description = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        UpdatedTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        EventId = c.String(),
                        EventSubtype = c.String(),
                        EventType = c.String(),
                        Host = c.String(),
                        LargePicture = c.String(),
                        MediumPicture = c.String(),
                        SmallPicture = c.String(),
                        Location = c.String(),
                        Name = c.String(),
                        NetworkId = c.String(),
                        TagLine = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MilloGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Creator = c.String(),
                        Description = c.String(),
                        GroupId = c.String(),
                        GroupSubType = c.String(),
                        GroupType = c.String(),
                        LargePicture = c.String(),
                        MediumPicture = c.String(),
                        SmallPicture = c.String(),
                        Name = c.String(),
                        NetworkId = c.String(),
                        Office = c.String(),
                        RecentNews = c.String(),
                        UpdatedTime = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MilloProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AboutMe = c.String(),
                        Activities = c.String(),
                        AffiliationCount = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        FavoriteMovies = c.String(),
                        FavoriteBooks = c.String(),
                        FavoriteMusic = c.String(),
                        FavoriteTVShows = c.String(),
                        FavoriteQuotes = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NickName = c.String(),
                        MiddleName = c.String(),
                        Interest = c.String(),
                        IsApplicationUser = c.String(),
                        NotesCount = c.Int(nullable: false),
                        PictureBigURL = c.String(),
                        PictureSmallURL = c.String(),
                        PictureURL = c.String(),
                        PoliticalViews = c.String(),
                        Religion = c.String(),
                        SchoolCount = c.Int(nullable: false),
                        SignificantOtherId = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        UserId = c.String(),
                        WallCount = c.Int(nullable: false),
                        WebAddFriendLink = c.String(),
                        WebNotesByUserLink = c.String(),
                        WebPicturesByUserLink = c.String(),
                        WebPicturesOfUserLink = c.String(),
                        WebPokeLink = c.String(),
                        WebPostOnUserWallLink = c.String(),
                        WebSendMessageLink = c.String(),
                        WorkPlaceCount = c.Int(nullable: false),
                        FriendsCount = c.Int(nullable: false),
                        FollowingCount = c.Int(nullable: false),
                        FollowersCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NumberSequences",
                c => new
                    {
                        NumberSequenceId = c.Int(nullable: false, identity: true),
                        NumberSequenceName = c.String(nullable: false),
                        Module = c.String(nullable: false),
                        Prefix = c.String(nullable: false),
                        LastNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NumberSequenceId);
            
            CreateTable(
                "dbo.PaymentReceives",
                c => new
                    {
                        PaymentReceiveId = c.Int(nullable: false, identity: true),
                        PaymentReceiveName = c.String(),
                        InvoiceId = c.Int(nullable: false),
                        PaymentDate = c.DateTimeOffset(nullable: false, precision: 7),
                        PaymentTypeId = c.Int(nullable: false),
                        PaymentAmount = c.Double(nullable: false),
                        IsFullPayment = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentReceiveId);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        PaymentTypeId = c.Int(nullable: false, identity: true),
                        PaymentTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.PaymentTypeId);
            
            CreateTable(
                "dbo.PaymentVouchers",
                c => new
                    {
                        PaymentvoucherId = c.Int(nullable: false, identity: true),
                        PaymentVoucherName = c.String(),
                        BillId = c.Int(nullable: false),
                        PaymentDate = c.DateTimeOffset(nullable: false, precision: 7),
                        PaymentTypeId = c.Int(nullable: false),
                        PaymentAmount = c.Double(nullable: false),
                        CashBankId = c.Int(nullable: false),
                        IsFullPayment = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentvoucherId);
            
            CreateTable(
                "dbo.PhotoAlbums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoverPhotoId = c.String(),
                        Created = c.DateTime(nullable: false),
                        Description = c.String(),
                        Location = c.String(),
                        Modified = c.DateTime(nullable: false),
                        Name = c.String(),
                        Size = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlbumId = c.String(),
                        Caption = c.String(),
                        Created = c.DateTime(nullable: false),
                        LargeSoruce = c.String(),
                        Link = c.String(),
                        MediumSource = c.String(),
                        Owner = c.String(),
                        PhotoId = c.String(),
                        SmallSource = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhotoTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhotoId = c.String(),
                        Position = c.String(),
                        User = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductCode = c.String(),
                        Barcode = c.String(),
                        Description = c.String(),
                        ProductImageUrl = c.String(),
                        UnitOfMeasureId = c.Int(nullable: false),
                        DefaultBuyingPrice = c.Double(nullable: false),
                        DefaultSellingPrice = c.Double(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        ProductTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.PurchaseOrderLines",
                c => new
                    {
                        PurchaseOrderLineId = c.Int(nullable: false, identity: true),
                        PurchaseOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Description = c.String(),
                        Quantity = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Amount = c.Double(nullable: false),
                        DiscountPercentage = c.Double(nullable: false),
                        DiscountAmount = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        TaxPercentage = c.Double(nullable: false),
                        TaxAmount = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderLineId)
                .ForeignKey("dbo.PurchaseOrders", t => t.PurchaseOrderId, cascadeDelete: true)
                .Index(t => t.PurchaseOrderId);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        PurchaseOrderId = c.Int(nullable: false, identity: true),
                        PurchaseOrderName = c.String(),
                        BranchId = c.Int(nullable: false),
                        VendorId = c.Int(nullable: false),
                        OrderDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeliveryDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CurrencyId = c.Int(nullable: false),
                        PurchaseTypeId = c.Int(nullable: false),
                        Remarks = c.String(),
                        Amount = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        Freight = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderId);
            
            CreateTable(
                "dbo.PurchaseTypes",
                c => new
                    {
                        PurchaseTypeId = c.Int(nullable: false, identity: true),
                        PurchaseTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.PurchaseTypeId);
            
            CreateTable(
                "dbo.RelationshipStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Engaged = c.Boolean(nullable: false),
                        InAnOpenRelationship = c.Boolean(nullable: false),
                        InARelationship = c.Boolean(nullable: false),
                        IsSingle = c.Boolean(nullable: false),
                        ItsComplicated = c.Boolean(nullable: false),
                        Married = c.Boolean(nullable: false),
                        Unspecified = c.Boolean(nullable: false),
                        User1 = c.String(),
                        User2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RSVPStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Attending = c.Boolean(nullable: false),
                        Declined = c.Boolean(nullable: false),
                        NotReplied = c.Boolean(nullable: false),
                        NotSpecified = c.Boolean(nullable: false),
                        Unsure = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesOrderLines",
                c => new
                    {
                        SalesOrderLineId = c.Int(nullable: false, identity: true),
                        SalesOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Description = c.String(),
                        Quantity = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Amount = c.Double(nullable: false),
                        DiscountPercentage = c.Double(nullable: false),
                        DiscountAmount = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        TaxPercentage = c.Double(nullable: false),
                        TaxAmount = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SalesOrderLineId)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrderId, cascadeDelete: true)
                .Index(t => t.SalesOrderId);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        SalesOrderId = c.Int(nullable: false, identity: true),
                        SalesOrderName = c.String(),
                        BranchId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        OrderDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeliveryDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CurrencyId = c.Int(nullable: false),
                        CustomerRefNumber = c.String(),
                        SalesTypeId = c.Int(nullable: false),
                        Remarks = c.String(),
                        Amount = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        Freight = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SalesOrderId);
            
            CreateTable(
                "dbo.SalesTypes",
                c => new
                    {
                        SalesTypeId = c.Int(nullable: false, identity: true),
                        SalesTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SalesTypeId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Concentrations = c.String(),
                        GraduationYear = c.Int(nullable: false),
                        Name = c.String(),
                        SchoolId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        ShipmentId = c.Int(nullable: false, identity: true),
                        ShipmentName = c.String(),
                        SalesOrderId = c.Int(nullable: false),
                        ShipmentDate = c.DateTimeOffset(nullable: false, precision: 7),
                        ShipmentTypeId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        IsFullShipment = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ShipmentId);
            
            CreateTable(
                "dbo.ShipmentTypes",
                c => new
                    {
                        ShipmentTypeId = c.Int(nullable: false, identity: true),
                        ShipmentTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ShipmentTypeId);
            
            CreateTable(
                "dbo.UnitOfMeasures",
                c => new
                    {
                        UnitOfMeasureId = c.Int(nullable: false, identity: true),
                        UnitOfMeasureName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.UnitOfMeasureId);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserProfileId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        OldPassword = c.String(),
                        ProfilePicture = c.String(),
                        ApplicationUserId = c.String(),
                    })
                .PrimaryKey(t => t.UserProfileId);
            
            CreateTable(
                "dbo.UserStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        VendorName = c.String(nullable: false),
                        VendorTypeId = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.VendorId);
            
            CreateTable(
                "dbo.VendorTypes",
                c => new
                    {
                        VendorTypeId = c.Int(nullable: false, identity: true),
                        VendorTypeName = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.VendorTypeId);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseId = c.Int(nullable: false, identity: true),
                        WarehouseName = c.String(nullable: false),
                        Description = c.String(),
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WarehouseId);
            
            CreateTable(
                "dbo.WorkPlaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Description = c.String(),
                        EndDate = c.DateTime(nullable: false),
                        Position = c.String(),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesOrderLines", "SalesOrderId", "dbo.SalesOrders");
            DropForeignKey("dbo.PurchaseOrderLines", "PurchaseOrderId", "dbo.PurchaseOrders");
            DropIndex("dbo.SalesOrderLines", new[] { "SalesOrderId" });
            DropIndex("dbo.PurchaseOrderLines", new[] { "PurchaseOrderId" });
            DropTable("dbo.WorkPlaces");
            DropTable("dbo.Warehouses");
            DropTable("dbo.VendorTypes");
            DropTable("dbo.Vendors");
            DropTable("dbo.UserStatus");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.UnitOfMeasures");
            DropTable("dbo.ShipmentTypes");
            DropTable("dbo.Shipments");
            DropTable("dbo.Schools");
            DropTable("dbo.SalesTypes");
            DropTable("dbo.SalesOrders");
            DropTable("dbo.SalesOrderLines");
            DropTable("dbo.RSVPStatus");
            DropTable("dbo.RelationshipStatus");
            DropTable("dbo.PurchaseTypes");
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.PurchaseOrderLines");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.PhotoTags");
            DropTable("dbo.Photos");
            DropTable("dbo.PhotoAlbums");
            DropTable("dbo.PaymentVouchers");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.PaymentReceives");
            DropTable("dbo.NumberSequences");
            DropTable("dbo.MilloProfiles");
            DropTable("dbo.MilloGroups");
            DropTable("dbo.MilloEvents");
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.LookingFors");
            DropTable("dbo.Locations");
            DropTable("dbo.InvoiceTypes");
            DropTable("dbo.Invoices");
            DropTable("dbo.GroupMemberships");
            DropTable("dbo.GoodsReceivedNotes");
            DropTable("dbo.Genders");
            DropTable("dbo.FriendRelations");
            DropTable("dbo.EventMemberships");
            DropTable("dbo.ErrorViewModels");
            DropTable("dbo.CustomerTypes");
            DropTable("dbo.Customers");
            DropTable("dbo.Currencies");
            DropTable("dbo.CashBanks");
            DropTable("dbo.Branches");
            DropTable("dbo.BillTypes");
            DropTable("dbo.Bills");
            DropTable("dbo.AffiliationTypes");
            DropTable("dbo.Affiliations");
        }
    }
}
