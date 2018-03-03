namespace LearnCore.CommonLibrary.Client.TestRespository
{
    public class TestRepositoryManager : ITestRepositoryManager
    {
        #region Public Properties
        public UserRepo UserRepo { get; set; }
        #endregion

        #region Constructor
        public TestRepositoryManager()
        {
            Init();
        }
        #endregion

        #region Public Methods
        public void Init()
        {
            UserRepo = new UserRepo();
        }        
        #endregion
    }
}
