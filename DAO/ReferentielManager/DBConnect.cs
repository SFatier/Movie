using DAO.Impl;
using DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAO.ReferentielManager
{
    public class DBConnect
    {
        public static MovieModelContainer ct = null;
        private static DBConnect s_Instance;
        private static readonly object s_InstanceLocker = new object();

        #region [Déclaration]
        private readonly ICommentaire _Remark;
        private readonly IFilm _Film;
        private readonly IGenre _Genre;
        private readonly INotes _Note;
        private readonly IUtilisateur _User;
        #endregion

        #region [constructeur]
        private DBConnect()
        {
            _Remark = new CommentaireRepo(ct);
            _Film = new FilmRepo(ct);
            _Genre = new GenreRepo(ct);
            _Note = new NoteRepo(ct);
            _User = new UtilisateurRepo(ct);
        }
        #endregion

        #region [ Singleton ]

        public static DBConnect Instance
        {
            get
            {
                lock (s_InstanceLocker)
                {
                    if (s_Instance == null)
                        ct = new MovieModelContainer();
                        s_Instance = new DBConnect();
                }
                return s_Instance;
            }
        }
        
        #endregion [ Singleton ]

        #region [User]
        public List<User> GetAllUser()
        {
            return _User.FindAll();
        }

        public User GetUserByID(int id)
        {
            return _User.FindById(id);
        }

        public void InsertUser(User u)
        {
            _User.Insert(u);
        }

        public void UpdateUser(User u)
        {
            _User.Update(u);
        }
        #endregion

        #region [Remark]
        public List<Remark> GetAllRemark()
        {
            return _Remark.FindAll();
        }

        public Remark GetRemarkByID(int id)
        {
            return _Remark.FindById(id);
        }

        public void InsertRemark(Remark c)
        {
            _Remark.Insert(c);
        }

        public void UpdateRemark(Remark c)
        {
            _Remark.Update(c);
        }
        #endregion

        #region [Film]
        public List<Film> GetAllFilm()
        {
            return _Film.FindAll();
        }

        public Film GetFilmByID(int id)
        {
            return _Film.FindById(id);
        }

        public void InsertFilm(Film f)
        {
            _Film.Insert(f);
        }

        public void UpdateFilm(Film f)
        {
            _Film.Update(f);
        }

        public void DeleteFilm(int id)
        {
            _Film.Delete(id);
        }

        #endregion

        #region [Genre]
        public List<Genre> GetAllGenre()
        {
            return _Genre.FindAll();
        }

        public Genre GetGenreByID(int id)
        {
            return _Genre.FindById(id);
        }

        public void InsertGenre(Genre g)
        {
            _Genre.Insert(g);
        }

        public void UpdateGenre(Genre g)
        {
            _Genre.Update(g);
        }
        #endregion

        #region [Notes]
        public List<Notes> GetAllNotes()
        {
            return _Note.FindAll();
        }

        public Notes GetNotesByID(int id)
        {
            return _Note.FindById(id);
        }

        public void InsertNotes(Notes n)
        {
            _Note.Insert(n);
        }

        public void UpdateNotes(Notes n)
        {
            _Note.Update(n);
        }
        #endregion

    }
}