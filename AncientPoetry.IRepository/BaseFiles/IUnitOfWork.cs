namespace AncientPoetry.IRepository.BaseFiles
{
    public interface IUnitOfWork
    {
        IDynastyRepository Dynasty { get; }
        IPoetRepository Poet { get; }
        IPoemRepository Poem { get; }
        IFamoutPhraseRepository FamoutPhrase { get; }



        void Save();
    }
}
