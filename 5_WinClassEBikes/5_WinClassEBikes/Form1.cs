using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_WinClassEBikes {
    public partial class FeBikeManager : Form {
        public FeBikeManager () {
            InitializeComponent( );
        }

        List<string> listeEBike = new List<string> {
            "Rahmennummer: XY1234 Kilometerstand: 20 km Akkuladung: 75%",
            "Rahmennummer: CV4567 Kilometerstand: 111 km Akkuladung: 100%",
            "Rahmennummer: GH4767 Kilometerstand: 222 km Akkuladung: 50%",
            "Rahmennummer: TZ2567 Kilometerstand: 333 km Akkuladung: 10%"
        };


        private void btnAdd_Click ( object sender, EventArgs e ) {
            if(!string.IsNullOrEmpty(tbRahmennummer.Text) &&
                !string.IsNullOrEmpty(tbLadung.Text) &&
                !string.IsNullOrEmpty(tbKilometerstand.Text)) {

                EBike eBike = new EBike(tbRahmennummer.Text, double.Parse(tbLadung.Text), double.Parse(tbKilometerstand.Text));
                listeEBike.Add(eBike.ToString());
                txtClear( );
                updateList( );
            }
            else {
                MessageBox.Show("Bitte alle Felder Befüllen!");
            }
        }

        private void btnDrive_Click ( object sender, EventArgs e ) {
            
        }

        private void btnCharge_Click ( object sender, EventArgs e ) {

        }

        private void txtClear() {
            tbRahmennummer.Text = null;
            tbLadung.Text = null;
            tbKilometerstand.Text = null;
        }

        private void updateList() {
            lbListeBike.DataSource = null;
            lbListeBike.DataSource = listeEBike;
        }

        private void FeBikeManager_Load ( object sender, EventArgs e ) {
            updateList();
        }
    }
}
