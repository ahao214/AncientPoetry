using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.IRepository
{
    public interface IDynastyRepository : IBaseRepository<Dynasty>
    {
        void Update(Dynasty entity);
    }
}
