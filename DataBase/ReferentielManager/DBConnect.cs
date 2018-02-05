using DataBase.Impl;
using DataBase.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataBase.ReferentielManager
{
    public class DBConnect : DbContext
    {
        //Récupération de database
        public ModelAPPContainer ct = new ModelAPPContainer();

        #region [Déclaration]
        private readonly ICommentaire _Commentaire;
        private readonly IFilm _Film;
        private readonly IGenre _Genre;
        private readonly INotes _Note;
        private readonly IUtilisateur _Utilisateur;
        #endregion

        #region [constructeur]
        private DBConnect()
        {
            _Commentaire = new CommentaireRepo(ct);
            _Film = new FilmRepo(ct);
            _Genre = new GenreRepo(ct);
            _Note = new NoteRepo(ct);
            _Utilisateur = new UtilisateurRepo(ct);
        }
        #endregion

        #region [ Singleton ]

        private static DBConnect s_Instance;
        private static readonly object s_InstanceLocker = new object();

        public static DBConnect Instance
        {
            get
            {
                lock (s_InstanceLocker)
                {
                    if (s_Instance == null)
                        s_Instance = new DBConnect();
                }
                return s_Instance;
            }
        }
        
        #endregion [ Singleton ]

        #region [Utilisateur]
        public List<Utilisateur> GetAllUtilisateur()
        {
            return _Utilisateur.FindAll();
        }

        public Utilisateur GetUtilisateurByID(int id)
        {
            return _Utilisateur.FindById(id);
        }

        public void InsertUtilisateur(Utilisateur u)
        {
            _Utilisateur.Insert(u);
        }

        public void UpdateUtilisateur(Utilisateur u)
        {
            _Utilisateur.Update(u);
        }
        #endregion

        #region [Commentaire]
        public List<Commentaire> GetAllCommentaire()
        {
            return _Commentaire.FindAll();
        }

        public Commentaire GetCommentaireByID(int id)
        {
            return _Commentaire.FindById(id);
        }

        public void InsertCommentaire(Commentaire c)
        {
            _Commentaire.Insert(c);
        }

        public void UpdateCommentaire(Commentaire c)
        {
            _Commentaire.Update(c);
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