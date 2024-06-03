using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace WinClassLibray {
    public class Libray {
        private string title, author, date;


        public Libray(string title, string author, string date) {
        
            this.title = title;
            this.author = author;
            this.date = date;
        }

        public override string ToString() {

            return title + ", " + author + ": " + date;
        }
    }
}