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
            foreach (Secteur unSecteur in this._lesSecteurs)
            {
                param = unSecteur;
            }
            return param;
        }
        public List<Secteur> GetAllSecteurs()
        {
            List<Secteur> uneListe = new List<Secteur>();
            foreach (Secteur unSecteur in this._lesSecteurs)
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
            return param.Remove(param.Count() - 1, 1);
        }

        // methode qui me renvoie 
        //le libelle de la zone de la premiere alveole

        /// <summary>
        /// methode qui me renvoie 
        ///le libelle de la zone de la premiere alveole  du deuxieme 
        ///palettier du  deuxieme secteur
        /// </summary>
        /// <param name="param">le secteur</param>
        /// <param name="param2"> le palettier</param>
        /// <param name="param3"> l'alveole</param>
        /// <returns></returns>
        public string GetZoneAlveole(int param, int param2, int param3)
        {
            string result = "";
            int i = 0;
            foreach (Secteur paramS in this.GetAllSecteurs())
            {
                if (i == param)
                {
                    i = 0;
                    foreach (Palettier paramP in paramS.LesPalettiers)
                    {
                        if (i == param2)
                        {
                            i = 0;
                            foreach (Alveole uneAlveole in paramP.LesAlveoles)
                            {
                                if (i == param3)
                                {
                                    result = uneAlveole.UneZone.LibelleZone;
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                else
                {
                    i++;
                }
            }

            return result;
        }
        public string GetZoneAlveole1ligne(int param, int param2, int param3)
        {
            return this._lesSecteurs[param].LesPalettiers[param2].LesAlveoles[param3].UneZone.LibelleZone;
        }
            #endregion
        }
}
