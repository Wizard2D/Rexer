using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rexer
{
    ///<summary>Default Token Types for the lexer, they are not used and just for tests, however if you want you may use them.</summary>
    public enum TokenType : byte { 
        NUM,
        PLUS,
        MINUS,
        MULTI,
        DIVIDE,
        POW,
        STRING,
        UNKNOWN
    }
}
