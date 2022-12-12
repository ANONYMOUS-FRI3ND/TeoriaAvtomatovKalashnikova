using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAnalyzer
{
    public static class DataTable
    {
        public static List<string> GetServiceWords()
        {
            return new List<string>()
            {
                "program",
                "var",
                "and",
                "int",
                "float",
                "bool",
                "write",
                "if",
                "while",
                "do",
                "begin",
                "else",
                "then",
                "end.",
                "read",
                "for",
                "to"
                

            };
        }

        public static List<string> GetSeparators()
        {
            return new List<string>()
            {
                ")",
                "(",
                "{",
                "}",
                ";",
                ",",
                ":",           
                "as",            
                "plus",
                "minus",
                "or",
                "mult",
                "div",
                "and",
                "`",
                "NE",
                "EQ",
                "LT",
                "LE",
                "GT",
                "GE",
                "and",
                "/n"

            };
        }
           
    }
}
