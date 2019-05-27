using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memocabulary
{
    public class WordList
    {

        public string Name { get; set; }
        List<Word> words = new List<Word>();

       public void KelimeEkle(Word word)
        {
            words.Add(word);
        }
       public void KelimeSil(Word word)
        {
            words.Remove(word);
        }
        public Word GetWordByName(string ad)
        {
            return words.Find(a => a.EnlishName.Contains(ad));
        }
        public string KelimeleriSirala()
        {
            string b = "";
            foreach (Word i in this.words)
            {
                b += i.EnlishName + "\n";
            }
            return b;
        }
        private int[] RasgeleSirala22(int cap)
        {
            int[] Cikti = new int[cap];
            Random r = new Random();
            Cikti[0] = r.Next(0, cap);
            do
            {
                Cikti[1] = r.Next(0, cap);
            }
            while (Cikti[0] == Cikti[1]);
            do
            {
                Cikti[2] = r.Next(0, cap);
            }
            while (Cikti[0] == Cikti[2] || Cikti[1] == Cikti[2]);
            do
            {
                Cikti[3] = r.Next(0, cap);
            }
            while (Cikti[0] == Cikti[3] || Cikti[1] == Cikti[3] || Cikti[2] == Cikti[3]);
            

            return Cikti;

        }


        public Word[] KelimeSor()
        {
            Word[] wordsToArray = new Word[words.Capacity];
            
            if (words.Capacity < 6) { System.Windows.Forms.MessageBox.Show("Listenizde en az 6 kelime bulunmalı. lütfen kelime ekleyin.");return null; }
            //   int sik1 = random.Next(3, words.Capacity)- 2;
            int[] r = new int[4];
            r = RasgeleSirala22(words.Capacity);
            //System.Windows.Forms.MessageBox.Show(sik1 + "\n"+ sik2 + "\n" + sik3 + "\n" + sik4 + "\nrandom");
            Word[] Cikti = new Word[5];
            //0 index dogru gerisi yanlis secenekler 
            foreach(Word Kelime in words)
            {
                if (Kelime.WillAskDateTime <= DateTime.Now)
                {
                    Cikti[0] = Kelime;
                    //sorulacak kelime
                    //siklarin soru ile denkgelmeme kontorlu
                    for(int i = 1; i < 5; i++)
                    {/*
                        if (wordsToArray[r[i]] == Kelime) //denk gelmeme durumu
                        {
                            if(r[i]==words.Capacity)
                            Cikti[i] = wordsToArray[r[i]-1];
                            else { Cikti[i] = wordsToArray[r[i]+1]; }
                        }
                        
                        else
                        {
                            Cikti[i] = wordsToArray[r[i]];
                        }*/
                        Cikti[i] = wordsToArray[r[i]];
                    }                   
                                   
                    

                }
            }
            //return null;//if null ise messagebox ta tebrik soyle kelime destesini bitirmis
        }


    }
}
