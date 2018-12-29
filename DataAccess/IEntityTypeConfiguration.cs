using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public interface IEntityTypeConfiguration
    {
        void Configure();
        void RegisterEntityOnModel(ModelBuilder builder);
    }
}