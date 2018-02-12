using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IHM.Model
{
    public class FilmModel { }

    public class Film : INotifyPropertyChanged
    {
        private int id;
        private string image;
        private string titre;
        private string resume;
        private int genreFK;
        private int utilisateurFK;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("Id");
                    RaisePropertyChanged("InfosFilm");
                }
            }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                if (image != value)
                {
                    id = value;
                    RaisePropertyChanged("Image");
                    RaisePropertyChanged("InfosFilm");
                }
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                if (titre != value)
                {
                    titre = value;
                    RaisePropertyChanged("Titre");
                    RaisePropertyChanged("InfosFilm");
                }
            }
        }

        public string Resume
        {
            get { return resume; }

            set
            {
                if (resume != value)
                {
                    resume = value;
                    RaisePropertyChanged("Resume");
                    RaisePropertyChanged("InfosFilm");
                }
            }
        }

        public int GenreFK
        {
            get { return genreFK; }

            set
            {
                if (genreFK != value)
                {
                    genreFK = value;
                    RaisePropertyChanged("GenreFK");
                    RaisePropertyChanged("InfosFilm");
                }
            }
        }

        public int UtilisateurFK
        {
            get { return utilisateurFK; }

            set
            {
                if (utilisateurFK != value)
                {
                    utilisateurFK = value;
                    RaisePropertyChanged("UtilisateurFK");
                    RaisePropertyChanged("InfosFilm");
                }
            }
        }

        public string InfosFilm
        {
            get
            {
                return "Id :" + id +  "Le titre est " + titre + ". Résumé : " + resume + " genreFK : " + genreFK + "UtilisateurFK" + utilisateurFK;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
