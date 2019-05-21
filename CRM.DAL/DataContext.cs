namespace CRM.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CRM.Entity;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRole { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Leads)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Note)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeRole)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Leads)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phone>()
                .Property(e => e.Phone1)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .HasMany(e => e.EmployeeRole)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);
        }
    }
}
