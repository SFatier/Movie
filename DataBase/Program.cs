using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.ReferentielManager;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /**ajout de genre **/
            Utilisateur u = new Utilisateur();
            u.Email = "fatier_s2@etna-alternance.net";

             ReferentielManager.DBConnect.Instance.InsertUtilisateur(u);
            List<Utilisateur> lstUtiliisateur = ReferentielManager.DBConnect.Instance.GetAllUtilisateur();
        }
    }
}
