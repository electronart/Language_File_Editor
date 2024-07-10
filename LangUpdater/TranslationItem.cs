using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangUpdater
{
    public class TranslationItem
    {
        public TranslationItem(string original, string translation)
        {
            Original = original;
            Translation = translation;
        }

        public string Original;
        public string Translation;
    }
}
