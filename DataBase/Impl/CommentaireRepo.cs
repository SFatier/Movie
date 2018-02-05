using DataBase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Impl
{
    public class CommentaireRepo : Repository<Commentaire>, ICommentaire 
    {
        public CommentaireRepo(ModelAPPContainer container) : base(container)
        {
        }

        public void Delete(Commentaire domainObject)
        {
            Container.CommentaireSet.Remove(domainObject);
            Container.SaveChanges();
        }

        public List<Commentaire> FindAll()
        {
            try
            {
                return Container.CommentaireSet.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Commentaire FindById(int id)
        {
            try
            {
                return Container.CommentaireSet.SingleOrDefault(u => u.Id.Equals(id));
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Commentaire domainObject)
        {
            try
            {
                Container.CommentaireSet.Add(domainObject);
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Commentaire domainObject)
        {
            try
            {
                Commentaire c = (from x in Container.CommentaireSet
                                 where x.Id == domainObject.Id
                                 select x).First();

                c.Film= domainObject.Film;
                c.Utilisateur = domainObject.Utilisateur;
                Container.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
