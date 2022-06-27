namespace WordDictionary.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WordDictionary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WordDictionary.DictionaryContext>
    {
        private DictionaryContext _context;
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WordDictionary.DictionaryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            _context = new DictionaryContext();
            List<string> definition1;
            List<string> partsofspeech1;
           definition1 = new List<string>
            {
                "provide a link  between two entities, regions, components, etc.",
                "that which provides such a link",
                "the connecting boundary between peoples, systems, etc."
            };
            partsofspeech1 = new List<string>
            {
                "v.i.",
                "noun"
            };
            DictionaryWord word1 = new DictionaryWord()
            {
                Word = "interface",
                Definition = definition1,
                PartsOfSpeech = partsofspeech1
            };
            List<string> definition2;
            List<string> partsofspeech2;
            
            definition2 = new List<string>
            {
                "readily perceived; obvious",
                "demonstrate;  give evidence of",
                "a list of a shipment"
            };
            partsofspeech2 = new List<string>
            {
                "adj",
                "v.t.",
                "noun"
            };
            DictionaryWord word2 = new DictionaryWord()
            {
                Word = "manifest",
                Definition = definition2,
                PartsOfSpeech = partsofspeech2
            };
            List<string> definition3;
            List<string> partsofspeech3;

            definition3 = new List<string>
            {
                "load with too great a burden or cargo",
                "an excessive load or amount"
            };
            partsofspeech3 = new List<string>
            {
                "verb",
                "noun"
            };
            DictionaryWord word3 = new DictionaryWord()
            {
                Word = "overload",
                Definition = definition3,
                PartsOfSpeech = partsofspeech3
            };
            List<string> definition4;
            List<string> partsofspeech4;

            definition4 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            partsofspeech4 = new List<string>
            {
                "verb"
            };
            DictionaryWord word4 = new DictionaryWord()
            {
                Word = "overload",
                Definition = definition3,
                PartsOfSpeech = partsofspeech3
            };
            List<string> definition5;
            List<string> partsofspeech5;

            definition5 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            partsofspeech5 = new List<string>
            {
                "verb"
            };
            DictionaryWord word5 = new DictionaryWord()
            {
                Word = "overload",
                Definition = definition5,
                PartsOfSpeech = partsofspeech5
            };
            List<string> definition6;
            List<string> partsofspeech6;

            definition6 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            partsofspeech6 = new List<string>
            {
                "verb"
            };
            DictionaryWord word6 = new DictionaryWord()
            {
                Word = "overload",
                Definition = definition4,
                PartsOfSpeech = partsofspeech4
            };


            Synonym synonym1 = new Synonym()
            {
                Synonyms = "cooperate",
                Definition = definition2,
                PartsOfSpeech = partsofspeech2
            };
            List<string> definition2 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            List<string> partsofspeech2 = new List<string>
            {
                "verb"
            };
            Synonym synonym2 = new Synonym()
            {
                Synonyms = "cooperate",
                Definition = definition3,
                PartsOfSpeech = partsofspeech3
            };
            List<string> definition4 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            List<string> partsofspeech4 = new List<string>
            {
                "verb"
            };
            Synonym synonym4 = new Synonym()
            {
                Synonyms = "cooperate",
                Definition = definition4,
                PartsOfSpeech = partsofspeech4
            };
            List<string> definition5 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            List<string> partsofspeech5 = new List<string>
            {
                "verb"
            }
            Synonym synonym5 = new Synonym()
            {
                Synonyms = "cooperate",
                Definition = definition5,
                PartsOfSpeech = partsofspeech5
            };
            List<string> definitionAnt1 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            List<string> partsofspeechAnt1 = new List<string>
            {
                "verb"
            }
            Antonym antonym1 = new Antonym()
            {
                Antonyms = "cooperate",
                Definition = definitionAnt1,
                PartsOfSpeech = partsofspeechAnt1
            };
            List<string> definitionAnt2 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            List<string> partsofspeechAnt2 = new List<string>
            {
                "verb"
            }
            Antonym antonym = new Antonym()
            {
                Antonyms = "cooperate",
                Definition = definitionAnt2,
                PartsOfSpeech = partsofspeechAnt2
            };
            List<string> definitionAnt3 = new List<string>
            {
                "work jointly toward the same end",
                "assist someone or comply with their requests"
            };
            List<string> partsofspeechAnt3 = new List<string>
            {
                "verb"
            }
            Antonym antonymAnt3 = new Antonym()
            {
                Antonyms = "cooperate",
                Definition = definitionAnt3,
                PartsOfSpeech = partsofspeechAnt3
            };
            List<Synonym> synonymsList1 = new List<Synonym>();
            synonymsList1.Add(synonym1);
            synonymsList1.Add(synonym2);
            synonymsList1.Add(synonym3);
            synonymsList1.Add(synonym4);
            synonymsList1.Add(synonym5);
            
            List<Antonym> antonymsList1 = new List<Antonym>();
            antonymsList1.Add(antonym1);
            antonymsList1.Add(antonym2);
            antonymsList1.Add(antonym3);
            

            _context.Words.AddOrUpdate(word1);
            _context.Words.AddOrUpdate(word2);
            _context.Words.AddOrUpdate(word3);
            _context.SaveChanges();
            
        }


    }
}

