using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.Entities;
using AncientPoetry.IRepository;
using AncientPoetry.Repository.BaseFiles;

namespace AncientPoetry.Repository
{
    public class PoetRepository : BaseRepository<Poet>, IPoetRepository
    {
        private readonly ApplicationDbContext _db;

        public PoetRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Poet entity)
        {
            _db.Poets.Update(entity);
        }
    }
}
