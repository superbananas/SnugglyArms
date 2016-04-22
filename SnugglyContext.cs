using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Entities2
{
    public partial class SnugglyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SqlExpress;Database=Snuggly;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorizeToPickup>(entity =>
            {
                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.RelationId).HasDefaultValue(0);

                entity.HasOne(d => d.Package).WithMany(p => p.AuthorizeToPickup).HasForeignKey(d => d.PackageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Relation).WithMany(p => p.AuthorizeToPickup).HasForeignKey(d => d.RelationId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnType("char");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnType("varchar");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<CustomerPackage>(entity =>
            {
                entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPackage).HasForeignKey(d => d.CustomerId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Package).WithMany(p => p.CustomerPackage).HasForeignKey(d => d.PackageId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<LkpPackageStatus>(entity =>
            {
                entity.HasKey(e => e.PackageStatusId);

                entity.Property(e => e.PackageStatusId).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Enumeration)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<LkpPackageType>(entity =>
            {
                entity.HasKey(e => e.PackageTypeId);

                entity.Property(e => e.PackageTypeId).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Enumeration)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<LkpPickupRelation>(entity =>
            {
                entity.HasKey(e => e.PickupRelationId);

                entity.Property(e => e.PickupRelationId).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Enumeration)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<LkpSecondaryUnitType>(entity =>
            {
                entity.HasKey(e => e.SecondaryUnitTypeId);

                entity.Property(e => e.SecondaryUnitTypeId).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Enumeration)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<LkpUSState>(entity =>
            {
                entity.HasKey(e => e.USStateId);

                entity.Property(e => e.USStateId).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Enumeration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<LkpWarehouseAvailability>(entity =>
            {
                entity.HasKey(e => e.WarehouseAvailabilityId);

                entity.Property(e => e.WarehouseAvailabilityId).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar");

                entity.Property(e => e.Enumeration)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PickedUpDate).HasColumnType("datetime");

                entity.Property(e => e.RecievedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PackageStatusNavigation).WithMany(p => p.Package).HasForeignKey(d => d.PackageStatus).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PackageTypeNavigation).WithMany(p => p.Package).HasForeignKey(d => d.PackageType).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PickedupByNavigation).WithMany(p => p.PackageNavigation).HasForeignKey(d => d.PickedupBy);
            });

            modelBuilder.Entity<PackageNote>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2500)
                    .HasColumnType("varchar");

                entity.HasOne(d => d.Package).WithMany(p => p.PackageNote).HasForeignKey(d => d.PackageId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PackageReturnAddress>(entity =>
            {
                entity.Property(e => e.AddressLine)
                    .HasMaxLength(200)
                    .HasColumnType("varchar");

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SecondaryUnitValue)
                    .HasMaxLength(10)
                    .HasColumnType("varchar");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("varchar");

                entity.Property(e => e.Zip4)
                    .HasMaxLength(4)
                    .HasColumnType("char");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(5)
                    .HasColumnType("char");

                entity.HasOne(d => d.Package).WithMany(p => p.PackageReturnAddress).HasForeignKey(d => d.PackageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.SecondaryUnit).WithMany(p => p.PackageReturnAddress).HasForeignKey(d => d.SecondaryUnitId);

                entity.HasOne(d => d.USState).WithMany(p => p.PackageReturnAddress).HasForeignKey(d => d.USStateId);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Availability).HasDefaultValue(0);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnType("varchar");

                entity.HasOne(d => d.AvailabilityNavigation).WithMany(p => p.Warehouse).HasForeignKey(d => d.Availability).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<WarehouseAddress>(entity =>
            {
                entity.Property(e => e.AddressLine)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("varchar");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnType("varchar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SecondaryUnitValue)
                    .HasMaxLength(10)
                    .HasColumnType("varchar");

                entity.Property(e => e.Zip4)
                    .HasMaxLength(4)
                    .HasColumnType("char");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnType("char");

                entity.HasOne(d => d.SecondaryUnit).WithMany(p => p.WarehouseAddress).HasForeignKey(d => d.SecondaryUnitId);

                entity.HasOne(d => d.USState).WithMany(p => p.WarehouseAddress).HasForeignKey(d => d.USStateId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehouseAddress).HasForeignKey(d => d.WarehouseId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<__RefactorLog>(entity =>
            {
                entity.HasKey(e => e.OperationKey);

                entity.Property(e => e.OperationKey).ValueGeneratedNever();
            });
        }

        public virtual DbSet<AuthorizeToPickup> AuthorizeToPickup { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerPackage> CustomerPackage { get; set; }
        public virtual DbSet<LkpPackageStatus> LkpPackageStatus { get; set; }
        public virtual DbSet<LkpPackageType> LkpPackageType { get; set; }
        public virtual DbSet<LkpPickupRelation> LkpPickupRelation { get; set; }
        public virtual DbSet<LkpSecondaryUnitType> LkpSecondaryUnitType { get; set; }
        public virtual DbSet<LkpUSState> LkpUSState { get; set; }
        public virtual DbSet<LkpWarehouseAvailability> LkpWarehouseAvailability { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PackageNote> PackageNote { get; set; }
        public virtual DbSet<PackageReturnAddress> PackageReturnAddress { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WarehouseAddress> WarehouseAddress { get; set; }
        public virtual DbSet<__RefactorLog> __RefactorLog { get; set; }
    }
}