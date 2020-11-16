using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms.Modeles
{
    class Palettier
    {
        #region Attributs
        public static List<Palettier> CollClassePalettier = new List<Palettier>();
        private int _idPalettier;
        private int _allee;
        private int _chargeMaximale;
        private List<Alveole> _lesAlveoles;


        #endregion
        #region Constructeurs
        public Palettier(int idPalettier, int allee, int chargeMaximale)
        {
            _idPalettier = idPalettier;
            _allee = allee;
            _chargeMaximale = chargeMaximale;
            _lesAlveoles = new List<Alveole>();
            Palettier.CollClassePalettier.Add(this);
        }


        #endregion
        #region Getters - Setters
        public int IdPalettier { get => _idPalettier; set => _idPalettier = value; }
        public int Allee { get => _allee; set => _allee = value; }
        public int ChargeMaximale { get => _chargeMaximale; set => _chargeMaximale = value; }
        public List<Alveole> LesAlveoles { get => _lesAlveoles; set => _lesAlveoles = value; }

        #endregion
        #region Methodes
        #endregion
    }
}
