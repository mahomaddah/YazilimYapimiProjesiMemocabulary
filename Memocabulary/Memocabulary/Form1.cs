using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memocabulary
{
    

    public partial class Form1 : Form
    {
        // Tone singletone;
        //List<WordList> Desteler;
        Tone singletone = Tone.Instance();
       // List<WordList> Desteler = new List<WordList>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordList tempDeste = new WordList();

            if (textBox1.Text == "         Yeni Destem")
                MessageBox.Show("Lütfen aşağıdaki alandan yeni desteniz için yeni bir isim seçip sonra tekrar deneyiniz...");
            else
            {
               // Desteler = singletone.GetDeste();
                tempDeste.Name = textBox1.Text.ToLower();               
                singletone.DesteEkle(tempDeste);
               // Desteler = new List<WordList>();
                foreach (WordList w in singletone.GetDesteler())
                {
                    if(w.Name!=null && comboBox1.Items.Contains(w.Name) == false)
                    comboBox1.Items.Add(w.Name);
                }
            }                    
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ista().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)

        {    if (comboBox1.SelectedItem==null)
            {
                MessageBox.Show("Her hangi bir deste seçmediniz. hiç yoksa yeni birtane oluşturabilirsiniz.");
            }
            else
            {
                this.Hide();
                Kelime_Ekle k = new Kelime_Ekle();
                k.DesteIsminiAl(comboBox1.Text.ToString());
                k.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Her hangi bir deste seçmediniz. hiç yoksa yeni birtane oluşturabilirsiniz.");
            }
            else
            {
                radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false;
                radioButton4.Checked = false; radioButton5.Checked = false;
                Sonuc.Visible = false;
                labelEnglishWord.Visible = true;
                labelKindOfWord.Visible = true;
                labelOrnekCumle.Visible = true;                
                button5.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;

                //dogru cevap siklar[0] dir
                int[] rastgele = new int[5];
                //Word[] Siklar = new Word[5];
                WordList SoruListesi = new WordList();                
                rastgele = RasgeleSirala2();
                Word[] Siklar = new Word[5];
                if (singletone.GetDesteByName(comboBox1.Text.ToString()).KelimeSor() == null) { MessageBox.Show("Tebrikler!!! bu desteyi şimdilik tamamladınız..."); }
                else
                {
                    Siklar = singletone.GetDesteByName(comboBox1.Text.ToString()).KelimeSor();
                    labelEnglishWord.Text = "English: " + Siklar[0].EnlishName;
                    labelKindOfWord.Text = "Kind: " + Siklar[0].WordKind;
                    labelOrnekCumle.Text = "Exemple: " + Siklar[0].ExampleSentence;
                    //test kodu
                 //   MessageBox.Show(rastgele[0] + "\n" + rastgele[1] + "\n" + rastgele[2] + "\n" + rastgele[3] + "\n" + rastgele[4] + "\n");
                    radioButton1.Text = Siklar[rastgele[0]].TurkishName;
                    radioButton2.Text = Siklar[rastgele[1]].TurkishName;
                    radioButton3.Text = Siklar[rastgele[2]].TurkishName;
                    radioButton4.Text = Siklar[rastgele[3]].TurkishName;
                    radioButton5.Text = Siklar[rastgele[4]].TurkishName;

                    if (radioButton1.Checked == true && radioButton1.Text == Siklar[0].TurkishName || radioButton2.Checked == true && radioButton2.Text == Siklar[0].TurkishName || radioButton3.Checked == true && radioButton3.Text == Siklar[0].TurkishName || radioButton4.Checked == true && radioButton4.Text == Siklar[0].TurkishName || radioButton5.Checked == true && radioButton5.Text == Siklar[0].TurkishName)
                    {
                        Sonuc.Text = "Sonuc: Doğru Bildiniz!!!";
                        Sonuc.Visible = true;
                        Siklar[0].DogruCombosu++;
                        if (Siklar[0].DogruCombosu == 1) { singletone.GetDesteByName(comboBox1.Text.ToString()).GetWordByName(Siklar[0].EnlishName).WillAskDateTime.AddSeconds(30); }
                        else if (Siklar[0].DogruCombosu == 2) { singletone.GetDesteByName(comboBox1.Text.ToString()).GetWordByName(Siklar[0].EnlishName).WillAskDateTime.AddSeconds(60); }
                        else if (Siklar[0].DogruCombosu == 3) { singletone.GetDesteByName(comboBox1.Text.ToString()).GetWordByName(Siklar[0].EnlishName).WillAskDateTime.AddDays(1); }
                        else if (Siklar[0].DogruCombosu == 4) { singletone.GetDesteByName(comboBox1.Text.ToString()).GetWordByName(Siklar[0].EnlishName).WillAskDateTime.AddMonths(1); }
                        else if (Siklar[0].DogruCombosu == 5) { singletone.GetDesteByName(comboBox1.Text.ToString()).GetWordByName(Siklar[0].EnlishName).WillAskDateTime.AddMonths(6); }
                        else if (Siklar[0].DogruCombosu > 5) { singletone.GetDesteByName(comboBox1.Text.ToString()).KelimeSil(singletone.GetDesteByName(comboBox1.Text.ToString()).GetWordByName(Siklar[0].EnlishName)); }
                    }
                    else
                    {
                        Sonuc.Text = "Sonuc: " + Siklar[0].TurkishName;
                        Sonuc.Visible = true;
                        Siklar[0].DogruCombosu = 0;
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelEnglishWord.Visible = false;
            labelKindOfWord.Visible = false;
            labelOrnekCumle.Visible = false;
            Sonuc.Visible = false;
            button5.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;

            foreach (WordList w in singletone.GetDesteler()) {
                if(w.Name!=null && comboBox1.Items.Contains(w.Name)==false)
                comboBox1.Items.Add(w.Name); }

            Word temp = new Word();
            temp.EnlishName = "hammer";
            temp.TurkishName = "çekiç";
            temp.WordKind = "Noun";
            temp.ExampleSentence = "Use a hammer and nail set to drive them below the surface.";
            Word temp2 = new Word();
            temp2.EnlishName = "mamer";
            temp2.TurkishName = "samer";
            temp2.WordKind = "Noun";
            temp2.ExampleSentence = "Use a hammer and nail set to drive them below the surface.";
            Word temp3 = new Word();
            temp3.EnlishName = "lammer";
            temp3.TurkishName = "ekiç";
            temp3.WordKind = "Noun";
            temp3.ExampleSentence = "Use a hammer and nail set to drive them below the surface.";
            Word temp4 = new Word();
            temp4.EnlishName = "mer";
            temp4.TurkishName = "sameldr";
            temp4.WordKind = "Noun";
            temp4.ExampleSentence = "Use a hammer and nail set to drive them below the surface.";
            Word temp5 = new Word();
            temp5.EnlishName = "hammder";
            temp5.TurkishName = "çeksdiç";
            temp5.WordKind = "Noun";
            temp5.ExampleSentence = "Use a hammer and nail set to drive them below the surface.";
            Word temp6 = new Word();
            temp6.EnlishName = "malmker";
            temp6.TurkishName = "samkjer";
            temp6.WordKind = "Noun";
            temp6.ExampleSentence = "Use a hammer and nail set to drive them below the surface.";
            singletone.GetDesteByName("tools").KelimeEkle(temp);
            singletone.GetDesteByName("tools").KelimeEkle(temp2);
            singletone.GetDesteByName("tools").KelimeEkle(temp3);
            singletone.GetDesteByName("tools").KelimeEkle(temp4);
            singletone.GetDesteByName("tools").KelimeEkle(temp5);
            singletone.GetDesteByName("tools").KelimeEkle(temp6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button3 un aynisi
        }
        private int[] RasgeleSirala()
        {
            Random random = new Random();
            int A = 0;
            
            
            int n=0;
            int[] vitrin = new int[6];
            foreach(int i in vitrin)
            {
                n++;
                vitrin[i] += n;
            }
            int[] Cikti = new int[6];
         
            for (int j=0;j<5;j++)
            {
                if (j!= 0)
                {
                    do
                    {
                        A = random.Next(1,6);
                        if(vitrin[A - 1] != 0) {
                            Cikti[j] = vitrin[A-1];
                            vitrin[A - 1] = 0;
                        }
                    } while (vitrin[A - 1] !=0);
                }
                else
                {
                    A = random.Next(1, 6);
                    Cikti[0]=vitrin[A - 1];
                    vitrin[A - 1] = 0;
                }
            }
            return Cikti;

        }
        private int[] RasgeleSirala2()
        {
            int[] Cikti = new int[5];
            Random r = new Random();
            Cikti[0] = r.Next(0, 5);
            do
            {
                Cikti[1] = r.Next(0, 5);
            }
            while (Cikti[0] == Cikti[1]);
            do
            {
                Cikti[2] = r.Next(0, 5);
            }
            while (Cikti[0] == Cikti[2]|| Cikti[1] == Cikti[2]);
            do
            {
                Cikti[3] = r.Next(0, 5);
            }
            while (Cikti[0] == Cikti[3] || Cikti[1] == Cikti[3]|| Cikti[2] == Cikti[3]);
            do
            {
                Cikti[4] = r.Next(0, 5);
            }
            while (Cikti[0] == Cikti[4] || Cikti[1] == Cikti[4] || Cikti[2] == Cikti[4] || Cikti[4] == Cikti[3]);

            return Cikti;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Her hangi bir deste seçmediniz.");
            }else
            MessageBox.Show(singletone.GetDesteByName(comboBox1.SelectedItem.ToString()).KelimeleriSirala());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Değişiklikleriniz kayıdedildi.");
            System.Xml.Serialization.XmlSerializer xmlser = new System.Xml.Serialization.XmlSerializer(typeof(List<WordList>));
            //save codu
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\Desteler.txt");
            xmlser.Serialize(stream, singletone.GetDesteler());
            stream.Close();
        }
    }
}
