using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public static class StreamCipher
    {
        const int BYTE = 8;
        private static readonly byte[] BIT = { 0b_00_00_00_00, 0b_00_00_00_01, 0b_00_00_00_10, 0b_00_00_01_00,
            0b_00_00_10_00, 0b_00_01_00_00, 0b_00_10_00_00, 0b_01_00_00_00, 0b_10_00_00_00 };
        private static readonly byte[] CUTOFF = { 0b_00_00_00_00, 0b_00_00_00_01, 0b_00_00_00_11, 0b_00_00_01_11,
            0b_00_00_11_11, 0b_00_01_11_11, 0b_00_11_11_11, 0b_01_11_11_11, 0b_11_11_11_11 };

        private static byte InitializeKey(byte[] register, int[] powers, int size)
        {
            byte res = (byte)((register[^1] << BYTE - (size % BYTE)) | (register[^2] >> size % BYTE));
            for (int i = 0; i < BYTE; i++)
            {
                UpdateRegister(register, powers, size);
            }
            return res;
        }

        private static void UpdateRegister(byte[] register, int[] powers, int size)
        {
            byte lastBit = Convert.ToByte(register[^1] >> size % BYTE - 1);

            for (int i = 0; i < powers.Length - 1; i++)
            {
                if ((register[powers[i] / BYTE] & BIT[powers[i] % BYTE]) != 0)
                {
                    lastBit ^= 1;
                }
                else
                {
                    lastBit ^= 0;
                }
            }
            for (int i = 1; i < register.Length; i++)
            {
                register[^i] <<= 1;
                register[^i] |= (byte)(register[^(i + 1)] >> 7);
            }
            register[0] <<= 1;
            register[0] |= lastBit;
            register[^1] &= CUTOFF[size % BYTE];
        }

        public static string[] Cipher(int[] powers, byte[] register, string sourceFilePath, string destinationFilePath)
        {
            const int bufferSize = 1024;
            int bytesRead;

            byte[] buffer = new byte[bufferSize];
            byte[] res = new byte[bufferSize];
            byte key;

            var sbKey = new StringBuilder();
            var sbCipher = new StringBuilder();

            using var sourceStream = new FileStream(sourceFilePath, FileMode.Open);
            using var destinationStream = new FileStream(destinationFilePath, FileMode.Create);
            while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    key = InitializeKey(register, powers, powers[^1]);
                    res[i] = (byte)(buffer[i] ^ key);
                    if (sbKey.Length < 128 * 9)
                    {
                        sbKey.Append(Convert.ToString(key, 2).PadLeft(8, '0') + " ");
                        sbCipher.Append(Convert.ToString(res[i], 2).PadLeft(8, '0') + " ");
                    }
                }
                destinationStream.Write(res, 0, bytesRead);
            }
            return new string[2] { sbKey.ToString(), sbCipher.ToString() };
        }
    }
}
