using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.IRepository
{
    public interface IPoetRepository : IBaseRepository<Poet>
    {
        void Update(Poet entity);
    }
}
