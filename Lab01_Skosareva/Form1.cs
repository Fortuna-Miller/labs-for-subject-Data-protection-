using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Skosareva
{
    public partial class Autorization : Form
    {
    
        private string login = "Ann";
        private string pass = "1234";
        private int numberOfTryings = 3;

        private int correctInput = 0;
        private int i = 0;

        public Autorization()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == login && textBox_password.Text == pass && numberOfTryings != i)
            {
                MessageBox.Show("Hello, " + login);
                correctInput = 1;
            }

            while (i < numberOfTryings)
            {
                if (textBox_login.Text == login && textBox_password.Text != pass)
                {
                    MessageBox.Show("Uncorrect password");
                    textBox_password.Clear();
                }

                else if (textBox_login.Text != login)
                {
                    MessageBox.Show("Uncorrect login");
                    textBox_login.Clear();
                }

                i++;
                break;
            }

            if(i == numberOfTryings && correctInput != 1)
            {
                MessageBox.Show("You have used up all 3 attempts");
            }

            if(correctInput == 1)
            {
                i = 0; 
            }
        }
    }
}
