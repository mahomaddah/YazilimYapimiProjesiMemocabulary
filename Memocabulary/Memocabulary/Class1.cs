using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            System.Xml.Serialization.XmlSerializer xmlser = new System.Xml.Serialization.XmlSerializer(typeof(List<WordList>));


            //load kodu            
            using (var doc = new StreamReader(Environment.CurrentDirectory + "\\Desteler.txt"))
            {
                Desteler = (List<WordList>)xmlser.Deserialize(doc);
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
        public List<WordList> GetDesteler()
        {
               return Desteler;
        }
        public void desteninYerineKoy( WordList Koy)
        {
            Desteler.Remove(Koy);//Desteler.Find(a => a.Name.Contains(ad)));
            Desteler.Add(Koy);                         
        }

    }
}

