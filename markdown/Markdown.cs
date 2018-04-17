using System;
using System.Linq;
using System.Text.RegularExpressions;

//failing two tests with lists

public static class Markdown
{
    private static string ItalicMarkDown = "_";
    private static string BoldMarkdown = "__";
    private static string Bullet = "*";
    private static string BoldTag = "strong";
    private static string ItalicTag = "em";
    private static bool list = false;

    private static string ParseItalic(this string markdown) => markdown.ParseDelimiter(ItalicMarkDown, ItalicTag);
    private static string ParseBold(this string markdown) => markdown.ParseDelimiter(BoldMarkdown, BoldTag);

    
    private static bool _inListAfter;


    public static bool InListAfter { get => _inListAfter; set => _inListAfter = value; }

    private static string WrapTags(this string text, string tag)
    {
        return "<" + tag + ">" + text + "</" + tag + ">";
    }

    private static string ParseDelimiter(this string markdown, string delimiter, string tag)
    {
        var pattern = delimiter + "(.+)" + delimiter;
        var replacement = "<" + tag + ">$1</" + tag + ">";
        return Regex.Replace(markdown, pattern, replacement);
    }

    private static string ParseText(this string markdown, bool list)
    {
        var textHtml = markdown
            .ParseBold()
            .ParseItalic();

        return list ? textHtml : WrapTags(textHtml, "p");
    }

    private static string ParseHeader(this string markdown, bool list)
    {
        var levelHeading = 0;

        for (int i = 0; i < markdown.Length; i++)
        {
            if (markdown[i] == '#')
                levelHeading += 1;
            else
                break;
        }

        if (levelHeading == 0)
        {
            _inListAfter = list;
            return null;
        }

        var headerTag = "h" + levelHeading;
        var headerHtml = WrapTags(markdown.Substring(levelHeading + 1), headerTag);


        if (list)
        {
            return "</ul>" + headerHtml;
        }
        else
        {
            _inListAfter = false;
            return headerHtml;
        }
    }

    private static string ParseLineItem(string markdown, bool list)
    {

        string innerHtml = null;

        if (markdown.StartsWith(Bullet))
        {
             innerHtml = WrapTags(ParseText(markdown.Substring(2), true), "li");
            _inListAfter = true;
        }
        return innerHtml;

        return list ? innerHtml : "<ul>" + innerHtml;

        _inListAfter = list;
        return null;
    }

    private static string ParseParagraph(string markdown, bool list)
    {
        _inListAfter = false;
        if (!list)
        {
            return ParseText(markdown, list);
        }
        else
        {
            return "</ul>" + ParseText(markdown: markdown, list: true);
        }
    }

    private static string ParseLine(string markdown, bool list)
    {
        var result = 
            ParseHeader(markdown, list) ??
            ParseLineItem(markdown, list) ??
            ParseParagraph(markdown, list);

        if (result == null)
            throw new ArgumentException("Invalid markdown");

        return result;
    }

    public static string ParseList(string markdown)
    {
        var lines = markdown.Split('\n');
        var result = "";

        foreach (string l in lines)
        {
            var lineResult = ParseLineItem(l, false );
            result += lineResult;
        }

        return result;
    }
}