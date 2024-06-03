using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClassLibray {
    public partial class Form1 : Form {

        List<string> librayList = new List<string>( );

        public Form1 () {
            InitializeComponent( );
        }

        private void btnAdd_Click ( object sender, EventArgs e ) {
            if (!string.IsNullOrEmpty(tbTitle.Text) &&
                !string.IsNullOrEmpty(tbAuthor.Text) &&
                !string.IsNullOrEmpty(tbDate.Text)) {

                Libray libray = new Libray(tbTitle.Text, tbAuthor.Text, tbDate.Text);
                librayList.Add(libray.ToString( ));

                lData.Text = ("Anzahl der Bücher: " + librayList.Count);



                listBox1.DataSource = null;
                listBox1.DataSource = librayList;
            }
            else {
                MessageBox.Show("Bitte alle Felder befüllen!");
            }
        }

        private void btnDele_Click ( object sender, EventArgs e ) {
            librayList.RemoveAt(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = librayList;
            lData.Text = ("Anzahl der Bücher: " + librayList.Count);

        }

        private void Form1_Load ( object sender, EventArgs e ) {
            lData.Text = ("Anzahl der Bücher: " + librayList.Count);

        }

        private void btnSearch_Click ( object sender, EventArgs e ) {
            for (int i = 0; i < librayList.Count; i++) {
                if (librayList [ i ].Contains(tbSearch.Text)) {
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
