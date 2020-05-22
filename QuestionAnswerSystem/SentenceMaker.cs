using System;
using System.Collections.Generic;

namespace QuestionAnswerSystem
{
    public class SentenceMaker : LineFormatter
    {
        public SentenceMaker()
        {

        }

        private static readonly List<char> defaultEndOfSentenceCharacters = new List<char>() { '?', '!', '.' };
        public string[] sentences { get; set; }

        public static char[] GetDefaultEndOfSentenceCharacters()
        {
            return defaultEndOfSentenceCharacters.ToArray();
        }
        public override void SplitSentence(string text, clsConstant.StringSplitPattern splitType)
        {
            // sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            sentences = text.Split(GetDefaultEndOfSentenceCharacters(), StringSplitOptions.RemoveEmptyEntries);
        }
       
    }
}