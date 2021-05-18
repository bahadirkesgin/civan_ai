
namespace Civan_AI_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cigsPerDayCheck = new System.Windows.Forms.CheckBox();
            this.hyp = new System.Windows.Forms.CheckBox();
            this.diabetes = new System.Windows.Forms.CheckBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.agePanel = new System.Windows.Forms.NumericUpDown();
            this.cigsPerDay = new System.Windows.Forms.NumericUpDown();
            this.BPMeds = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totChol = new System.Windows.Forms.NumericUpDown();
            this.send = new System.Windows.Forms.Button();
            this.diaBP = new System.Windows.Forms.NumericUpDown();
            this.sysBP = new System.Windows.Forms.NumericUpDown();
            this.glucose = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imagePathTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.langEn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.langTR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totChol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glucose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cigsPerDayCheck
            // 
            this.cigsPerDayCheck.AutoSize = true;
            this.cigsPerDayCheck.Location = new System.Drawing.Point(12, 169);
            this.cigsPerDayCheck.Name = "cigsPerDayCheck";
            this.cigsPerDayCheck.Size = new System.Drawing.Size(122, 19);
            this.cigsPerDayCheck.TabIndex = 0;
            this.cigsPerDayCheck.Text = "Cigarattes Per Day";
            this.cigsPerDayCheck.UseVisualStyleBackColor = true;
            this.cigsPerDayCheck.CheckedChanged += new System.EventHandler(this.cigsPerDayCheck_CheckedChanged);
            // 
            // hyp
            // 
            this.hyp.AutoSize = true;
            this.hyp.Location = new System.Drawing.Point(12, 194);
            this.hyp.Name = "hyp";
            this.hyp.Size = new System.Drawing.Size(152, 19);
            this.hyp.TabIndex = 1;
            this.hyp.Text = "Prevalent Hypertension ";
            this.hyp.UseVisualStyleBackColor = true;
            // 
            // diabetes
            // 
            this.diabetes.AutoSize = true;
            this.diabetes.Location = new System.Drawing.Point(12, 219);
            this.diabetes.Name = "diabetes";
            this.diabetes.Size = new System.Drawing.Size(71, 19);
            this.diabetes.TabIndex = 2;
            this.diabetes.Text = "Diabetes";
            this.diabetes.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(79, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 23);
            this.name.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 87);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "İsim";
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(79, 110);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(121, 23);
            this.genderBox.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(12, 113);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(49, 15);
            this.GenderLabel.TabIndex = 6;
            this.GenderLabel.Text = "Cinsiyet";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 138);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(28, 15);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Age";
            // 
            // agePanel
            // 
            this.agePanel.Location = new System.Drawing.Point(80, 136);
            this.agePanel.Name = "agePanel";
            this.agePanel.Size = new System.Drawing.Size(43, 23);
            this.agePanel.TabIndex = 8;
            // 
            // cigsPerDay
            // 
            this.cigsPerDay.Enabled = false;
            this.cigsPerDay.Location = new System.Drawing.Point(169, 167);
            this.cigsPerDay.Name = "cigsPerDay";
            this.cigsPerDay.Size = new System.Drawing.Size(41, 23);
            this.cigsPerDay.TabIndex = 9;
            // 
            // BPMeds
            // 
            this.BPMeds.AutoSize = true;
            this.BPMeds.Location = new System.Drawing.Point(12, 245);
            this.BPMeds.Name = "BPMeds";
            this.BPMeds.Size = new System.Drawing.Size(167, 19);
            this.BPMeds.TabIndex = 10;
            this.BPMeds.Text = "Blood Pressure Medication";
            this.BPMeds.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Cholestrol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Systolic BP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Diastolic BP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Glucose";
            // 
            // totChol
            // 
            this.totChol.DecimalPlaces = 2;
            this.totChol.Location = new System.Drawing.Point(135, 274);
            this.totChol.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.totChol.Name = "totChol";
            this.totChol.Size = new System.Drawing.Size(44, 23);
            this.totChol.TabIndex = 15;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(270, 388);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(217, 28);
            this.send.TabIndex = 16;
            this.send.Text = "Send to AI";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // diaBP
            // 
            this.diaBP.DecimalPlaces = 2;
            this.diaBP.Location = new System.Drawing.Point(135, 346);
            this.diaBP.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.diaBP.Name = "diaBP";
            this.diaBP.Size = new System.Drawing.Size(44, 23);
            this.diaBP.TabIndex = 17;
            // 
            // sysBP
            // 
            this.sysBP.DecimalPlaces = 2;
            this.sysBP.Location = new System.Drawing.Point(135, 313);
            this.sysBP.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sysBP.Name = "sysBP";
            this.sysBP.Size = new System.Drawing.Size(44, 23);
            this.sysBP.TabIndex = 18;
            // 
            // glucose
            // 
            this.glucose.DecimalPlaces = 2;
            this.glucose.Location = new System.Drawing.Point(135, 382);
            this.glucose.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.glucose.Name = "glucose";
            this.glucose.Size = new System.Drawing.Size(44, 23);
            this.glucose.TabIndex = 19;
            // 
            // imagePathTB
            // 
            this.imagePathTB.Location = new System.Drawing.Point(427, 351);
            this.imagePathTB.Name = "imagePathTB";
            this.imagePathTB.Size = new System.Drawing.Size(275, 23);
            this.imagePathTB.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Image";
            // 
            // langEn
            // 
            this.langEn.AutoSize = true;
            this.langEn.BackColor = System.Drawing.Color.Transparent;
            this.langEn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("langEn.BackgroundImage")));
            this.langEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.langEn.FlatAppearance.BorderSize = 0;
            this.langEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langEn.Location = new System.Drawing.Point(676, 6);
            this.langEn.Name = "langEn";
            this.langEn.Size = new System.Drawing.Size(37, 32);
            this.langEn.TabIndex = 23;
            this.langEn.UseVisualStyleBackColor = false;
            this.langEn.Click += new System.EventHandler(this.langEn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // langTR
            // 
            this.langTR.BackColor = System.Drawing.Color.Transparent;
            this.langTR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("langTR.BackgroundImage")));
            this.langTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.langTR.FlatAppearance.BorderSize = 0;
            this.langTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langTR.Location = new System.Drawing.Point(719, 6);
            this.langTR.Name = "langTR";
            this.langTR.Size = new System.Drawing.Size(35, 32);
            this.langTR.TabIndex = 24;
            this.langTR.UseVisualStyleBackColor = false;
            this.langTR.Click += new System.EventHandler(this.langTR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "COVID -19 Testi İçin Resim:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(380, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 269);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(153, 19);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Heart Disease Predcition";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(210, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 19);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "COVID-19 Test";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Please select your purpose of usage:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Yapımcılar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 428);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.langTR);
            this.Controls.Add(this.langEn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagePathTB);
            this.Controls.Add(this.glucose);
            this.Controls.Add(this.sysBP);
            this.Controls.Add(this.diaBP);
            this.Controls.Add(this.send);
            this.Controls.Add(this.totChol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BPMeds);
            this.Controls.Add(this.cigsPerDay);
            this.Controls.Add(this.agePanel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.diabetes);
            this.Controls.Add(this.hyp);
            this.Controls.Add(this.cigsPerDayCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Doktor Civan v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totChol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glucose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cigsPerDayCheck;
        private System.Windows.Forms.CheckBox hyp;
        private System.Windows.Forms.CheckBox diabetes;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.NumericUpDown agePanel;
        private System.Windows.Forms.NumericUpDown cigsPerDay;
        private System.Windows.Forms.CheckBox BPMeds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown totChol;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.NumericUpDown diaBP;
        private System.Windows.Forms.NumericUpDown sysBP;
        private System.Windows.Forms.NumericUpDown glucose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox imagePathTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button langTR;
        private System.Windows.Forms.Button langEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}

