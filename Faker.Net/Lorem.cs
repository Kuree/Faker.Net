using Faker.Locales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Faker.Random;

namespace Faker
{
    public class Lorem :FakerBase
    {
        public Lorem() : base() { }
        public Lorem(LocaleType type) : base(type) { }

        // default static interface
        public static Lorem Default { get { return defaultValue; } }
        private static Lorem defaultValue = new Lorem();

        public string[] GetWords()
        {
            return this.GetWords(3);
        }

        public string[] GetWords(int num)
        {
            return Selector.GetMultipleRandomItemsFromList<string>(locale.LoremWord, num);
        }

        public string GetSentence(int wordCount, int range)
        {
            var resultList = GetWords(wordCount + RandomProxy.Next(range));
            var charList = string.Join(" ", resultList).ToCharArray();
            charList[0] = char.ToUpper(charList[0]);
            return new string(charList) + ".";
        }

        public string GetSentence()
        {
            return this.GetSentence(7, 4);
        }

        public string GetSentences(int count)
        {
            List<string> sentences = new List<string>(count);
            for (int i = 0; i < count; i++) sentences.Add(GetSentence());
            return string.Join("\n", sentences);
        }

        public string GetParagraph(int count)
        {
            return this.GetSentences(count + RandomProxy.Next(4));
        }

        public string GetParagraph()
        {
            return this.GetParagraph(3);
        }

        public string GetParagraphs(int count)
        {
            List<string> paragraphs = new List<string>(count);
            for (int i = 0; i < count; i++) paragraphs.Add(this.GetParagraph());
            return string.Join("\n \r\t", paragraphs);
        }
    }
}
