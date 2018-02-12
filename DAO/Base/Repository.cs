namespace DAO
{
    public class Repository<TDomainObject>
    {
        MovieModelContainer _container;

        public MovieModelContainer Container { get => _container; set => _container = value; }
        
        #region [ Constructeur ]

        public Repository(MovieModelContainer container)
        {
            _container = container;
        }
     
        #endregion
    }
}
