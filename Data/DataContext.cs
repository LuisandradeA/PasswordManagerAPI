using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Models;


namespace PasswordManagerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<SystemUser> Users {get;set;}
        public DbSet<PasswordUser> Passwords {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemUser>(user =>
            {
                user.ToTable("SystemUsers");
                user.HasKey(s => s.IdUser);
                user.Property(s => s.Username);

                user.Property(s => s.Name);
                user.Property(s => s.email);
                user.Property(s => s.Password);
                user.Property(s => s.CreationDate);
                //user.HasMany(s => s.Teachers).WithOne(t => t.School);
            });

            modelBuilder.Entity<PasswordUser>(password =>
            {
                password.ToTable("PasswordUser");
                password.HasKey(t => t.IdPasswordUser);
                password.Property(t => t.IdUser);
                password.Property(t => t.SystemName);
                password.Property(t => t.Password);
                password.Property(t => t.ReceiveNotification);
                password.Property(t => t.ExpirationDate);
                password.Property(t => t.UpdateDate);
                password.Property(t => t.CreationDate);

                //teacher.HasOne(t => t.School).WithMany(s => s.Teachers);
                //password.HasMany(t => t.Classes).WithOne(c => c.Teacher);
            });

            //modelBuilder.Entity<Class>(@class =>
            //{
            //    @class.HasKey(c => c.Id);
            //    @class.Property(c => c.Name).IsRequired();
            //    @class.HasOne(c => c.Teacher).WithMany(t => t.Classes);
            //    @class.HasMany(c => c.Students).WithOne(s => s.Class);
            //});

            //modelBuilder.Entity<Student>(student =>
            //{
            //    student.HasKey(s => s.Id);
            //    student.Property(s => s.Name).IsRequired();
            //    student.HasOne(s => s.Class).WithMany(c => c.Students);
            //});
        }

    }
}