namespace AncientPoetry.IRepository.BaseFiles
{
    public interface IUnitOfWork
    {
        IDynastyRepository Dynasty { get; }
        IPoetRepository Poet { get; }
        IPoemRepository Poem { get; }
        IFamoutPhraseRepository FamoutPhrase { get; }
        IProblemTypeRepository ProblemType { get; }
        IProblemRepository Problem { get; }


        void Save();
    }
}
