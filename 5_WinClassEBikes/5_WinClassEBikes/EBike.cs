using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_WinClassEBikes {
    public class EBike {
        private string rahmennummer; 
        private double gesamtkilometer, akkuladung;

        public EBike(string rahmennummer, double gesamtkilometer, double akkuladung) {

            this.rahmennummer = rahmennummer;
            this.gesamtkilometer = gesamtkilometer;
            this.akkuladung = akkuladung;

        }

        public int Akkuladung {
            get => default;
            set {
            }
        }

        public int Gesamtkilometer {
            get => default;
            set {
            }
        }

        public int Rahmennummer {
            get => default;
            set {
            }
        }

        public void Fahren (double s) {
            if(akkuladung >= 0) {
                gesamtkilometer = gesamtkilometer + s;
                akkuladung = akkuladung - (1.25 * s);
            }
            else {
                MessageBox.Show("eBike hat leider keinen Akku mehr, bitte sofort laden!");
            }
        }

        public void Laden (double t) {
            if(akkuladung <= 100) {
                akkuladung = akkuladung + (20 * t);
            }
            else {
                MessageBox.Show("eBike ist voll geladen, bitte Ladestecker rausziehen!");
            }
        }

        public override string ToString () {
            return "Rahmennummer: " + rahmennummer + " Kilometerstand: " + gesamtkilometer +  " km" + " Akkuladung: " + akkuladung + "%";
        }
    }
}