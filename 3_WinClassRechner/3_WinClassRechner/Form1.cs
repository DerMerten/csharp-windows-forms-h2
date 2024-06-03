using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_WinClassRechner {
    public partial class Form1 : Form {

        private double resultValue = 0;
        private string operation;
        private TextBox currentTxtBox;
        private Rechne rechner; //neu

        public Form1 () {
            InitializeComponent( );
            currentTxtBox = txtNum1;
            rechner = new Rechne( ); //neu
        }

        private void evntClickNum ( object sender, EventArgs e ) {
            if (currentTxtBox.Text == "0")
                currentTxtBox.Clear( );

            Button btnEventClickNum = ( Button ) sender;

            if (string.IsNullOrEmpty(operation)) {
                currentTxtBox = txtNum1;
            }
            else {
                currentTxtBox = txtNum2;
            }

            currentTxtBox.Text += btnEventClickNum.Text;
        }

        private void evntClickOperation ( object sender, EventArgs e ) {
            Button btnEventClickOperation = ( Button ) sender;
            operation = btnEventClickOperation.Text;
            txtOperation.Text = operation;
        }

        private void txtNum1_TextChanged ( object sender, EventArgs e ) {
            currentTxtBox = txtNum1;
        }

        private void txtNum2_TextChanged ( object sender, EventArgs e ) {
            currentTxtBox = txtNum2;
        }

        private void btnClear_Click ( object sender, EventArgs e ) {
            currentTxtBox.Text = "0";
        }

        private void txtOperation_TextChanged ( object sender, EventArgs e ) {
            if (string.IsNullOrWhiteSpace(txtOperation.Text) && string.IsNullOrWhiteSpace(operation)) {
                MessageBox.Show("Bitte geben Sie einen gültigen Operator ein.");
            }
            else {
                operation = txtOperation.Text;
            }
        }

        private void btnEqual_Click ( object sender, EventArgs e ) {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            switch (operation) {
                case "+":
                    resultValue = rechner.Add(num1, num2); //neu
                    break;
                case "-":
                    resultValue = rechner.Subtract(num1, num2); //neu
                    break;
                case "*":
                    resultValue = rechner.Multiply(num1, num2); //neu
                    break;
                case "/":
                    if (num2 != 0)
                        resultValue = rechner.Divide(num1, num2); //neu
                    else {
                        MessageBox.Show("Division durch Null ist nicht erlaubt.");
                        return;
                    }
                    break;
                default:
                    break;
            }

            lblResuFinal.Text = resultValue.ToString( );

            txtNum1.Clear( );
            txtNum2.Clear( );
            txtOperation.Clear( );

            operation = null;

            currentTxtBox = txtNum1;
        }
    }
}
