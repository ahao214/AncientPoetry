using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.Entities;
using AncientPoetry.IRepository;
using AncientPoetry.Repository.BaseFiles;

namespace AncientPoetry.Repository
{
    public class FamoutPhraseRepository : BaseRepository<FamoutPhrase>, IFamoutPhraseRepository
    {
        private readonly ApplicationDbContext _db;

        public FamoutPhraseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FamoutPhrase entity)
        {
            _db.FamoutPhrases.Update(entity);
        }
    }
}
