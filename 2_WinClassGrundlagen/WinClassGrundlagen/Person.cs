using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClassGrundlagen {
    internal class Person {
        
        private string vorname, nachname, telNum;
        
        public Person ( string nachname, string vorname, string telNum) {

                this.nachname = nachname;
                this.vorname = vorname;
                this.telNum = telNum;
        }

        public override string ToString () {
            
            return nachname + " ," + vorname + " -> " + telNum;

        }
    }
}
