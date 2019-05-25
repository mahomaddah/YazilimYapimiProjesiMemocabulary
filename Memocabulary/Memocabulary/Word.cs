using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memocabulary
{
    class Word
    {
        public string EnlishName { get; set; }
        public string TurkishName { get; set; }
        public string WordKind { get; set; }//verb pronoun adjective noun adverb preposition conjunction...
        public string ExampleSentence { get; set; } //opsionel
        public DateTime WillAskDateTime { get; set; }//default is today affter asking it will be update

        bool WordBorned = false;
        Word()
        {
            if (WordBorned == false)
            {
                this.WillAskDateTime = DateTime.Now;
                WordBorned = true;
            }

        }

    }
}
