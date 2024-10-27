using Microsoft.EntityFrameworkCore;

namespace FBK74App.models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<RegisteredFootballField> RegisteredFootballFields { get; set; }
        public DbSet<RegistFindOppoent> RegistFindOppoents { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<FootballField> FootballFields { get; set; }
        public DbSet<FootballFieldSchedule> FootballFieldSchedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistFindOppoent>()
                .HasOne(r => r.Account1)
                .WithMany()
                .HasForeignKey(r => r.Account1Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RegistFindOppoent>()
                .HasOne(r => r.Account2)
                .WithMany()
                .HasForeignKey(r => r.Account2Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RegisteredFootballField>()
                .HasOne(r => r.Account1)
                .WithMany()
                .HasForeignKey(r => r.Account1Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RegisteredFootballField>()
                .HasOne(r => r.Account2)
                .WithMany()
                .HasForeignKey(r => r.Account2Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Bill>()
                .HasOne(b => b.RegisteredFootballField)
                .WithMany()
                .HasForeignKey(b => b.RegisteredFootballFieldId)
                .OnDelete(DeleteBehavior.Cascade); // Keep cascade for this one

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Account2)
                .WithMany()
                .HasForeignKey(b => b.Account2Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Change the delete behavior for RegistFindOppoentId
            modelBuilder.Entity<RegisteredFootballField>()
                .HasOne(r => r.RegistFindOppoent)
                .WithMany()
                .HasForeignKey(r => r.RegistFindOppoentId)
                .OnDelete(DeleteBehavior.Restrict); // Change this line

            modelBuilder.Entity<FootballField>()
                .Property(f => f.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<RegistFindOppoent>()
                .Property(r => r.Deposit)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<RegisteredFootballField>()
                .Property(r => r.Deposit)
                .HasColumnType("decimal(18,2)");


            base.OnModelCreating(modelBuilder);
        }

    }
}
