using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheWordsOfTheWorld
{
    class GridEntry
    {
        String expressionOrWord, englishText, exampleText;

        public string ExpressionOrWord { get => expressionOrWord; set => expressionOrWord = value; }
        public string EnglishText { get => englishText; set => englishText = value; }
        public string ExampleText { get => exampleText; set => exampleText = value; }
    }
}
