using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Movie.Model
{
        public class UtilisateurModel { }

        public class Utilisateur : INotifyPropertyChanged
        {
            private int Id { get; set; }
            private string email;
        
             public string Email
              {
                get
                {
                    return email;
                }

                set
                {
                    if (email != value)
                    {
                    email = value;
                        RaisePropertyChanged("Email");
                        RaisePropertyChanged("InfosUtilisateur");
                    }
                }
            }
              
            public string InfosUtilisateur
            {
                get
                {
                    return "email :  " +   email + ". Id : " + Id;
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
