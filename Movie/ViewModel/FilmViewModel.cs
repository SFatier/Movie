using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie.Model;
using System.Collections.ObjectModel;

namespace Movie.ViewModel
{
    public class FilmViewModel
    {
        public FilmViewModel()
        {
            LoadFilms();
        }

        //Nom du Bindings
        public ObservableCollection<Film> Films
        {
            get;
            set;
        }

        public void LoadFilms()
        {
            ObservableCollection<Model.Film> films = new ObservableCollection<Model.Film>();
            var lstFilm = DataBase.ReferentielManager.DBConnect.Instance.GetAllFilm();
            foreach (var item in lstFilm)
            {
                films.Add(new Model.Film { Titre = item.Titre, Resume = item.Resume });
            }
            Films = films;
        }
    }
}
