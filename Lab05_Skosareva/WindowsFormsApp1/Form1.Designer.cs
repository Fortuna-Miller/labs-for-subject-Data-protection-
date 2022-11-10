namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.bInFile = new System.Windows.Forms.Button();
            this.bOutFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeInFile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeOutFile = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tInFilePath
            // 
            this.tInFilePath.Location = new System.Drawing.Point(232, 79);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(249, 22);
            this.tInFilePath.TabIndex = 0;
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Location = new System.Drawing.Point(232, 125);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(249, 22);
            this.tOutFilePath.TabIndex = 1;
            // 
            // bInFile
            // 
            this.bInFile.Location = new System.Drawing.Point(515, 77);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(75, 23);
            this.bInFile.TabIndex = 2;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.bInFile_Click);
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(515, 125);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(75, 23);
            this.bOutFile.TabIndex = 3;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вхідний файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вихідний файл";
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.Location = new System.Drawing.Point(65, 216);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(70, 20);
            this.rB_CRC32.TabIndex = 6;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.Location = new System.Drawing.Point(65, 256);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(116, 20);
            this.rB_HAVAL.TabIndex = 7;
            this.rB_HAVAL.TabStop = true;
            this.rB_HAVAL.Text = "HashAlgorithm";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(65, 296);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(101, 20);
            this.rB_RIPEMD160.TabIndex = 8;
            this.rB_RIPEMD160.TabStop = true;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.Location = new System.Drawing.Point(65, 340);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(56, 20);
            this.rB_MD5.TabIndex = 9;
            this.rB_MD5.TabStop = true;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.Location = new System.Drawing.Point(191, 340);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(81, 20);
            this.rB_SHA512.TabIndex = 13;
            this.rB_SHA512.TabStop = true;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.Location = new System.Drawing.Point(191, 296);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(81, 20);
            this.rB_SHA384.TabIndex = 12;
            this.rB_SHA384.TabStop = true;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.Location = new System.Drawing.Point(191, 256);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(81, 20);
            this.rB_SHA256.TabIndex = 11;
            this.rB_SHA256.TabStop = true;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rB_SHA1.Location = new System.Drawing.Point(191, 216);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(67, 20);
            this.rB_SHA1.TabIndex = 10;
            this.rB_SHA1.TabStop = true;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Режим роботи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Розмір вхідного файлу(Б):";
            // 
            // sizeInFile
            // 
            this.sizeInFile.AutoSize = true;
            this.sizeInFile.Location = new System.Drawing.Point(440, 206);
            this.sizeInFile.Name = "sizeInFile";
            this.sizeInFile.Size = new System.Drawing.Size(28, 16);
            this.sizeInFile.TabIndex = 16;
            this.sizeInFile.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Розмір вихідного файлу(Б):";
            // 
            // sizeOutFile
            // 
            this.sizeOutFile.AutoSize = true;
            this.sizeOutFile.Location = new System.Drawing.Point(440, 274);
            this.sizeOutFile.Name = "sizeOutFile";
            this.sizeOutFile.Size = new System.Drawing.Size(28, 16);
            this.sizeOutFile.TabIndex = 18;
            this.sizeOutFile.Text = "???";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(390, 390);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(91, 23);
            this.bStart.TabIndex = 20;
            this.bStart.Text = "Виконати";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(498, 390);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(83, 23);
            this.bClean.TabIndex = 21;
            this.bClean.Text = "Очистити";
            this.bClean.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Тривалість кодування";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(426, 340);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(28, 16);
            this.label_time.TabIndex = 23;
            this.label_time.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "(хв:сек:мс)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.sizeOutFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sizeInFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rB_SHA512);
            this.Controls.Add(this.rB_SHA384);
            this.Controls.Add(this.rB_SHA256);
            this.Controls.Add(this.rB_SHA1);
            this.Controls.Add(this.rB_MD5);
            this.Controls.Add(this.rB_RIPEMD160);
            this.Controls.Add(this.rB_HAVAL);
            this.Controls.Add(this.rB_CRC32);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.bInFile);
            this.Controls.Add(this.tOutFilePath);
            this.Controls.Add(this.tInFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tInFilePath;
        private System.Windows.Forms.TextBox tOutFilePath;
        private System.Windows.Forms.Button bInFile;
        private System.Windows.Forms.Button bOutFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sizeInFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sizeOutFile;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label7;
    }
}

