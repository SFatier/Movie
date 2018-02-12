using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DAO.Interface
{
	public interface ICommentaire : IDomainObjectRepository<Remark>
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

    public interface IUtilisateur : IDomainObjectRepository<User>
    {

    }
}