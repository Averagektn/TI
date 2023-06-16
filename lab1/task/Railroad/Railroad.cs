using System.Text.RegularExpressions;

namespace Railroad
{
    public static class Railroad
    {
        public static string Encrypt(string message, int key)
        {
            message = message.ToUpper().Trim();
            message = Regex.Replace(message, @"[^A-Z]", "");
            if (key <= 1)
            {
                return message;
            }

            int iter = 0;
            int sh = key * 2 - 2;
            int len = message.Length;
            char[] cipher = new char[len];

            for (int i = 0; sh * i < len; i++)
            {
                cipher[iter++] = message[sh * i];
            }
            for (int i = 1; i < key - 1; i++)
            {
                for (int j = 0; i + sh * j < len; j++)
                {
                    cipher[iter++] = message[i + sh * j];
                    if (sh - i + sh * j < len)
                        cipher[iter++] = message[sh - i + sh * j];
                }
            }
            for (int i = 0; sh * i + key - 1 < len; i++)
            {
                cipher[iter++] = message[sh * i + key - 1];
            }

            string res = new(cipher);
            return res;
        }

        public static string Decrypt(string cipher, int key)
        {
            cipher = cipher.ToUpper().Trim();
            cipher = Regex.Replace(cipher, @"[^A-Z]", "");

            if (cipher.Length <= key || key <= 1)
            {
                return cipher;
            }

            char[] message = new char[cipher.Length];
            int len = cipher.Length;
            int sh = key * 2 - 2;
            int iter = 0;

            for (int i = 0; sh * i < len; i++)
            {
                message[sh * i] = cipher[iter++];
            }
            for (int i = 1; i < key - 1; i++)
            {
                for (int j = 0; i + sh * j < len; j++)
                {
                    message[i + sh * j] = cipher[iter++];
                    if (sh - i + sh * j < len)
                        message[sh - i + sh * j] = cipher[iter++];
                }
            }
            for (int i = 0; sh * i + key - 1 < len; i++)
            {
                message[sh * i + key - 1] = cipher[iter++];
            }

            string res = new(message);
            return res;
        }
    }
}
