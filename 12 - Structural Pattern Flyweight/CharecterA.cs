using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class CharecterA : ICharacter {
        private char _actualCharacter = 'a';
        private string _fontFamily = string.Empty;
        private int _fontSize;
        public void Draw(string fontFamily, int fontSize) {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Console.WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
        }
    }
}