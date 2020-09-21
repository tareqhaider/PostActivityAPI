using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Test.Core.Model;

namespace Test.Core.Config
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<CommentModel> Comments { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<PostModel> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
