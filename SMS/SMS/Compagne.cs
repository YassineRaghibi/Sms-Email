using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Compagne
    {
        public Compagne()
        {
            // TODO: implement
        }

        private int _Num;
        private string _Nom;
        private DateTime _DateDebut;
        private DateTime _DateFin;

        public Compagne( 
                        int _Num,
                        string _Nom,
                        DateTime _DateDebut,
                        DateTime _DateFin) {
            this._Num = _Num;
            this._Nom = _Nom;
            this.DateDebut = _DateDebut;
            this._DateFin = _DateFin;
        }

        public int Num
        {
            get
            {
                return _Num;
            }
            set
            {
                if (this._Num != value)
                    this._Num = value;
            }
        }

        public string Nom
        {
            get
            {
                return _Nom;
            }
            set
            {
                if (this._Nom != value)
                    this._Nom = value;
            }
        }

        public DateTime DateDebut
        {
            get
            {
                return _DateDebut;
            }
            set
            {
                if (this._DateDebut != value)
                    this._DateDebut = value;
            }
        }

        public DateTime DateFin
        {
            get
            {
                return _DateFin;
            }
            set
            {
                if (this._DateFin != value)
                    this._DateFin = value;
            }
        }
    }
}
