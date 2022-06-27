using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordDictionary.Models;

namespace WordDictionary
{
    public class DictionaryContext : DbContext
    {
        public DictionaryContext() : base("name=DictionaryContext")
        {
        }
        public virtual DbSet<DictionaryWord> Words { get; set; }
        public virtual DbSet<Synonym> Synonyms { get; set; }
        public virtual DbSet<Antonym> Antonyms { get; set; }

    }
}
