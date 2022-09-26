using Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class CharacterFactory {
        private readonly Dictionary<char, ICharacter> _characters = new();

        public ICharacter? GetCharacter(char characterIdentifier) {
            // Does the character dictionary contain the one er need?
            if (_characters.ContainsKey(characterIdentifier)) {
                Console.WriteLine("Character reuse");
                return _characters[characterIdentifier];
            }

            // The character isn't in the dictionary.
            // Create it store it, return it.
            Console.WriteLine("Character construction");
            switch (characterIdentifier) {
                case 'a':
                    _characters[characterIdentifier] = new CharecterA();
                    return _characters[characterIdentifier];
                case 'b':
                    _characters[characterIdentifier] = new CharacterB();
                    return _characters[characterIdentifier];
                default:
                    break;
            }

            return null;
        }
        public ICharacter CreateParagraph(List<ICharacter> characters, int location) {
            return new Paragraph(characters, location);
        }
    }
}
