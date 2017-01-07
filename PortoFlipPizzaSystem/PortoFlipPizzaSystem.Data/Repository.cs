namespace PortoFlipPizzaSystem.Data
{
    public class Repository
    {
        private static Repository repositoryInstance;

        private Repository() 
        {
            // Here we can initilize our lists
        }

        public static Repository RepositoryInstance
        {
            get
            {
                if (repositoryInstance == null)
                {
                    repositoryInstance = new Repository();
                }

                return repositoryInstance;
            }
        }
    }
}
