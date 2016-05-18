namespace DataLayer.DBLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RentDBModel : DbContext
    {
        public RentDBModel()
            : base("name=RentDBModelContext")
        {
        }

        public virtual DbSet<Rent> Rents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rent>()
                .Property(e => e.dogovor)
                .IsUnicode(false);

            modelBuilder.Entity<Rent>()
                .Property(e => e.EDRPOU)
                .IsUnicode(false);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Telephon)
                .IsUnicode(false);

            modelBuilder.Entity<Rent>()
                .Property(e => e.SquareArea)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Latitude)
                .HasPrecision(10, 10);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Longitude)
                .HasPrecision(10, 10);
        }
    }
}
