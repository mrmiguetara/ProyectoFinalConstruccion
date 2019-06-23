using Core.Models;
using Core.Repository;

namespace Persistence.Repository
{
    public class SectionRepository : BaseRepository<Section>, ISectionRepository
    {
        public SectionRepository(GeneratorDbContext context) : base(context) {}
    }
}