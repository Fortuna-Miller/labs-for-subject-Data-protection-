namespace Lab04_Skosareva
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_KEYgenerator = new System.Windows.Forms.Button();
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.labelSizeKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(151, 111);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(235, 22);
            this.textBox_fileIN.TabIndex = 0;
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(151, 158);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(235, 22);
            this.textBox_fileOUT.TabIndex = 1;
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(151, 239);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(235, 22);
            this.textBox_fileKEY.TabIndex = 2;
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(415, 111);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(75, 23);
            this.button_fileIN.TabIndex = 3;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(415, 156);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(75, 23);
            this.button_fileOUT.TabIndex = 4;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(415, 338);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Відкрити файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Зберегти у файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Файл з ключем";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тривалість шифрування: (хв:сек:мс)";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(290, 372);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(31, 16);
            this.label_time.TabIndex = 13;
            this.label_time.Text = "Час";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Файли";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ключ";
            // 
            // button_KEYgenerator
            // 
            this.button_KEYgenerator.Image = ((System.Drawing.Image)(resources.GetObject("button_KEYgenerator.Image")));
            this.button_KEYgenerator.Location = new System.Drawing.Point(214, 273);
            this.button_KEYgenerator.Name = "button_KEYgenerator";
            this.button_KEYgenerator.Size = new System.Drawing.Size(91, 36);
            this.button_KEYgenerator.TabIndex = 7;
            this.button_KEYgenerator.UseVisualStyleBackColor = true;
            this.button_KEYgenerator.Click += new System.EventHandler(this.button_KEYgenerator_Click);
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.Image = global::Lab04_Skosareva.Properties.Resources.save;
            this.button_fileKEYsave.Location = new System.Drawing.Point(415, 277);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.Size = new System.Drawing.Size(75, 44);
            this.button_fileKEYsave.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_fileKEYsave, "Зберегти");
            this.button_fileKEYsave.UseVisualStyleBackColor = true;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.Image = global::Lab04_Skosareva.Properties.Resources.file;
            this.button_fileKEYopen.Location = new System.Drawing.Point(415, 232);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(75, 36);
            this.button_fileKEYopen.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_fileKEYopen, "Відкрити");
            this.button_fileKEYopen.UseVisualStyleBackColor = true;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // labelSizeKey
            // 
            this.labelSizeKey.AutoSize = true;
            this.labelSizeKey.Location = new System.Drawing.Point(39, 273);
            this.labelSizeKey.Name = "labelSizeKey";
            this.labelSizeKey.Size = new System.Drawing.Size(96, 16);
            this.labelSizeKey.TabIndex = 16;
            this.labelSizeKey.Text = "Розмір ключа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 429);
            this.Controls.Add(this.labelSizeKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_KEYgenerator);
            this.Controls.Add(this.button_fileKEYsave);
            this.Controls.Add(this.button_fileKEYopen);
            this.Controls.Add(this.button_fileOUT);
            this.Controls.Add(this.button_fileIN);
            this.Controls.Add(this.textBox_fileKEY);
            this.Controls.Add(this.textBox_fileOUT);
            this.Controls.Add(this.textBox_fileIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XOR file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_KEYgenerator;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSizeKey;
    }
}

