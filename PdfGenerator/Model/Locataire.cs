using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGenerator
{
    class Locataire : INotifyPropertyChanged
    {
        private string _Nom1;
        private string _Nom2;
        private string _Adresse;
        private string _ComplementAdresse;
        private string _CodePostal;
        private string _Ville;
        private double _Loyer;
        private double _Charges;
        private double _Total;

        public string NOM1 { get => _Nom1; set => _Nom1 = value; }
        public string NOM2 { get => _Nom2; set => _Nom2 = value; }
        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public string ComplementAdresse { get => _ComplementAdresse; set => _ComplementAdresse = value; }
        public string CodePostal { get => _CodePostal; set => _CodePostal = value; }
        public string Ville { get => _Ville; set => _Ville = value; }
        public double Loyer
        {
            get => _Loyer;
            set
            {
                _Loyer = value;
                this.OnPropertyChanged("Total");
            }
        }
        public double Charges
        {
            get => _Charges;
            set
            {
                _Charges = value;
                this.OnPropertyChanged("Total");
            }

        }

        public double Total
        {
            get
            {
                return this.Charges + this.Loyer;
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(
                    this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
