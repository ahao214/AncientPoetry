using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.IRepository
{
    public interface IProblemRepository : IBaseRepository<Problem>
    {
        void Update(Problem entity);
    }
}
