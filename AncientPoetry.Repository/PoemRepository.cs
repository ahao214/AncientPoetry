using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.Entities;
using AncientPoetry.IRepository;
using AncientPoetry.Repository.BaseFiles;

namespace AncientPoetry.Repository
{
    public class PoemRepository : BaseRepository<Poem>, IPoemRepository
    {
        private readonly ApplicationDbContext _db;

        public PoemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Poem entity)
        {
            _db.Poems.Update(entity);
        }
    }
}
