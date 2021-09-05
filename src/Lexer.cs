using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Rexer
{
    ///<summary>The main lexer class, create an object of it and use the lexer with the functions.</summary>
    public class Lexer : IDisposable
    {
        ///<summary>The Lexer Defintion List.</summary>
        public List<LexerDefintion> _definitions { get; } = new List<LexerDefintion>();
        public string _delimiters { get; set; } = "\\s;";
        public Enum UnknownToken { get; set; }
        /// <summary>
        /// The main star of the show, tokenizes a string into a list of class Token.
        /// </summary>
        /// <param name="_str">The String to operate on</param>
        /// <returns>A list of class Token</returns>
        public List<Token> doString(string _str)
        {
            List<Token> tokens = new List<Token>();
            string[] SplitItem = SplitByDelimiters(_str);
            foreach(string s in SplitItem)
            {
                var a = isAnyDefintion(s);
                tokens.Add(new Token(a._type, s));
            }
            return tokens;
        }
        /// <summary>
        /// Tokenizes content from a file, sometimes usable.
        /// </summary>
        /// <param name="_path">The path to the file.</param>
        /// <returns>A list of class Token</returns>
        public List<Token> doFile(string _path)
        {
            return doString(File.ReadAllText(_path));
        }
        /// <summary>
        /// Checks if the piece of text matches any definition.
        /// </summary>
        private LexerDefintion isAnyDefintion(string _text)
        { 
            foreach (LexerDefintion def in _definitions) //Check through all defintions in the list.
            {
                if(Regex.IsMatch(_text, def._regexValue)) //Check if it's a match of that defintion
                {
                    return def; //If so, return the defintion.
                }
            }
            return new LexerDefintion(_text, UnknownToken); //If none are, return an unknown defintion(unknown token should be defined as 255.).
        }
        /// <summary>
        /// Splits the text by the defined delimiters. (Hint: Define delimiters with the SetDelimiters function.)
        /// </summary>
        private string[] SplitByDelimiters(string _text)
        {
            return Regex.Split(_text, _delimiters).Where(s => !string.IsNullOrEmpty(s)).ToArray();
        }
        /// <summary>
        /// Sets the delimiters to split the string you will pass by.
        /// </summary>
        /// <param name="_Delimiters">The string of delimiters in Regex style.</param>
        public void SetDelimiters(string _Delimiters)
        {
            _delimiters = _Delimiters;
        }
        ///<summary>Use this function to insert lexer defintions.</summary>
        public void AddLexerDefintion(LexerDefintion _def)
        {
            _definitions.Add(_def);
        }
        ///<summary>Make sure to dispose after using it!</summary>
        public void Dispose()
        {

        }
    }
}
