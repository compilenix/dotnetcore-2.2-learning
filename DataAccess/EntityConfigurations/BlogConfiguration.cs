using DataAccess.Entities;

namespace DataAccess.EntityConfigurations
{
    public class BlogConfiguration : EntityTypeConfiguration<Blog>
    {
        public override void Configure()
        {
            Builder.HasKey(x => x.BlogId);
        }
    }
}