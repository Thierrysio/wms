using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms.Modeles
{
    class Zone
    {
        #region Attributs
        public static List<Zone> CollClasseZone = new List<Zone>();
        private int _idZone;
        private string _libelleZone;



        #endregion
        #region Constructeurs
        public Zone(int idZone, string libelleZone)
        {
            _idZone = idZone;
            _libelleZone = libelleZone;
            Zone.CollClasseZone.Add(this);
        }

        #endregion
        #region Getters - Setters
        public int IdZone { get => _idZone; set => _idZone = value; }
        public string LibelleZone { get => _libelleZone; set => _libelleZone = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
