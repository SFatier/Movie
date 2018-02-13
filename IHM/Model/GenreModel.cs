using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IHM.Model
{
        public class GenreModel { }

    public class Genre : Base
    {
        private int id { get; set; }
        private string nom;

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
                    RaisePropertyChanged("id");
                    RaisePropertyChanged("InfosGenre");
                }
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                if (nom != value)
                {
                    nom = value;
                    RaisePropertyChanged("Nom");
                    RaisePropertyChanged("InfosGenre");
                }
            }
        }

        public string InfosGenre
        {
            get
            {
                return "Nom :  " + nom + ". Id : " + id;
            }
        }
    }
}
