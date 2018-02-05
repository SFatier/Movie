using DataBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Impl
{
    public class UtilisateurRepo : Repository<Utilisateur>,  IUtilisateur
    {
        public UtilisateurRepo(ModelAPPContainer container) : base(container)
        {
        }

        public void Delete(Utilisateur domainObject)
        {
            Container.UtilisateurSet.Remove(domainObject);
            Container.SaveChanges();
        }

        public List<Utilisateur> FindAll()
        {
            try
            {
                return Container.UtilisateurSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Utilisateur FindById(int id)
        {
            try
            {
                return Container.UtilisateurSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Utilisateur domainObject)
        {
            try
            {
                Container.UtilisateurSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Utilisateur domainObject)
        {
            try
            {
                Utilisateur u = (from x in Container.UtilisateurSet
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
