using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rexer
{
    /// <summary>
    /// The Token Class that contains the data of a token and is the token itself.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// The Enum kind of the token, use this with your own Enums.
        /// </summary>
        public Enum _type;
        /// <summary>
        /// What the token contains as text.
        /// </summary>
        public string _def;
        /// <summary>
        /// The main constructor for the Token Class.
        /// </summary>
        /// <param name="Type">The type of Token.</param>
        /// <param name="Def">The defintion of the Token.</param>
        public Token(Enum Type, string Def)
        {
            _type = Type;
            _def = Def;
        }
    }
}
