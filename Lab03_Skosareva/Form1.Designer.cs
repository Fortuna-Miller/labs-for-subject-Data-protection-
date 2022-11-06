namespace Lab03_Skosareva
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_P_in = new System.Windows.Forms.TextBox();
            this.textBox_C_in = new System.Windows.Forms.TextBox();
            this.textBox_Key_in = new System.Windows.Forms.TextBox();
            this.textBox_P_out = new System.Windows.Forms.TextBox();
            this.textBox_Key_out = new System.Windows.Forms.TextBox();
            this.textBox_C_out = new System.Windows.Forms.TextBox();
            this.XOR_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_P_in
            // 
            this.textBox_P_in.Location = new System.Drawing.Point(141, 118);
            this.textBox_P_in.Name = "textBox_P_in";
            this.textBox_P_in.Size = new System.Drawing.Size(125, 27);
            this.textBox_P_in.TabIndex = 0;
            // 
            // textBox_C_in
            // 
            this.textBox_C_in.Location = new System.Drawing.Point(141, 178);
            this.textBox_C_in.Name = "textBox_C_in";
            this.textBox_C_in.Size = new System.Drawing.Size(125, 27);
            this.textBox_C_in.TabIndex = 1;
            // 
            // textBox_Key_in
            // 
            this.textBox_Key_in.Location = new System.Drawing.Point(141, 239);
            this.textBox_Key_in.Name = "textBox_Key_in";
            this.textBox_Key_in.Size = new System.Drawing.Size(125, 27);
            this.textBox_Key_in.TabIndex = 2;
            // 
            // textBox_P_out
            // 
            this.textBox_P_out.Location = new System.Drawing.Point(489, 118);
            this.textBox_P_out.Name = "textBox_P_out";
            this.textBox_P_out.Size = new System.Drawing.Size(125, 27);
            this.textBox_P_out.TabIndex = 3;
            // 
            // textBox_Key_out
            // 
            this.textBox_Key_out.Location = new System.Drawing.Point(489, 178);
            this.textBox_Key_out.Name = "textBox_Key_out";
            this.textBox_Key_out.Size = new System.Drawing.Size(125, 27);
            this.textBox_Key_out.TabIndex = 4;
            // 
            // textBox_C_out
            // 
            this.textBox_C_out.Location = new System.Drawing.Point(489, 239);
            this.textBox_C_out.Name = "textBox_C_out";
            this.textBox_C_out.Size = new System.Drawing.Size(125, 27);
            this.textBox_C_out.TabIndex = 5;
            // 
            // XOR_button
            // 
            this.XOR_button.Location = new System.Drawing.Point(328, 149);
            this.XOR_button.Name = "XOR_button";
            this.XOR_button.Size = new System.Drawing.Size(94, 29);
            this.XOR_button.TabIndex = 6;
            this.XOR_button.Text = "XOR";
            this.XOR_button.UseVisualStyleBackColor = true;
            this.XOR_button.Click += new System.EventHandler(this.XOR_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(328, 213);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(94, 29);
            this.Clear_button.TabIndex = 7;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "P =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "С =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "= P";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "= Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "= C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зашифрування";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Розшифрування";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.XOR_button);
            this.Controls.Add(this.textBox_C_out);
            this.Controls.Add(this.textBox_Key_out);
            this.Controls.Add(this.textBox_P_out);
            this.Controls.Add(this.textBox_Key_in);
            this.Controls.Add(this.textBox_C_in);
            this.Controls.Add(this.textBox_P_in);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_P_in;
        private TextBox textBox_C_in;
        private TextBox textBox_Key_in;
        private TextBox textBox_P_out;
        private TextBox textBox_Key_out;
        private TextBox textBox_C_out;
        private Button XOR_button;
        private Button Clear_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ToolTip toolTip1;
    }
}