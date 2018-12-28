using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public interface IEntityTypeConfiguration
    {
        void Configure();
        void SetBuilder(ModelBuilder builder);
    }
}