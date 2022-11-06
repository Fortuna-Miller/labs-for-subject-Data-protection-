using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Lab03_Skosareva
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
  
      

        void myShowToolTip(TextBox tB, byte[] arr)
        {
            
          string hexString = BitConverter.ToString(arr).Replace("-", "");
            
           
            string olotoMEbinary = null;
            foreach (char c in hexString)
            { string voithitiko = null;
                
                voithitiko = Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2);
                while (voithitiko.Length != 4) 
                { voithitiko = "0" + voithitiko; }
                olotoMEbinary += voithitiko; 
            }

            toolTip1.SetToolTip(tB, olotoMEbinary);
        }

        byte[] myXOR(byte[] arr_text, byte[] arr_key)
        {
            int len_text = arr_text.Length;
            int len_key = arr_key.Length;
          
            byte[] arr_cipher = new byte[len_text];
            for (int i = 0; i < len_text; i++)
            {
                byte p = arr_text[i];
                byte k = arr_key[i % len_key]; // mod
                byte c = (byte)(p ^ k); // XOR

                arr_cipher[i] = c;
            }
            return arr_cipher;
        }

        string myCipher(TextBox tb_text, TextBox tb_Key, TextBox tb_cipher, string cipher = "")
        {
            string text = tb_text.Text;
            byte[] arr_text;

            if (cipher == "") arr_text = System.Text.Encoding.UTF8.GetBytes(text);
            else arr_text = System.Text.Encoding.UTF8.GetBytes(cipher);
            myShowToolTip(tb_text, arr_text); // Створити підказку

            string key = tb_Key.Text;
            byte[] arr_key = System.Text.Encoding.UTF8.GetBytes(key);
            myShowToolTip(tb_Key, arr_key); // Створити підказку

           
            byte[] arr_cipher = myXOR(arr_text, arr_key);

            //string cipher = BitConverter.ToString(arr_cipher).Replace("-", "");
            cipher = System.Text.Encoding.UTF8.GetString(arr_cipher);
            tb_cipher.Text = cipher;
            myShowToolTip(tb_cipher, arr_cipher); // Створити підказку

            return cipher;
        }

        private void XOR_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Key_in.Text))
            {
                /* MessageBox.Show("Ви забули ввести ключ?");
                 textBox_Key_in.Focus();
                */
               
                    textBox_P_out.Text = textBox_P_in.Text;
                    textBox_C_out.Text = textBox_P_in.Text;
                    textBox_C_in.Text = textBox_P_in.Text;
                return;


            }


            string cipher = myCipher(textBox_P_in, textBox_Key_in, textBox_C_in); // зашифрування
            textBox_P_out.Text = textBox_C_in.Text;
            textBox_Key_out.Text = textBox_Key_in.Text;
            myCipher(textBox_P_out, textBox_Key_out, textBox_C_out, cipher); // розшифрування
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            textBox_P_in.Text = "";
            textBox_Key_in.Text = "";
            textBox_C_in.Text = "";

            textBox_P_out.Text = "";
            textBox_Key_out.Text = "";
            textBox_C_out.Text = "";
        }
    }
}

    
