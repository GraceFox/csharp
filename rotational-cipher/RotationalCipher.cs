public static class RotationalCipher
{

    //from this tutorial http://www.c-sharpcorner.com/article/caesar-cipher-in-c-sharp/
    public static string Rotate(string text, int shiftKey)
    {
        string result = string.Empty;

        foreach (var ch in text)
        {
            result += Cipher(ch, shiftKey);
        }
        return result;
    }

    public static char Cipher(char ch, int shiftKey)
    {
        if (char.IsLetter(ch))
        {
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char) ((((ch + shiftKey) - d) % 26) + d);
        }
        return ch;
    }
}