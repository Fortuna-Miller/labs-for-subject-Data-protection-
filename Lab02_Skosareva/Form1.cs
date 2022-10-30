using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02_Skosareva
{
   
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sformat = textBox_format.Text;
            int format = Convert.ToInt32(sformat, 10);

            string strP1 = textBox_P1.Text;
            int intP1 = Convert.ToInt32(strP1, format);
            string strKey1 = textBox_Key1.Text;
            int intKey1 = Convert.ToInt32(strKey1, format);

            int intC1 = intP1 ^ intKey1;
            string strC1 = Convert.ToString(intC1, format);
            textBox_C1.Text = strC1;
            textBox_C2.Text = strC1;
            textBox_P2.Text = textBox_P1.Text;
            textBox_Key2.Text = textBox_Key1.Text;

            string strPIn2 = Convert.ToString(intP1, 2);
            textBox_PIn2.Text = strPIn2;
            string strKeyIn2 = Convert.ToString(intKey1, 2);
            textBox_KeyIn2.Text = strKeyIn2;
            string strCIn2 = Convert.ToString(intC1, 2);
            textBox_CIn2.Text = strCIn2;


            string strPIn10 = Convert.ToString(intP1, 10);
            textBox_PIn10.Text = strPIn10;
            string strKeyIn10 = Convert.ToString(intKey1, 10);
            textBox_KeyIn10.Text = strKeyIn10;
            string strCIn10 = Convert.ToString(intC1, 10);
            textBox_CIn10.Text = strCIn10;


            string strPIn16 = Convert.ToString(intP1, 16);
            textBox_PIn16.Text = strPIn16;
            string strKeyIn16 = Convert.ToString(intKey1, 16);
            textBox_KeyIn16.Text = strKeyIn16;
            string strCIn16 = Convert.ToString(intC1, 16);
            textBox_CIn16.Text = strCIn16;

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_P1.Text = "";
            textBox_Key1.Text = "";
            textBox_C1.Text = "";

            textBox_P2.Text = "";
            textBox_Key2.Text = "";
            textBox_C2.Text = "";

            textBox_PIn2.Text = "";
            textBox_KeyIn2.Text = "";
            textBox_CIn2.Text = "";

            textBox_PIn10.Text = "";
            textBox_KeyIn10.Text = "";
            textBox_CIn10.Text = "";

            textBox_PIn16.Text = "";
            textBox_KeyIn16.Text = "";
            textBox_CIn16.Text = "";
        }

    
     }
}


