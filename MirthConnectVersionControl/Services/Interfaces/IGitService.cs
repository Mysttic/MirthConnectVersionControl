namespace MirthConnectVersionControl.Services.Interfaces
{
    public interface IGitService
    {
        void InitializeRepository();
        void ProcessChange(string dbType, string id, string name, string revision, string content);
        bool IsRepositoryValid();
    }
}
