using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Core.Model;

namespace Test.Core.Config
{
    public class CommentConfig : IEntityTypeConfiguration<CommentModel>
    {
        public void Configure(EntityTypeBuilder<CommentModel> builder)
        {
            builder.ToTable("Comments", "dbo");
            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.Description).IsRequired().HasMaxLength(1024);
            builder.Property(c => c.DateCreated).IsRequired();
            builder.Property(c => c.Likes).IsRequired(false);
            builder.Property(c => c.Dislikes).IsRequired(false);
            builder.HasOne(c => c.User).WithMany()
                .HasForeignKey(f => f.UserId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
