using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise.BusinessLayer
{
    public class LineAnalyzer : ILineAnalyzer
    {

        public List<CharacterOccurence> GetAlphaOrderedCharacterOccurences(string line)
        {
            return GetDistinctOccurenceCharacters(line).OrderBy(x => x.character).ToList();
        }

        public CharacterOccurence GetHighestOccurenceCharacter(string line)
        {
            List<CharacterOccurence> distCharacters = GetDistinctOccurenceCharacters(line);

            CharacterOccurence highestOccurence = distCharacters.OrderByDescending(distChar => distChar.numOfOccurences).FirstOrDefault();

            return highestOccurence;
        }

        public CharacterOccurence GetLowestOccurenceCharacter(string line)
        {
            List<CharacterOccurence> distCharacters = GetDistinctOccurenceCharacters(line);

            CharacterOccurence lowestOccurence = distCharacters.OrderBy(distChar => distChar.numOfOccurences).FirstOrDefault();

            return lowestOccurence;
        }

        public List<CharacterOccurence> GetDistinctOccurenceCharacters(string line)
        {
            List<CharacterOccurence> distOccurences = line.Distinct().Select(distChar => new CharacterOccurence()
            {
                character = distChar,
                numOfOccurences = line.Count(currentChar => currentChar == distChar)
            }).ToList();

            return distOccurences;
        }
    }
}
