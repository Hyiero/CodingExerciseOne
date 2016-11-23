using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise.BusinessLayer
{
    public interface ILineAnalyzer
    {
        List<CharacterOccurence> GetAlphaOrderedCharacterOccurences(string line);
        CharacterOccurence GetHighestOccurenceCharacter(string line);
        CharacterOccurence GetLowestOccurenceCharacter(string line);
        List<CharacterOccurence> GetDistinctOccurenceCharacters(string line);
    }
}
