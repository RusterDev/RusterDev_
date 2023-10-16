using System;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using System.Collections.Generic;

namespace nLexer {

    class Lexer {
    private int position;
    private int len;

    public int getPos{
        get
        {
            return position;
        }
        set 
        {
            if (value >= 0) {len = value;} else {Console.WriteLine("erro");}

        }
    }    

   public Dictionary<string, string> patterns = new Dictionary<string, string>() {
      {"INT", "NUMBER"},
      {"FLOAT", "NUMBER"},
      {"STRING", "TEXT"}
    };

    public Dictionary<char, string> operators = new Dictionary<char, string>() {
    {'=', "EQUAL"},
    {'+', "ADD"},
    {'-', "MINUS"},
    {'/', "RPAREN"}
};




    class Init {
        public static void Main(string[] args)
        {
            string[] tokens = new string[] { "else", "if" };
            List<string> tokens_idn = new List<string>();
            List<string> correct_tokens = new List<string>();

           string input = Console.ReadLine();

        foreach(string token in tokens) {
            if (input != token) {
                tokens_idn.Add(input);
                Console.WriteLine("não");
                break;
            } else {
                correct_tokens.Add(input);
                Console.WriteLine("sim");
                break;
            }

        
        }
            Lexer lexeme = new Lexer();


MatchCollection matches = Regex.Matches(input, @"\S+");

foreach (Match match in matches)
{
    string value = match.Value;
    string type = null;

    if (int.TryParse(value, out _))
    {
        type = "INT";

            int value_of = Convert.ToInt32(value);

        Console.WriteLine(value_of += value_of += value_of);
        break;
    }
    else if (double.TryParse(value, out _))
    {
        type = "FLOAT";
                double value_of2 = Convert.ToDouble(value);
            Console.WriteLine(value_of2 += value_of2 += value_of2);

    }
    else
    {
        type = "STRING";
    }

        Console.WriteLine(lexeme.patterns[type] + " " + value);

}



            
            foreach(char op in lexeme.operators.Keys) {

                }
            }

            }

            
        }

    }

