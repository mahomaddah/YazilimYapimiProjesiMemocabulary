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
    public partial class Kelime_Ekle : Form
    {
        Tone singletone;
        List<WordList> Desteler = null;
        private WordList wordList;
        private string desteismi="";

        public Kelime_Ekle()
        {
            InitializeComponent();
            
        }
        
        public void DesteIsminiAl(string DesteIsmi)
        {
            wordList = null;
            singletone = Tone.Instance();
            desteismi = "";
            desteismi = DesteIsmi;
            //deste ismindan deste ulasicaz 
            wordList = singletone.GetDesteByName(DesteIsmi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word temp = new Word();
            temp.EnlishName = "";
            temp.TurkishName = "";
            temp.WordKind = "";
            temp.EnlishName = textBoxEng.Text;
            temp.TurkishName = textBoxTurk.Text;
            temp.ExampleSentence = textBoxCumle.Text;
            temp.WordKind = listBox1.SelectedIndex.ToString();
            if (temp.EnlishName == "" || temp.TurkishName == "" || temp.WordKind == "")
            {
                MessageBox.Show("Lütfen ingilizce ismi ve türkçe çevirisi ve kelime çeşiti seçeneklerini doğru doldurduğunuzdan emin olun");
            }
            else
            {
                wordList.KelimeEkle(temp);
                MessageBox.Show("Kelimeniz eklendi...");
               
                Desteler.Remove(Desteler.Find(a => a.Name.Contains(desteismi)));
                Desteler.Add(wordList);
                //  singletone.desteninYerineKoy(desteismi, wordList);
            }
        }

        private void Kelime_Ekle_Load(object sender, EventArgs e)
        {
            wordList = new WordList();
            singletone = Tone.Instance();
            Desteler = new List<WordList>();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //geri don
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
