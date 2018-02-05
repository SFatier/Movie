using DataBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Impl
{
    public class FilmRepo : Repository<Film>, IFilm
    {
        public FilmRepo(ModelAPPContainer container) : base(container)
        {
        }

        public void Delete(Film domainObject)
        {
            Container.FilmSet.Remove(domainObject);
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

                f.Titre = domainObject.Titre;
                f.Resume = domainObject.Resume;
                f.Genre = domainObject.Genre;
                f.Utilisateur = domainObject.Utilisateur;

                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
