using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary.Models
{
    public class Antonym
    {
        public int Id { get; set; }
        public string Antonyms { get; set; }
        public List<string> Definition { get; set; }
        public List<string> PartsOfSpeech { get; set; }
        public DictionaryWord WordDictionary { get; set; }
        public Antonym()
        {
            Definition = new List<string>();
            PartsOfSpeech = new List<string>();
        }
    }
}
