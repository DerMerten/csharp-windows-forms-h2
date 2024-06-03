using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinClassGrundlagen {
    public partial class Form1 : Form {

        private List<string> TelBuch = new List<string>( );

        public Form1 () {
            InitializeComponent( );
        }

        private void btnEingabe_Click ( object sender, EventArgs e ) {
            if (!string.IsNullOrEmpty(tbNachname.Text) &&
                !string.IsNullOrEmpty(tbVorname.Text) &&
                !string.IsNullOrEmpty(tbTelefonnummer.Text)) {

                Person eintrag = new Person(tbNachname.Text, tbVorname.Text, tbTelefonnummer.Text);
                TelBuch.Add(eintrag.ToString( ));

                lData.Text = ("Datensätze: " + TelBuch.Count);
                txtBoxClear( );
            }
            else {
                MessageBox.Show("Bitte alle Felder füllen!");
            }
        }

        private void btnAusgabe_Click ( object sender, EventArgs e ) {
            lbTelefonbuch.Items.Clear( );
            for (int i = 0; i < TelBuch.Count; i++) {
                lbTelefonbuch.Items.Add(TelBuch [ i ].ToString( ));
            }
        }

        private void txtBoxClear () {
            tbVorname.Text = null;
            tbNachname.Text = null;
            tbTelefonnummer.Text = null;
        }

        private void btnSuchen_Click ( object sender, EventArgs e ) {
            for (int i = 0; i < TelBuch.Count; i++) {
                if (TelBuch [ i ].Contains(tbSearch.Text)) {
                    lbTelefonbuch.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
