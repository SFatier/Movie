using IHM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace IHM.ViewModel
{
    public class HomeViewModel : ObservableObject, IPageViewModel
    {
        public HomeViewModel()
        {
            LoadFilms();
        }

        public string Name
        {
            get
            {
                return "Home Page";
            }
        }

        //Nom du Bindings
        public ObservableCollection<Film> Films
        {
            get;
            set;
        }

        #region [Liste des films]
        public void LoadFilms()
        {
            ObservableCollection<Model.Film> films = new ObservableCollection<Model.Film>();
            var lstutilisateur = DAO.ReferentielManager.DBConnect.Instance.GetAllUser();
            var lstFilm = DAO.ReferentielManager.DBConnect.Instance.GetAllFilm();
            foreach (var item in lstFilm)
            {
                films.Add(new Model.Film { Id = item.Id, Titre = item.Title, Resume = item.Resume, Image = item.IMG });
            }

            /*films.Add(new Model.Film { Id=1, Titre="Ca", Resume="toto"});
            films.Add(new Model.Film { Id = 2, Titre = "Hitman", Resume = "totoerzer" });
            films.Add(new Model.Film { Id = 3, Titre = "HappyBirthDead", Resume = "totozerzer" });
            films.Add(new Model.Film { Id = 4, Titre = "OneLove", Resume = "totozerzer" });
            films.Add(new Model.Film { Id = 5, Titre = "RastaRocket", Resume = "totozerzer" });
            films.Add(new Model.Film { Id = 6, Titre = "Le prof", Resume = "ldjozarj" });*/

           Films = films;
        }
        #endregion
    }
}