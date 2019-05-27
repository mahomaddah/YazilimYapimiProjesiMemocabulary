using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memocabulary
{
   public class Word
    {
        public string EnlishName { get; set; }
        public short DogruCombosu { get; set; }//30s 1dk 1gun 1ay (0.datetime ,1.30s,2,3,4)
        public string TurkishName { get; set; }
        public string WordKind { get; set; }//verb pronoun adjective noun adverb preposition conjunction...
        public string ExampleSentence { get; set; } //opsionel
        public DateTime WillAskDateTime { get; set; }//default is today affter asking it will be update

        private bool WordBorned = false;
        public Word()
        {
            if (WordBorned == false)
            {
                this.DogruCombosu = 0;
                this.WillAskDateTime = DateTime.Now;
                WordBorned = true;
            }

        }

    }
}
