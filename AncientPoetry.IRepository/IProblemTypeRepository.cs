using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.IRepository
{
    public interface IProblemTypeRepository:IBaseRepository <ProblemType>
    {
        void Update(ProblemType entity);
    }
}
