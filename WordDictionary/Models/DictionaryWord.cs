using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary.Models
{
    public class DictionaryWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public List<string> Definition { get; set; }
        public List<string> PartsOfSpeech { get; set; }
        public List<Synonym> Synonyms { get; set; }
        public List<Antonym> Antonyms { get; set; }
        public DictionaryWord()
        {
            Definition = new List<string>();
            PartsOfSpeech = new List<string>();
            Synonyms = new List<Synonym>();
            Antonyms = new List<Antonym>();
        }
    }
}
