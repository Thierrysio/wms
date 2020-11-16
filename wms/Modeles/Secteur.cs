using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms.Modeles
{
    class Secteur
    {
        #region Attributs
        public static List<Secteur> CollClasseSecteur = new List<Secteur>();
        private int _idSecteur;
        private List<Palettier> _lesPalettiers;
        #endregion
        #region Constructeurs
        public Secteur(int idSecteur)
        {
            _idSecteur = idSecteur;
            _lesPalettiers = new List<Palettier>();
            Secteur.CollClasseSecteur.Add(this);
        }

        #endregion
        #region Getters - Setters
        public int IdSecteur { get => _idSecteur; set => _idSecteur = value; }
        public List<Palettier> LesPalettiers { get => _lesPalettiers; set => _lesPalettiers = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
