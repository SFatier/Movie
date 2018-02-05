using DataBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Impl
{
    public class GenreRepo : Repository<Genre>, IGenre
    {
        public GenreRepo(ModelAPPContainer container) : base(container)
        {
        }

        public void Delete(Genre domainObject)
        {
            Container.GenreSet.Remove(domainObject);
            Container.SaveChanges();
        }

        public List<Genre> FindAll()
        {
            try
            {
                return Container.GenreSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Genre FindById(int id)
        {
            try
            {
                return Container.GenreSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Genre domainObject)
        {
            try
            {
                Container.GenreSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Genre domainObject)
        {
            try
            {
                Genre g = (from x in Container.GenreSet
                                 where x.Id == domainObject.Id
                                 select x).First();

                g.Nom = domainObject.Nom;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
