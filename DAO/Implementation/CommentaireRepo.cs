using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class CommentaireRepo : Repository<Remark>, ICommentaire 
    {
        public CommentaireRepo(MovieModelContainer container) : base(container)
        {
        }

        public void Delete(int id )
        {
            Remark domainObject = Container.RemarkSet.SingleOrDefault(o => o.Id.Equals(id));
            Container.RemarkSet.Remove(domainObject);
            Container.SaveChanges();
        }

        public List<Remark> FindAll()
        {
            try
            {
                return Container.RemarkSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Remark FindById(int id)
        {
            try
            {
                return Container.RemarkSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Remark domainObject)
        {
            try
            {
                Container.RemarkSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Remark domainObject)
        {
            try
            {
                Remark c = (from x in Container.RemarkSet
                                 where x.Id == domainObject.Id
                                 select x).First();

                c.Film= domainObject.Film;
                c.User = domainObject.User;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
