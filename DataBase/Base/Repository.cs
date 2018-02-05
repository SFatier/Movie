namespace DataBase
{
    public class Repository<TDomainObject>
    {
        ModelAPPContainer _container;

        public ModelAPPContainer Container { get => _container; set => _container = value; }
        
        #region [ Constructeur ]

        public Repository(ModelAPPContainer container)
        {
            _container = container;
        }
     
        #endregion
    }
}
