using System.Collections.Generic;
using Faker.Random;

namespace Faker
{
    public class Lorem :FakerBase
    {
        public Lorem()
        { }
        public Lorem(LocaleType type) : base(type) { }

        // default static interface
        public static Lorem Default { get { return defaultValue; } }
        private static Lorem defaultValue = new Lorem();

        public string GetWords()
        {
            return this.GetWords(3);
        }

        public string GetWords(int num)
        {
            return string.Join(" ", Selector.GetMultipleRandomItemsFromList(locale.LoremWord, num));
        }

        public string GetSentence(int wordCount, int range)
        {
            var resultList = GetWords(wordCount + RandomProxy.Next(range));
            var charList = resultList.ToCharArray();
            charList[0] = char.ToUpper(charList[0]);
            return new string(charList) + ".";
        }

        public string GetSentence()
        {
            return this.GetSentence(7, 4);
        }

        public string GetSentences()
        {
            return this.GetSentences(7);
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

        public string GetParagraphs()
        {
            return this.GetParagraphs(4);
        }

        public string GetParagraphs(int count)
        {
            List<string> paragraphs = new List<string>(count);
            for (int i = 0; i < count; i++) paragraphs.Add(this.GetParagraph());
            return string.Join("\n \r\t", paragraphs);
        }
    }
}
