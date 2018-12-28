using DataAccess.Entities;

namespace DataAccess.EntityConfigurations
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public override void Configure()
        {
            Builder.HasKey(x => x.PostId);
            Builder.HasIndex(x => x.BlogId);
        }
    }
}