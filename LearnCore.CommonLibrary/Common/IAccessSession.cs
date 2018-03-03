namespace LearnCore.CommonLibrary.Common
{
    public interface IAccessSession
    {
        bool CreateSession(string user, string password);

        object GetSession();

        string UserName { get; set; }

        int UserId { get; set; }

        string ApiUrl { get; set; }

        string Authorization { get; set; }

        string ContentType { get; set; }
    }
}
