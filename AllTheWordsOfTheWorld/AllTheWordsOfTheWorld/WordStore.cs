using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheWordsOfTheWorld
{
    class WordStore
    {
        int noOfEntries = 0;
        String keyword;
        SortedList<int, GridEntry> listOfEntries = new SortedList<int, GridEntry>();

        public int NoOfEntries { get => noOfEntries; }
        public string Keyword { get => keyword; set => keyword = value; }

        public void addEntry(String wordIn, String englishIn, String exampleIn)
        {
            GridEntry currEntry = new GridEntry();

            currEntry.ExpressionOrWord = wordIn;
            currEntry.EnglishText = englishIn;
            currEntry.ExampleText = exampleIn;
            listOfEntries.Add(noOfEntries++, currEntry);
        }

        public GridEntry getGridEntryByIndex( int index )
        {
            GridEntry currEntry = null;

            if( listOfEntries.ContainsKey( index ) )
            {
                listOfEntries.TryGetValue(index, out currEntry);
            }
            return currEntry;
        }

        public void disposeAllGridEntries()
        {
            listOfEntries.Clear();
        }
    }
}
