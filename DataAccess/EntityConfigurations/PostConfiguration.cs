using DataAccess.Entities;

namespace DataAccess.EntityConfigurations
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public override void Configure()
        {
            Builder.HasKey(x => x.PostId);
            Builder.HasIndex(x => x.BlogId);
            Builder.HasIndex(x => x.Title);
            Builder.Property(x => x.Content).HasMaxLength(128);
        }
    }
}