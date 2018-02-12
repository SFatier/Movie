using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Impl
{
    public class UtilisateurRepo : Repository<User>,  IUtilisateur
    {
        public UtilisateurRepo(MovieModelContainer container) : base(container)
        {
        }

        public void Delete(int id)
        {
            User domainObject = Container.UserSet.SingleOrDefault(o => o.Id.Equals(id));
            Container.UserSet.Remove(domainObject);
            Container.SaveChanges();
        }

        public List<User> FindAll()
        {
            try
            {
                return Container.UserSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public User FindById(int id)
        {
            try
            {
                return Container.UserSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(User domainObject)
        {
            try
            {
                Container.UserSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(User domainObject)
        {
            try
            {
                User u = (from x in Container.UserSet
                              where x.Id == domainObject.Id
                              select x).First();

                u.Email = domainObject.Email;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
