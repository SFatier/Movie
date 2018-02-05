using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase.Interface
{
	public interface ICommentaire : IDomainObjectRepository<Commentaire>
    {

    }

    public interface IFilm : IDomainObjectRepository<Film>
    {

    }

    public interface IGenre : IDomainObjectRepository<Genre>
    {

    }

    public interface INotes : IDomainObjectRepository<Notes>
    {

    }

    public interface IUtilisateur : IDomainObjectRepository<Utilisateur>
    {

    }
}