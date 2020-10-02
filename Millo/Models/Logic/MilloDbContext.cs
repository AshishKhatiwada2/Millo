using Millo.Models.Social;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Millo.Models
{
    public partial class MilloDbContext : DbContext
    {

        public MilloDbContext()
            : base("name=MilloDbContext")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
        
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<UserClaim> UserClaims { get; set; }
        public  DbSet<UserLogin> UserLogins { get; set; }
        public  DbSet<User> Users { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<CashBank> CashBanks { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<ErrorViewModel> ErrorViewModels { get; set; }
        public DbSet<GoodsReceivedNote> GoodsReceivedNotes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<NumberSequence> NumberSequences { get; set; }
        public DbSet<PaymentReceive> PaymentReceives { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PaymentVoucher> PaymentVouchers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public DbSet<PurchaseType> PurchaseTypes { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderLine> SalesOrderLines { get; set; }
        public DbSet<SalesType> SalesTypes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentType> ShipmentTypes { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Affiliation>  Affiliations { get; set; }
        public DbSet<AffiliationType> AffiliationTypes { get; set; }
        public DbSet<EventMembership> EventMemberships { get; set; }
        public DbSet<FriendRelation> FriendRelations { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<GroupMembership> GroupMemberships { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LookingFor> LookingFors { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<MilloEvent> MilloEvents { get; set; }
        public DbSet<MilloGroup> MilloGroups { get; set; }
        public DbSet<MilloProfile> MilloProfiles { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }
        public DbSet<PhotoTag> PhotoTags { get; set; }
        public DbSet<RelationshipStatus> RelationshipStatuses { get; set; }
        public DbSet<RSVPStatus> RSVPStatuses { get; set; }
        public DbSet<School> Schools { get; set; }
        
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
    }
}
