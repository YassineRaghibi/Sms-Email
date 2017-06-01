using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Contact
    {
        public Contact()
        {
            // TODO: implement
        }

        public Contact(int _NumC,
        string _NomC,
        string _PrenomC,
        string _Tel,
        string _Email,
        string _VilleC,
        string _PayerC,
        string _FonctionC,
        List<Segment> Segment) {
            this._NumC = _NumC;
            this._NomC = _NomC;
            this._PrenomC = _PrenomC;
            this._Tel = _Tel;
            this._Email = _Email;
            this._VilleC = _VilleC;
            this._PayerC = _PayerC;
            this._FonctionC = _FonctionC;
            this.Segment.AddRange(Segment);
        }

        private int _NumC;
        private string _NomC;
        private string _PrenomC;
        private string _Tel;
        private string _Email;
        private string _VilleC;
        private string _PayerC;
        private string _FonctionC;
        private List<Segment> Segment = new List<Segment>();

        public List<Segment> Segment1
        {
            get { return Segment; }
            set { Segment = value; }
        }

        public int NumC
        {
            get
            {
                return _NumC;
            }
            set
            {
                if (this._NumC != value)
                    this._NumC = value;
            }
        }

        public string NomC
        {
            get
            {
                return _NomC;
            }
            set
            {
                if (this._NomC != value)
                    this._NomC = value;
            }
        }

        public string PrenomC
        {
            get
            {
                return _PrenomC;
            }
            set
            {
                if (this._PrenomC != value)
                    this._PrenomC = value;
            }
        }

        public string Tel
        {
            get
            {
                return _Tel;
            }
            set
            {
                if (this._Tel != value)
                    this._Tel = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (this._Email != value)
                    this._Email = value;
            }
        }

        public string VilleC
        {
            get
            {
                return _VilleC;
            }
            set
            {
                if (this._VilleC != value)
                    this._VilleC = value;
            }
        }

        public string PayerC
        {
            get
            {
                return _PayerC;
            }
            set
            {
                if (this._PayerC != value)
                    this._PayerC = value;
            }
        }

        public string FonctionC
        {
            get
            {
                return _FonctionC;
            }
            set
            {
                if (this._FonctionC != value)
                    this._FonctionC = value;
            }
        }

    }
}
