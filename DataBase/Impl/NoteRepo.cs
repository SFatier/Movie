using DataBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Impl
{
    public class NoteRepo : Repository<Notes> , INotes
    {
        public NoteRepo(ModelAPPContainer container) : base(container)
        {
        }

        public void Delete(Notes domainObject)
        {
            Container.NotesSet.Remove(domainObject);
            Container.SaveChanges();
        }

        public List<Notes> FindAll()
        {
            try
            {
                return Container.NotesSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Notes FindById(int id)
        {
            try
            {
                return Container.NotesSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Notes domainObject)
        {
            try
            {
                Container.NotesSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Notes domainObject)
        {
            try
            {
                Notes n = (from x in Container.NotesSet
                                 where x.Id == domainObject.Id
                                 select x).First();

                n.Film = domainObject.Film;
                n.Utilisateur = domainObject.Utilisateur;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
