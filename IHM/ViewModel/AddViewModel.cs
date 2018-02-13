
using IHM.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace IHM.ViewModel
{
    public class AddViewModel : ObservableObject, IPageViewModel
    {

        public string Name => "Ajout d'un film";

        #region Fields

        private IHM.Model.FilmModel _currentFilm;

        //Event Button
        public ICommand CommandeNewFilm { get; set; }
        public ICommand CommandeOpenIMG { get; set; }
        #endregion

        public AddViewModel()
        {
            LoadGenres();

            CommandeNewFilm = new RelayCommand(ActionNewFilm);
            CommandeOpenIMG = new RelayCommand(OpenIMG);
        }

        #region Properties/Commands

        //Nom du Bindings
        public ObservableCollection<Genre> Genres
        {
            get;
            set;
        }

        private string title;
        public string TitleFilm
        {
            get { return this.title; }
            set
            {
                if (!string.Equals(this.title, value))
                {
                    this.title = value;
                }
            }
        }

        private string path;
        public string IMGFilm
        {
            get { return this.path; }
            set
            {
                if (!string.Equals(this.path, value))
                {
                    this.path = value;
                }
            }
        }

        private string resume;
        public string ResumeFilm
        {
            get { return this.resume; }
            set
            {
                if (!string.Equals(this.resume, value))
                {
                    this.resume = value;
                }
            }
        }

        private Genre cGenre;
        public Genre NomGenre
        {
            get { return this.cGenre; }
            set
            {
                if (!string.Equals(this.cGenre, value))
                {
                    this.cGenre = value;
                }
            }
        }

        #endregion

        #region Methods
        private void ActionNewFilm(object parametre)
        {
            string titre_film = title;
            string path_film = path;
            string resume_film = resume;

            DAO.Film f = new DAO.Film();
            f.Title = titre_film;
            f.IMG = path_film;
            f.Resume = resume_film;
            f.Genre = DAO.ReferentielManager.DBConnect.Instance.GetGenreByID(cGenre.Id);
            f.User = DAO.ReferentielManager.DBConnect.Instance.GetUserByID(1); //Renvoyer l'id de l'utilisateur
            DAO.ReferentielManager.DBConnect.Instance.InsertFilm(f);

            ClearInpt();
        }

        private void OpenIMG(object parametre)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                IMGFilm = openFileDialog.FileName;
        }

        /**
         * Clear input after Insert or Update
         * */
        private void ClearInpt()
        {
            TitleFilm = string.Empty;
            IMGFilm = string.Empty;
            NomGenre = null;
        }

        private void LoadGenres()
        {
            ObservableCollection<Model.Genre> genre = new ObservableCollection<Model.Genre>();
            var lstGenre = DAO.ReferentielManager.DBConnect.Instance.GetAllGenre();
            foreach (var item in lstGenre)
            {
                genre.Add(new Model.Genre { Id = item.Id, Nom = item.Name });
            }
            Genres = genre;
        }

        #endregion
    }
}