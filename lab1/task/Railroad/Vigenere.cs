using System.Text.RegularExpressions;

namespace Railroad
{
    public static class Vigenere
    {
        static readonly char[] ltrsBig = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 
                                           'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };

        static string Parse(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (chars[i] == 'Ё')
                {
                    chars[i] = (char)('Е' + 1);
                }
                else if (chars[i] > 'Е')
                {
                    chars[i]++;
                }
            }
            string res = new(chars);
            return res;
        }

        public static string Encrypt(string message, string key)
        {
            int szKey = key.Length;
            int szAlpha = ltrsBig.Length;

            message = message.ToUpper();
            message = Regex.Replace(message, @"[^А-ЯЁ]", "");

            if (szKey < 1)
            {
                return message;
            }

            message = Parse(message);

            char[] cipher = new char[message.Length];

            key = key.ToUpper();
            key = Parse(key);

            for (int i = 0; i < message.Length; i++)
            {
                cipher[i] = ltrsBig[(key[i % szKey] + message[i] - 2 * ltrsBig[0]) % szAlpha];
            }

            string res = new(cipher);
            return res;
        }

        public static string Decrypt(string cipher, string key)
        {
            int szKey = key.Length;
            int szAlpha = ltrsBig.Length;

            cipher = cipher.ToUpper();
            cipher = Regex.Replace(cipher, @"[^А-ЯЁ]", "");

            if (szKey < 1)
            {
                return cipher;
            }

            cipher = Parse(cipher);

            char[] message = new char[cipher.Length];

            key = key.ToUpper();
            key = Parse(key);

            for (int i = 0; i < cipher.Length; i++)
            {
                message[i] = ltrsBig[(cipher[i] - key[i % szKey] + szAlpha) % szAlpha];
            }
            string res = new(message);
            return res;
        }
    }
}