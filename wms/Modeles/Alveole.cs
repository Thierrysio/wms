using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms.Modeles
{
    class Alveole
    {
        #region Attributs
        public static List<Alveole> CollClasseAlveole = new List<Alveole>();
        private int _idAlveole;
        private int _codeDetrompeur;
        private Zone _uneZone;


        #endregion
        #region Constructeurs
        public Alveole(int idAlveole, int codeDetrompeur)
        {
            _idAlveole = idAlveole;
            _codeDetrompeur = codeDetrompeur;
            Alveole.CollClasseAlveole.Add(this);
        }
        public Alveole(int idAlveole, int codeDetrompeur, Zone uneZone)
        {
            _idAlveole = idAlveole;
            _codeDetrompeur = codeDetrompeur;
            _uneZone = uneZone;
            Alveole.CollClasseAlveole.Add(this);
        }


        #endregion
        #region Getters - Setters
        public int IdAlveole { get => _idAlveole; set => _idAlveole = value; }
        public int CodeDetrompeur { get => _codeDetrompeur; set => _codeDetrompeur = value; }
        public Zone UneZone { get => _uneZone; set => _uneZone = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
