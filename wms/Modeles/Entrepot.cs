using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms.Modeles
{
    class Entrepot
    {
        #region Attributs
        public static List<Entrepot> CollClasseEntrepot = new List<Entrepot>();
        private int _idEntrepot;
        private List<Secteur> _lesSecteurs;

        #endregion
        #region Constructeurs
        public Entrepot(int idEntrepot)
        {
            _idEntrepot = idEntrepot;
            Entrepot.CollClasseEntrepot.Add(this);
            _lesSecteurs = new List<Secteur>();
        }
        #endregion
        #region Getters - Setters
        public int IdEntrepot { get => _idEntrepot; set => _idEntrepot = value; }
        //public List<Secteur> LesSecteurs { get => _lesSecteurs; set => _lesSecteurs = value; }

        #endregion
        #region Methodes
        /// creation d'une methode qui permet de recuperer 
        /// la collection entiere de secteurs
        /// 
        public Secteur GetLeDernier()
        {
            //return this._lesSecteurs[this._lesSecteurs.Count - 1];
            //return this._lesSecteurs.Last();
            Secteur param = null;
            foreach(Secteur unSecteur  in this._lesSecteurs)
            {
                param = unSecteur;
            }
            return param;
        }
        public List<Secteur> GetAllSecteurs()
        {
            List<Secteur> uneListe = new List<Secteur>();
            foreach(Secteur unSecteur in this._lesSecteurs)
            {
                uneListe.Add(unSecteur);
            }
            return uneListe;

        }

        /// methode qui ajoute un secteur à la liste
        /// 
        public void AddSecteur(Secteur param)
        {
            this._lesSecteurs.Add(param);
        }

        public string GetLesSecteursEnLigne()
        {
            string param = null;
            foreach (Secteur unSecteur in this._lesSecteurs)
            {
                param += unSecteur.IdSecteur.ToString();
                param += ",";
            }
            return param.Remove(param.Count()-1,1);
        }
        #endregion
    }
}
