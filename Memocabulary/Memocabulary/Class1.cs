using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memocabulary
{
    class Tone      //i's my singletone Class
    {

        private static Tone instance;
        private List<WordList> Desteler = null;
        


        private Tone()
        {
            if (Desteler == null)
            {
                Desteler = new List<WordList>();
            }
            
        }
        public static Tone Instance()
        {
            if (instance == null)
            {
                instance = new Tone();

            }
            return instance;
        }
        public void DesteEkle(WordList deste)
        {
            Desteler.Add(deste);
        }
        public WordList GetDesteByName(string ad)
        {
            return Desteler.Find(a => a.Name.Contains(ad));
        }
        public List<WordList> GetDeste()
        {
            return Desteler;
        }
        public void desteninYerineKoy(string ad, WordList Koy)
        {
            Desteler.Remove(Desteler.Find(a => a.Name.Contains(ad)));
            Desteler.Add(Koy);
        }

    }
}

