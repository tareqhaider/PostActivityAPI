using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Core.Model;

namespace Test.Core.Config
{
    public class PostConfig : IEntityTypeConfiguration<PostModel>
    {
        public void Configure(EntityTypeBuilder<PostModel> builder)
        {
            builder.ToTable("Posts", "dbo");
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1024);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.DateCreated).IsRequired();
            builder.HasMany(p => p.Comments).WithOne()
                .HasForeignKey("PostId").IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(c => c.User).WithMany()
                .HasForeignKey(f => f.UserId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
