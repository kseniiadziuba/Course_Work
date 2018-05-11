using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    class DbContext : System.Data.Entity.DbContext
    {
        public DbContext()
            : base("DbConnection")
        { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<VisitingCalculation> VisitingCalculations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Card>().ToTable("Cards");
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Schedule>().ToTable("Schedule");
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<VisitingCalculation>().ToTable("VisitingCalculations");

            modelBuilder.Entity<Client>().HasKey(c => c.ClientId);
            modelBuilder.Entity<Card>().HasKey(c => c.CardId);
            modelBuilder.Entity<Account>().HasKey(c => c.AccountId);
            modelBuilder.Entity<Schedule>().HasKey(s => s.ScheduleId);
            modelBuilder.Entity<Room>().HasKey(r => r.RoomId);
            modelBuilder.Entity<VisitingCalculation>().HasKey(v => v.VisitingId);

            modelBuilder.Entity<Client>().HasMany(c => c.Accounts).WithRequired(a => a.Client).HasForeignKey(c => c.ClientId);
            modelBuilder.Entity<Card>().HasMany(c => c.Accounts).WithRequired(c => c.Card).HasForeignKey(c => c.CardId);
            modelBuilder.Entity<Room>().HasMany(r => r.Schedules).WithRequired(r => r.Room).HasForeignKey(r => r.RoomId);
            modelBuilder.Entity<Account>().HasMany(a => a.VisitingCalculations).WithRequired(a => a.Account).HasForeignKey(a => a.CardId);
            modelBuilder.Entity<Schedule>().HasMany(s => s.VisitingCalculations).WithRequired(s => s.Schedule).HasForeignKey(a => a.ScheduleId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
