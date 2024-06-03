using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinClassNotizApp {
    internal class Notiz {

        string nachricht;
        DateTime datum;
        public Notiz(string nachricht, DateTime datum) {
            this.nachricht = nachricht;
            this.datum = datum;
        }

        public override string ToString () {
            return datum.ToShortDateString() + ", " + nachricht;
        }
    }
}
