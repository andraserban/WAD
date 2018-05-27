namespace rssMergedWithArduino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tabControlRSS = new System.Windows.Forms.TabControl();
            this.textBoxLCD = new System.Windows.Forms.TextBox();
            this.buttonWriteLCD = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxLCD = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWriteRSS = new System.Windows.Forms.Button();
            this.groupBoxRSS = new System.Windows.Forms.GroupBox();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxLCD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxRSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(236, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseMnemonic = false;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(23, 22);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(207, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // tabControlRSS
            // 
            this.tabControlRSS.Location = new System.Drawing.Point(23, 69);
            this.tabControlRSS.Name = "tabControlRSS";
            this.tabControlRSS.SelectedIndex = 0;
            this.tabControlRSS.Size = new System.Drawing.Size(288, 166);
            this.tabControlRSS.TabIndex = 2;
            // 
            // textBoxLCD
            // 
            this.textBoxLCD.Location = new System.Drawing.Point(9, 19);
            this.textBoxLCD.Multiline = true;
            this.textBoxLCD.Name = "textBoxLCD";
            this.textBoxLCD.Size = new System.Drawing.Size(185, 63);
            this.textBoxLCD.TabIndex = 3;
            // 
            // buttonWriteLCD
            // 
            this.buttonWriteLCD.Location = new System.Drawing.Point(9, 100);
            this.buttonWriteLCD.Name = "buttonWriteLCD";
            this.buttonWriteLCD.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteLCD.TabIndex = 4;
            this.buttonWriteLCD.Text = "Write";
            this.buttonWriteLCD.UseVisualStyleBackColor = true;
            this.buttonWriteLCD.Click += new System.EventHandler(this.buttonWriteLCD_Click);
            this.buttonWriteLCD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonWriteLCD_MouseClick);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(6, 19);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(60, 21);
            this.comboBoxCOM.TabIndex = 5;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 67);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 27);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxLCD
            // 
            this.groupBoxLCD.Controls.Add(this.textBoxLCD);
            this.groupBoxLCD.Controls.Add(this.buttonWriteLCD);
            this.groupBoxLCD.Location = new System.Drawing.Point(3, 12);
            this.groupBoxLCD.Name = "groupBoxLCD";
            this.groupBoxLCD.Size = new System.Drawing.Size(200, 132);
            this.groupBoxLCD.TabIndex = 7;
            this.groupBoxLCD.TabStop = false;
            this.groupBoxLCD.Text = "LCD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCOM);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Location = new System.Drawing.Point(3, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Connection";
            // 
            // buttonWriteRSS
            // 
            this.buttonWriteRSS.Location = new System.Drawing.Point(23, 252);
            this.buttonWriteRSS.Name = "buttonWriteRSS";
            this.buttonWriteRSS.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteRSS.TabIndex = 9;
            this.buttonWriteRSS.Text = "Write RSS";
            this.buttonWriteRSS.UseVisualStyleBackColor = true;
            this.buttonWriteRSS.Click += new System.EventHandler(this.buttonWriteRSS_Click);
            // 
            // groupBoxRSS
            // 
            this.groupBoxRSS.Controls.Add(this.tabControlRSS);
            this.groupBoxRSS.Controls.Add(this.buttonWriteRSS);
            this.groupBoxRSS.Controls.Add(this.textBoxURL);
            this.groupBoxRSS.Controls.Add(this.buttonAdd);
            this.groupBoxRSS.Location = new System.Drawing.Point(279, 12);
            this.groupBoxRSS.Name = "groupBoxRSS";
            this.groupBoxRSS.Size = new System.Drawing.Size(362, 281);
            this.groupBoxRSS.TabIndex = 10;
            this.groupBoxRSS.TabStop = false;
            this.groupBoxRSS.Text = "RSS";
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(668, 279);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(75, 23);
            this.btn_logOut.TabIndex = 11;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.groupBoxRSS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLCD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLCD.ResumeLayout(false);
            this.groupBoxLCD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxRSS.ResumeLayout(false);
            this.groupBoxRSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TabControl tabControlRSS;
        private System.Windows.Forms.TextBox textBoxLCD;
        private System.Windows.Forms.Button buttonWriteLCD;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxLCD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonWriteRSS;
        private System.Windows.Forms.GroupBox groupBoxRSS;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

