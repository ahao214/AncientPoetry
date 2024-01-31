using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.Entities;
using AncientPoetry.IRepository;
using AncientPoetry.Repository.BaseFiles;

namespace AncientPoetry.Repository
{
    public class ProblemRepository : BaseRepository<Problem>, IProblemRepository
    {
        private readonly ApplicationDbContext _db;

        public ProblemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Problem entity)
        {
            _db.Problems.Update(entity);
        }
    }
}
