using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.Entities;
using AncientPoetry.IRepository;
using AncientPoetry.Repository.BaseFiles;

namespace AncientPoetry.Repository
{
    public class ProblemTypeRepository : BaseRepository<ProblemType>, IProblemTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public ProblemTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProblemType entity)
        {
            _db.ProblemTypes.Update(entity);
        }
    }
}
