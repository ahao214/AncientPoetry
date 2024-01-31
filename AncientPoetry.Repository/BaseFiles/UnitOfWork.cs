﻿using AncientPoetry.DbStructure.DbContexts;
using AncientPoetry.IRepository;
using AncientPoetry.IRepository.BaseFiles;

namespace AncientPoetry.Repository.BaseFiles
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IDynastyRepository Dynasty { get; private set; }
        public IPoetRepository Poet { get; private set; }
        public IPoemRepository Poem { get; private set; }
        public IFamoutPhraseRepository FamoutPhrase { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Dynasty = new DynastyRepository(_db);
            Poet = new PoetRepository(_db);
            Poem = new PoemRepository(_db);
            FamoutPhrase = new FamoutPhraseRepository(_db);

        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
