using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static Dictionary<string, string> Translations = new Dictionary<string, string>
    {
        {"AUG", "Methionine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
        {"UAA", "STOP"},
        {"UAG", "STOP"},
        {"UGA", "STOP"}
    };

    // nice use of dictionary http://exercism.io/submissions/0e27f709512847909d0d77a0c011f127
    // or this http://exercism.io/submissions/a5a8b92ff82440319369dc00c1516790

    //refactor
    //passes 8 out of 11. Still to translate back again 
    public static string[] Translate(string codon)
    {
        List<string> listofKeys = new List<string>();
        var proteins = Translations[codon.Substring(0, 3)];

        //foreach (var protein in proteins)
        //{

            if (!Translations.ContainsKey(protein))
            {
                throw new Exception("boo hoo");
            }

            else
            {
                if (Translations.TryGetValue(protein, out string proteinResult))
                {
                    return new[] { proteinResult };
                }

                else if (Translations[protein] == "STOP")
                {
                    return listofKeys.ToArray();
                }

                else
                {
                    listofKeys.Add(Translations[protein]);
                }
            }
        }

        return listofKeys.ToArray();
    }
}


