using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinClassNotizApp {
    public partial class Form1 : Form {

        public Form1 () {
            InitializeComponent( );
        }

        List<string> notizen = new List<string>( );
        int currentIndex = 0;

        private void btnSave_Click ( object sender, EventArgs e ) {
            if (!string.IsNullOrEmpty(tbMessage.Text)) {

                Notiz n = new Notiz(tbMessage.Text, DateTime.Now.Date);
                tbMessage.Text = null;

                try {
                    using (StreamWriter sw = new StreamWriter("data.csv", true)) {
                        sw.WriteLine(n.ToString( ));
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Bitte gültige Notiz eingeben!");
            }
        }

        private void btnNext_Click ( object sender, EventArgs e ) {
            printList( );
            currentIndex++;
            if (currentIndex >= notizen.Count) {
                currentIndex = 0;
            }
            else {
                tbMain.Text = notizen [ currentIndex ];
            }
        }

        private void printList () {
            notizen.Clear( );
            try {
                using (StreamReader sr = new StreamReader("data.csv", true)) {
                    string line = "";
                    while ((line = sr.ReadLine( )) != null) {
                        notizen.Add(line);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerNext_Tick ( object sender, EventArgs e ) {
            btnNext_Click(sender, e);
        }

        private void cbAuto_CheckedChanged ( object sender, EventArgs e ) {
            if (cbAuto.Checked) {
                timerNext.Start( );
            }
            else {
                timerNext.Stop( );
            }

        }
    }
}
