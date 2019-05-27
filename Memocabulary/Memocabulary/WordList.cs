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
        private List<Word> words = new List<Word>();

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
        public List<Word> KelimeleriSirala()
        {
            return words;
        }
        public Word[] KelimeSor()
        {
            Word[] wordsToArray = new Word[words.Capacity];
            Random random = new Random();
            if (words.Capacity < 6) { System.Windows.Forms.MessageBox.Show("Listenizde en az 6 kelime bulunmalı. lütfen kelime ekleyin.");return null; }
            int sik1 = random.Next(3, words.Capacity)- 2;
            int sik2 = random.Next(3, words.Capacity)- 2;
            int sik3 = random.Next(3, words.Capacity)- 2;
            int sik4 = random.Next(3, words.Capacity)- 2;
            
            Word[] Cikti = new Word[5];
            //0 index dogru gerisi yanlis secenekler 
            foreach(Word Kelime in words)
            {
                if (Kelime.WillAskDateTime <= DateTime.Now)
                {
                    Cikti[0] = Kelime;
                    //sorulacak kelime
                    //siklarin soru ile denkgelmeme kontorlu
                    if (wordsToArray[sik1] == Kelime)
                    {
                        Cikti[1] = wordsToArray[sik1+1];
                    }
                    else
                    {
                        Cikti[1] = wordsToArray[sik1];
                    }

                    if (wordsToArray[sik2] == Kelime)
                    {
                        Cikti[2] = wordsToArray[sik2 + 1];
                    }


                    else
                    {
                        Cikti[2] = wordsToArray[sik2];
                    }

                    if (wordsToArray[sik3] == Kelime)
                    {
                        Cikti[3] = wordsToArray[sik3 + 1];
                    }
                    else
                    {
                        Cikti[3] = wordsToArray[sik3];
                    }

                    if (wordsToArray[sik4] == Kelime)
                    {
                        Cikti[4] = wordsToArray[sik4 + 1];
                    }
                    else
                    {
                        Cikti[4] = wordsToArray[sik4];
                    }                
                    return Cikti;
                }
            }
            return null;//if null ise messagebox ta tebrik soyle kelime destesini bitirmis
        }


    }
}
