namespace AncientPoetry.IRepository.BaseFiles
{
    public interface IUnitOfWork
    {
        IDynastyRepository Dynasty { get; }
        void Save();
    }
}
