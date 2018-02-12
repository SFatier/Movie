using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class GenreRepo : Repository<Genre>, IGenre
    {
        public GenreRepo(MovieModelContainer
            container) : base(container)
        {
        }

        public void Delete(int id)
        {
            Genre g = Container.GenreSet.SingleOrDefault(o => o.Id.Equals(id));
            Container.GenreSet.Remove(g);
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

                g.Name = domainObject.Name;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
