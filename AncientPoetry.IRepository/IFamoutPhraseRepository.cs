using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.IRepository
{
    public interface IFamoutPhraseRepository:IBaseRepository<FamoutPhrase>
    {
        void Update(FamoutPhrase entity);   
    }
}
