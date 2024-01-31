namespace AncientPoetry.IRepository.BaseFiles
{
    public interface IUnitOfWork
    {
        IDynastyRepository Dynasty { get; }
        IPoetRepository Poet { get; }
        IPoemRepository Poem { get; }
        void Save();
    }
}
