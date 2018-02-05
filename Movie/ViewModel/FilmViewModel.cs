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

        //Nom du Bindings
        public ObservableCollection<Film> Films
        {
            get;
            set;
        }

        public void LoadFilms()
        {
            ObservableCollection<Film> films = new ObservableCollection<Film>();
            
            films.Add(new Film { Titre = "Allen", Resume = "Brown", GenreFK = 1, UtilisateurFK = 1 });
            films.Add(new Film { Titre = "Linda", Resume = "Hamerski" , GenreFK = 1, UtilisateurFK = 1 });

            Films = films;
        }
    }
}
