using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class NoteRepo : Repository<Notes> , INotes
    {
        public NoteRepo(MovieModelContainer container) : base(container)
        {
        }

        public void Delete(int id)
        {
            Notes notes = Container.NotesSet.SingleOrDefault(o => o.Id.Equals(id));
            Container.NotesSet.Remove(notes);
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
                n.User = domainObject.User;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
