using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void Form1_Load(object sender, EventArgs e)
        {




            //Desteler = singletone.GetDeste();
            
            foreach (WordList w in singletone.GetDesteler()) {
                if(w.Name!=null && comboBox1.Items.Contains(w.Name)==false)
                comboBox1.Items.Add(w.Name); }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button3 un aynisi
        }
    }
}
