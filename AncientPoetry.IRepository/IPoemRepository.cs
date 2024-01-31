using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.IRepository
{
    public interface IPoemRepository : IBaseRepository<Poem>
    {
        void Update(Poem entity);
    }
}
