using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rexer
{
    ///<summary>Class for a lexer token/expression defintion, you'll use this to add lexer definitions for your lexer to read.</summary>
    public class LexerDefintion
    {
        ///<summary>Regex Expression for the defintion</summary>
        public string _regexValue;
        ///<summary>Token Type(use enum) for the definition</summary>
        public Enum _type;

        ///<summary>Main Constructor. Make sure your Type enum derives from "byte".</summary>
        public LexerDefintion(string regexVal, Enum Type) 
        {
            _regexValue = regexVal;
            _type = Type;
        }
        ///<summary>Empty Constructor. Use this when you want to initialize the values later.</summary>
        public LexerDefintion() { } 
    }
}
