using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.Entities;
using AncientPoetry.IRepository;
using AncientPoetry.Repository.BaseFiles;

namespace AncientPoetry.Repository
{
    public class DynastyRepository : BaseRepository<Dynasty>, IDynastyRepository
    {
        private readonly ApplicationDbContext _db;

        public DynastyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Dynasty entity)
        {
            _db.Dynasties.Update(entity);
        }
    }
}
