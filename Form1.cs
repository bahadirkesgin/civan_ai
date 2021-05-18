using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Civan_AI_UI
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        String csvFile = @"C:\Program Files (x86)\Civan_Data\db.civan";
        String setupChecker = @"C:\Program Files (x86)\Civan_Data\scheck.civan";
        String resFile = @"C:\Program Files (x86)\Civan_Data\res.civan";
        String imageDB = @"C:\Program Files (x86)\Civan_Data\db.civan\images\";
        String projectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        String patientName { get; set; }
        String isHeartDisease { get; set; }
        String gender { get; set; }
        String age { get; set; }
        String cigesPerDay = "0";
        String BPmeds { get; set; }
        String prevalentHyp { get; set; }
        String diabetesStr { get; set; }
        String totCholStr { get; set; }
        String sysBPStr { get; set; }
        String diaBPStr { get; set; }
        String glucoseStr { get; set; }
        String imageName { get; set; }
        String imagePath;
        bool heartDisease, chTr, chEn, selecSet;
        
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selecSet) 
            {
                UpdateVariables();

                StreamWriter sw = new StreamWriter(csvFile);
                sw.Write("isHeartDisease$" +
                    "Name$Gender$BPMeds$hyp$" +
                    "diabetes$age$cigsPerDay$totChol$sysBP$" +
                    "diaBP$glucose$photo_name" + "\n");

                sw.Write(isHeartDisease +
                    "$" + patientName +
                    "$" + gender +
                    "$" + BPmeds +
                    "$" + prevalentHyp +
                    "$" + diabetesStr +
                    "$" + age +
                    "$" + cigesPerDay +
                    "$" + totCholStr +
                    "$" + sysBPStr +
                    "$" + diaBPStr +
                    "$" + glucoseStr +
                    "$" + imageName);

                sw.Close(); sw.Dispose();

                RunAIEngine();
            }
            else 
            {
                if (chTr) MessageBox.Show("Lütfen kullanım amacınızı seçiniz",
                        "Uyarı",
                        MessageBoxButtons.OK);
                if (chEn) MessageBox.Show("Please select your intended use",
                    "Warning",
                    MessageBoxButtons.OK);
            }
        }

        private void UpdateVariables()
        {
            if (heartDisease) isHeartDisease = "1";
            if (!heartDisease) isHeartDisease = "0";
            patientName = name.Text;
            gender = genderBox.SelectedItem.ToString();
            if (gender == "Male" || gender == "Erkek") gender = "1";
            if (gender == "Female" || gender == "Kadın") gender = "0";
            age = agePanel.Value.ToString();
            if (cigsPerDayCheck.Checked) cigesPerDay = cigsPerDay.Value.ToString();
            if (!cigsPerDayCheck.Checked) cigesPerDay = "0";
            if (BPMeds.Checked) BPmeds = "1";
            if (!BPMeds.Checked) BPmeds = "0";
            if (diabetes.Checked) diabetesStr = "1";
            if (hyp.Checked) prevalentHyp = "1";
            if (!hyp.Checked) prevalentHyp = "0";
            sysBPStr = sysBP.Value.ToString();
            totCholStr = totChol.Value.ToString();
            diaBPStr = diaBP.Value.ToString();
            glucoseStr = glucose.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLanguage();
            CreateMainDirectory();
        }

        private void CreateMainDirectory() 
        {
            if (System.IO.File.Exists(setupChecker) == true) {}
            else 
            {
                if (chTr) MessageBox.Show("Programın gerekli dosyaları kurması gerekiyor, lütfen bekleyiniz \n" +
                    "Bu kurulum 5 dakika kadar sürebilir.",
                        "Bilgilendirme",
                        MessageBoxButtons.OK);
                if (chEn) MessageBox.Show("Program has to setup necessary files, please wait. \n" +
                    "Setup can take up to 5 minutes.",
                    "Information",
                    MessageBoxButtons.OK);
                System.IO.File.Create(setupChecker);
                Process psi = new Process();
                psi.StartInfo.FileName = "cmd.exe";
                psi.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Civan_Data";
                psi.StartInfo.Arguments = @"/c pip install -r requirements.txt";
                psi.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Start();
                psi.WaitForExit();
                
                if (chTr) MessageBox.Show("Kurulum tamamlandı, artık yazılımı kullanabilirsiniz",
                        "Kurulum Başarılı",
                        MessageBoxButtons.OK);
                if (chEn) MessageBox.Show("Setup is complete, now you can use the software",
                        "Setup Successful",
                        MessageBoxButtons.OK);
            }
        }

        private void cigsPerDayCheck_CheckedChanged(object sender, EventArgs e)
        {
            cigsPerDay.Enabled = !cigsPerDay.Enabled;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt="Image(*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                imagePathTB.Text = imagePath;

                imageName = ofd.SafeFileName;
                try 
                {
                    File.Copy(imagePath, imageDB + imageName);
                }
                catch  {}
                finally 
                {
                    pictureBox1.ImageLocation = imagePathTB.Text;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }           
            }
            else{}            
        }

        private void langEn_Click(object sender, EventArgs e)
        {
            SetLanguage("en");
        }

        private void langTR_Click(object sender, EventArgs e)
        {
            SetLanguage("tr");
        }

        void SetLanguage(string lang = "tr") 
        {
            switch (lang)
            {
                case "en":
                    chTr = false;
                    chEn = true;
                    genderBox.Items.Clear();
                    genderBox.Items.Add("Male"); genderBox.Items.Add("Female");
                    genderBox.SelectedItem = "Male";
                    nameLabel.Text = "Name";
                    GenderLabel.Text = "Gender";
                    AgeLabel.Text = "Age";
                    cigsPerDayCheck.Text = "Cigarettes Per Day";
                    hyp.Text = "Prevalent Hypertension";
                    diabetes.Text = "Diabetes";
                    BPMeds.Text = "Blood Pressure Medication";
                    label4.Text = "Total Cholestrol";
                    label5.Text = "Systolic BP";
                    label6.Text = "Diastolic BP";
                    label7.Text = "Glucose";
                    label1.Text = "Image";
                    button1.Text = "Find";
                    label2.Text = "Chest CT scan input for COVID-19 test:";
                    label3.Text = "Please select your intended use:";
                    send.Text = "Send Data to AI"; 
                    radioButton1.Text = "Heart Disease Predcition";
                    radioButton2.Text = "COVID-19 Test";
                    button4.Text = "Credits";
                    break;

                case "tr":
                    chTr = true;
                    chEn = false;
                    genderBox.Items.Clear();
                    genderBox.Items.Add("Erkek"); genderBox.Items.Add("Kadın");
                    genderBox.SelectedItem = "Erkek";
                    nameLabel.Text = "İsim";
                    GenderLabel.Text = "Cinsiyet";
                    AgeLabel.Text = "Yaş";
                    cigsPerDayCheck.Text = "Günlük Sigara Sayısı";
                    hyp.Text = "Hipertansiyon Geçmişi";
                    diabetes.Text = "Diyabet";
                    BPMeds.Text = "Tansiyon İlacı";
                    label4.Text = "Total Kolestrol";
                    label5.Text = "Sistolik Kan Basıncı";
                    label6.Text = "Diastolik Kan Basıncı";
                    label7.Text = "Glikoz";
                    label1.Text = "Fotoğraf";
                    button1.Text = "Bul";
                    label2.Text = "COVID-19 testi için göğüs BT girişi:";
                    label3.Text = "Lütfen kullanım amacınızı seçiniz:";
                    send.Text = "Verileri Yapay Zekaya Gönder";
                    radioButton1.Text = "Kalp Hastalığı Tahmini";
                    radioButton2.Text = "COVID-19 Testi";
                    button4.Text = "Geliştiriciler";
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            heartDisease = true;
            radioButton2.Checked = false;
            imagePathTB.Enabled = false;
            button1.Enabled = false;
            EnableInputField(2);
            selecSet = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            heartDisease = false;
            radioButton1.Checked = false;
            name.Enabled = false;
            genderBox.Enabled = false;
            agePanel.Enabled = false;
            cigsPerDayCheck.Enabled = false;
            hyp.Enabled = false;
            diabetes.Enabled = false;
            BPMeds.Enabled = false;
            totChol.Enabled = false;
            sysBP.Enabled = false;
            diaBP.Enabled = false;
            glucose.Enabled = false;
            EnableInputField(1);
            selecSet = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chTr) MessageBox.Show("Geliştiriciler: Bahadır Utku Kesgin & Ömer Faruk Battır \n" +
                "İletişim mail adresi: bahadirkesgin@gmail.com ",
                        "Doktor Civan Yapay Zeka v1.0",
                        MessageBoxButtons.OK);
            if (chEn) MessageBox.Show("Developers: Bahadır Utku Kesgin & Ömer Faruk Battır \n" +
                "Contact mail adress: bahadirkesgin@gmail.com",
                "Doctor Civan Artificial Intelligence v1.0",
                MessageBoxButtons.OK);
        }

        void EnableInputField(int indicator) 
        {
            switch (indicator) 
            {
                case 1:
                    imagePathTB.Enabled = true;
                    button1.Enabled = true;
                    break;
                case 2:
                    name.Enabled = true;
                    genderBox.Enabled = true;
                    agePanel.Enabled = true;
                    cigsPerDayCheck.Enabled = true;
                    hyp.Enabled = true;
                    diabetes.Enabled = true;
                    BPMeds.Enabled = true;
                    totChol.Enabled = true;
                    sysBP.Enabled = true;
                    diaBP.Enabled = true;
                    glucose.Enabled = true;
                    break;
            }
        }

        void RunAIEngine() 
        {
            Process processStart = new Process();
            processStart.StartInfo.FileName = "cmd.exe";
            processStart.StartInfo.UseShellExecute = false;
            processStart.StartInfo.Verb = "runas";
            processStart.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            processStart.StartInfo.Arguments = @"/c python instance_test.py";
            processStart.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\Civan_Data";
            processStart.Start();
            processStart.WaitForExit();
            
            StreamReader sr = new StreamReader(resFile);
            string oku = "";

            while (!sr.EndOfStream)
            {
                oku += sr.ReadLine();
                processStart.Kill();
            }
            CheckAndMessage(oku);
        }

        void CheckAndMessage(string oku) 
        {
            if (heartDisease) 
            {
                if (oku == "positive")
                {
                    if (chTr) MessageBox.Show("10 yıl içerisinde kalp hastalığı riskiniz var",
                        "Test Sonucunuz",
                        MessageBoxButtons.OK);
                    if (chEn) MessageBox.Show("Risk of heart disease in 10 years",
                        "Test Results",
                        MessageBoxButtons.OK);
                }
                else
                {
                    if (chTr) MessageBox.Show("10 yıl içerisinde kalp hastalığı riskiniz yok",
                        "Test Sonucunuz",
                        MessageBoxButtons.OK);
                    if (chEn) MessageBox.Show("No risk of heart disease in 10 years",
                        "Test Results",
                        MessageBoxButtons.OK);
                }
            }
            else 
            {
                if (oku == "positive")
                {
                    if (chTr) MessageBox.Show("COVID-19 pozitif",
                        "Test Sonucunuz",
                        MessageBoxButtons.OK);
                    if (chEn) MessageBox.Show("COVID-19 positive",
                        "Test Results",
                        MessageBoxButtons.OK);
                }
                else
                {
                    if (chTr) MessageBox.Show("COVID-19 negatif",
                        "Test Sonucunuz",
                        MessageBoxButtons.OK);
                    if (chEn) MessageBox.Show("COVID-19 negative",
                        "Test Results",
                        MessageBoxButtons.OK);
                }
            }
            
        }
    }
}
