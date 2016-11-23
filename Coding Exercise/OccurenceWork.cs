using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coding_Exercise.BusinessLayer;

namespace Coding_Exercise
{
    public class OccurenceWork
    {
        private ILineAnalyzer lineAnalyzer;

        public OccurenceWork(ILineAnalyzer _lineAnalyzer)
        {
            lineAnalyzer = _lineAnalyzer;
        }

        public void DisplayHighestOccurenceInLine(string line)
        {
            CharacterOccurence highestOccurence = lineAnalyzer.GetHighestOccurenceCharacter(line);
            Console.WriteLine(string.Format("Line: {0}, \nHigh Char: {1}, Number Of Occurences: {2}", line, highestOccurence.character, highestOccurence.numOfOccurences));
        }

        public void DisplayLowestOccurenceInLine(string line)
        {
            CharacterOccurence highestOccurence = lineAnalyzer.GetHighestOccurenceCharacter(line);
            Console.WriteLine(string.Format("Line: {0}, \nHigh Char: {1}, Number Of Occurences: {2}", line, highestOccurence.character, highestOccurence.numOfOccurences));
        }

        public void DisplayTotalOrderedOccurencesInLine(string line)
        {
            List<CharacterOccurence> distChars = lineAnalyzer.GetAlphaOrderedCharacterOccurences(line);
            distChars.ForEach(distChar => Console.WriteLine(string.Format("Char: {0}, Number Of Occurences: {1}", distChar.character, distChar.numOfOccurences)));
        }
    }
}
