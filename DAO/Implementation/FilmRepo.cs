using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class FilmRepo : Repository<Film>, IFilm
    {

        #region [Constructeur]
        public FilmRepo(MovieModelContainer container) : base(container)
        {
        }
                #endregion

        public void Delete(int id)
        {
            Film f = Container.FilmSet.SingleOrDefault(o => o.Id.Equals(id));
            Container.FilmSet.Remove(f);
            Container.SaveChanges();
        }

        public List<Film> FindAll()
        {
            try
            {
                return Container.FilmSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Film FindById(int id)
        {
            try
            {
                return Container.FilmSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Film domainObject)
        {
            try
            {
                Container.FilmSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Film domainObject)
        {
            try
            {
                Film f = (from x in Container.FilmSet
                                 where x.Id == domainObject.Id
                                 select x).First();

                f.Title = domainObject.Title;
                f.Resume = domainObject.Resume;
                f.Genre = domainObject.Genre;
                f.User = domainObject.User;

                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
