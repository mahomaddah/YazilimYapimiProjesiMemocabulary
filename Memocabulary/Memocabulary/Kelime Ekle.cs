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
        private WordList wordList = null;
        

        public Kelime_Ekle()
        {
            InitializeComponent();
            
        }
        
        public void DesteIsminiAl(string DesteIsmi)
        {
            //deste ismindan deste ulasicaz 
            wordList = singletone.GetDesteByName(DesteIsmi);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Kelime_Ekle_Load(object sender, EventArgs e)
        {
             singletone = Tone.Instance();
            
        }
    }
}
