using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangUpdater
{
    public class Lang
    {
        /// <summary>
        /// No error handling, use try catch on this method
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Lang LoadFromFile(string fileName)
        {
            Lang lang = new Lang();
            string[] lines = File.ReadAllLines(fileName);

            int i = 0;
            while (i < lines.Length)
            {
                string line = lines[i];
                if (line.StartsWith("#"))
                {
                    // A comment.

                    lang.LangItems.Add(line);
                } else
                {
                    // Translation
                    string original     = line;
                    string translation = "";
                    try
                    {
                        translation = lines[i + 1];
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Misalignment in lang file. Ends on original string instead of translation.", original);
                    }
                    lang.LangItems.Add(new TranslationItem(original, translation));
                    ++i;
                }
                ++i;
            }
            return lang;
        }

        public List<object> LangItems = new List<object>();

        public void GetUpdatedLangFromTemplate(Lang templateLang, out Lang updatedLang, out List<string> newStrings, out List<string> removedStrings)
        {
            newStrings = new List<string>();
            removedStrings = new List<string>();

            updatedLang = new Lang();
            #region Important Header data from main lang file.
            updatedLang.LangItems.Add(LangItems[0]);
            updatedLang.LangItems.Add(LangItems[1]);
            updatedLang.LangItems.Add(LangItems[2]);
            #endregion
            int i = 3;
            #region Build lang strings from template, updating translations where existing translations are available.
            while (i < templateLang.LangItems.Count)
            {
                var item = templateLang.LangItems[i];
                if (item is string comment)
                {
                    updatedLang.LangItems.Add(comment);
                }
                if (item is TranslationItem translationItem)
                {
                    string original     = translationItem.Original;
                    string translation  = translationItem.Translation;
                    if (TryGetExistingTranslation(original, out string existingTranslation))
                    {
                        translation = existingTranslation;
                    } else
                    {
                        // This is a new string.
                        newStrings.Add(original);
                    }


                    updatedLang.LangItems.Add(new TranslationItem(original,translation));
                }
                ++i;
            }
            #endregion
            #region Next, build a list of removed translations.
            foreach(var langItem in LangItems)
            {
                if (langItem is TranslationItem translationItem)
                {
                    string original = translationItem.Original;
                    if (!templateLang.TryGetExistingTranslation(original, out string translation))
                    {
                        // The template no longer contains this string.
                        removedStrings.Add(original);
                    }
                }
            }
            #endregion
        }

        public bool TryGetExistingTranslation(string originalString, out string translation)
        {
            foreach(var langItem in LangItems)
            {
                if (langItem is TranslationItem translationItem)
                {
                    if (translationItem.Original == originalString)
                    {
                        translation = translationItem.Translation;
                        return true;
                    }
                }
            }
            translation = "";
            return false;
        }

    }
}
