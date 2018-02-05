using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
