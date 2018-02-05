using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Movie.Model
{
        public class GenreModel { }

        public class Genre : INotifyPropertyChanged
        {
            private int Id { get; set; }
            private string nom;
        
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
                    return "Nom :  " +   nom + ". Id : " + Id;
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
