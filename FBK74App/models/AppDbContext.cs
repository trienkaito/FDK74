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


            // Seed data
            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, UserName = "user1", Password = "pass1", Email = "user1@example.com", PhoneNumber = "1234567890", Type = AccountType.Member, Status = "Active", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Account { Id = 2, UserName = "admin", Password = "admin", Email = "user2@example.com", PhoneNumber = "1234567891", Type = AccountType.Admin, Status = "Inactive", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Account { Id = 3, UserName = "user3", Password = "pass3", Email = "user3@example.com", PhoneNumber = "1234567892", Type = AccountType.Member, Status = "Active", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Account { Id = 4, UserName = "user4", Password = "pass4", Email = "user4@example.com", PhoneNumber = "1234567893", Type = AccountType.Member, Status = "Inactive", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Account { Id = 5, UserName = "user5", Password = "pass5", Email = "user5@example.com", PhoneNumber = "1234567894", Type = AccountType.Member, Status = "Active", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product1", Description = "Description1", Image = "image1.jpg", Quantity = 10, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Product2", Description = "Description2", Image = "image2.jpg", Quantity = 20, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 3, Name = "Product3", Description = "Description3", Image = "image3.jpg", Quantity = 30, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 4, Name = "Product4", Description = "Description4", Image = "image4.jpg", Quantity = 40, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 5, Name = "Product5", Description = "Description5", Image = "image5.jpg", Quantity = 50, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );

            modelBuilder.Entity<ProductDetail>().HasData(
                new ProductDetail { Id = 1, ProductId = 1, Quantity = 5, BillId = 1 },
                new ProductDetail { Id = 2, ProductId = 2, Quantity = 10, BillId = 2 },
                new ProductDetail { Id = 3, ProductId = 3, Quantity = 15, BillId = 3 },
                new ProductDetail { Id = 4, ProductId = 4, Quantity = 20, BillId = 4 },
                new ProductDetail { Id = 5, ProductId = 5, Quantity = 25, BillId = 5 }
            );

            modelBuilder.Entity<Bill>().HasData(
                new Bill { Id = 1, Invoice = "INV001", RegisteredFootballFieldId = 1, Account2Id = 1, PaymentDate = DateTime.Now, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Bill { Id = 2, Invoice = "INV002", RegisteredFootballFieldId = 2, Account2Id = 2, PaymentDate = DateTime.Now, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Bill { Id = 3, Invoice = "INV003", RegisteredFootballFieldId = 3, Account2Id = 3, PaymentDate = DateTime.Now, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Bill { Id = 4, Invoice = "INV004", RegisteredFootballFieldId = 4, Account2Id = 4, PaymentDate = DateTime.Now, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Bill { Id = 5, Invoice = "INV005", RegisteredFootballFieldId = 5, Account2Id = 5, PaymentDate = DateTime.Now, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );

            modelBuilder.Entity<RegisteredFootballField>().HasData(
                new RegisteredFootballField { Id = 1, Name = "Field1", Deposit = 100.0m, Account1Id = 1, Account2Id = 2, RegistFindOppoentId = 1, FootballFieldScheduleId = 1, Date = DateTime.Now, Status = "Active", Note = "Note1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegisteredFootballField { Id = 2, Name = "Field2", Deposit = 200.0m, Account1Id = 2, Account2Id = 3, RegistFindOppoentId = 2, FootballFieldScheduleId = 2, Date = DateTime.Now, Status = "Inactive", Note = "Note2", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegisteredFootballField { Id = 3, Name = "Field3", Deposit = 300.0m, Account1Id = 3, Account2Id = 4, RegistFindOppoentId = 3, FootballFieldScheduleId = 3, Date = DateTime.Now, Status = "Active", Note = "Note3", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegisteredFootballField { Id = 4, Name = "Field4", Deposit = 400.0m, Account1Id = 4, Account2Id = 5, RegistFindOppoentId = 4, FootballFieldScheduleId = 4, Date = DateTime.Now, Status = "Inactive", Note = "Note4", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegisteredFootballField { Id = 5, Name = "Field5", Deposit = 500.0m, Account1Id = 5, Account2Id = 1, RegistFindOppoentId = 5, FootballFieldScheduleId = 5, Date = DateTime.Now, Status = "Active", Note = "Note5", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );

            modelBuilder.Entity<RegistFindOppoent>().HasData(
                new RegistFindOppoent { Id = 1, Account1Id = 1, Account2Id = 2, Name = "Opponent1", Phone = "1234567890", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Date = DateTime.Now, Power = "High", TypeOfFootballField = 1, Deposit = 100.0m, Status = 1, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegistFindOppoent { Id = 2, Account1Id = 2, Account2Id = 3, Name = "Opponent2", Phone = "1234567891", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Date = DateTime.Now, Power = "Medium", TypeOfFootballField = 2, Deposit = 200.0m, Status = 2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegistFindOppoent { Id = 3, Account1Id = 3, Account2Id = 4, Name = "Opponent3", Phone = "1234567892", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Date = DateTime.Now, Power = "Low", TypeOfFootballField = 3, Deposit = 300.0m, Status = 3, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegistFindOppoent { Id = 4, Account1Id = 4, Account2Id = 5, Name = "Opponent4", Phone = "1234567893", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Date = DateTime.Now, Power = "High", TypeOfFootballField = 1, Deposit = 400.0m, Status = 1, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new RegistFindOppoent { Id = 5, Account1Id = 5, Account2Id = 1, Name = "Opponent5", Phone = "1234567894", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Date = DateTime.Now, Power = "Medium", TypeOfFootballField = 2, Deposit = 500.0m, Status = 2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );

            modelBuilder.Entity<FootballField>().HasData(
                new FootballField { Id = 1, Name = "Field1", Price = 100.0m },
                new FootballField { Id = 2, Name = "Field2", Price = 200.0m },
                new FootballField { Id = 3, Name = "Field3", Price = 300.0m },
                new FootballField { Id = 4, Name = "Field4", Price = 400.0m },
                new FootballField { Id = 5, Name = "Field5", Price = 500.0m }
            );

            modelBuilder.Entity<FootballFieldSchedule>().HasData(
                new FootballFieldSchedule { Id = 1, FootballFieldId = 1, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Status = "Scheduled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new FootballFieldSchedule { Id = 2, FootballFieldId = 2, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Status = "Scheduled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new FootballFieldSchedule { Id = 3, FootballFieldId = 3, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Status = "Scheduled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new FootballFieldSchedule { Id = 4, FootballFieldId = 4, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Status = "Scheduled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new FootballFieldSchedule { Id = 5, FootballFieldId = 5, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), Status = "Scheduled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );



            base.OnModelCreating(modelBuilder);
        }

    }
}
