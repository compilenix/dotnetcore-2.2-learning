using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess
{
    public class EntityTypeConfiguration<T> : EntityTypeBuilder<T> where T : class
    {
        protected EntityTypeConfiguration(InternalEntityTypeBuilder builder) : base(builder)
        {
        }
    }
}