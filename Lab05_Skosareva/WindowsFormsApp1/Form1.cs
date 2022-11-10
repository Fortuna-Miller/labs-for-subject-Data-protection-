using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bInFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Шлях до файлу
                    string fileINpath = openFileDialog.FileName;
                    tInFilePath.Text = fileINpath;
                }
            }
        }


        private byte[] myEncoding(byte[] inArr)
        {
            byte[] result = { 0 };

            if (rB_CRC32.Checked == true)
            {
                uint a = Crc.Crc32(inArr);
                return BitConverter.GetBytes(a);
            }
            if (rB_HAVAL.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_RIPEMD160.Checked == true)
            {
                HashAlgorithm sha = RIPEMD160.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_MD5.Checked == true)
            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA1.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA256.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA384.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA512.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }

            return result;
        }

        private void bOutFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Шлях до файлу
                    string fileINpath = openFileDialog.FileName;
                    tOutFilePath.Text = fileINpath;
                }
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string fileINpath = tInFilePath.Text;
            string fileOUTpath = tOutFilePath.Text;

            if (File.Exists(fileINpath))
            {
                string dirOUTpath = Path.GetDirectoryName(fileOUTpath);
                if (Directory.Exists(dirOUTpath))
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    byte[] inArr = File.ReadAllBytes(tInFilePath.Text); // читаємо байти з файлу
                    byte[] outArr = myEncoding(inArr); //підпис
                    File.WriteAllBytes(tOutFilePath.Text, outArr); // створюємо новий файл і записуємо у нього байти
                    FileInfo fileIn = new FileInfo(fileINpath);
                    FileInfo fileOut = new FileInfo(fileOUTpath);

                    sizeInFile.Text = Convert.ToString(fileIn.Length);    
                    sizeOutFile.Text = Convert.ToString(fileOut.Length);

                    // Stop timing.
                    stopwatch.Stop();

                    // Write result.
                    label_time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
                    string result = BitConverter.ToString(outArr).Replace("-", "");
                    MessageBox.Show("У файлі записане число (контрольна сума вхідного файлу):\n" + result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Шлях до вихідного файлу не вказаний\nабо такий шлях не існує");
                    tOutFilePath.Focus();
                }
            }
            else
            {
                MessageBox.Show("Вхідний файл не існує");
                tInFilePath.Focus();
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
