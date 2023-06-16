using System.Numerics;

namespace lab4
{
    public struct CheckSign
    {
        public BigInteger u1;
        public BigInteger u2;
        public BigInteger w;
        public BigInteger v;
        public BigInteger hash;
        public BigInteger r;
        public BigInteger s;


        public CheckSign(BigInteger u1, BigInteger u2, BigInteger w, BigInteger v, BigInteger hash, BigInteger r, BigInteger s)
        {
            this.u1 = u1;
            this.u2 = u2;
            this.w = w;
            this.v = v;
            this.hash = hash;
            this.r = r;
            this.s = s; 
        }
    }
    public static class MyCoolSignature
    {
        // Начальное значение при расчете хеша
        private const int H = 100;
        public static BigInteger Hash(string src, BigInteger modulus)
        {
            BigInteger currH = H;
            int symbol;

            // чтение байт и расчет h(M)i
            using var fr = new FileStream(src, FileMode.Open, FileAccess.Read);
            symbol = fr.ReadByte();
            while (symbol != -1)
            {
                currH += symbol;
                currH = MyCoolMath.ModPow(currH, 2, modulus);
                symbol = fr.ReadByte();
            }

            return BigInteger.Remainder(currH, modulus);
        }

        public static bool Sign(BigInteger p, BigInteger q, BigInteger x, BigInteger k, BigInteger g, string src, out BigInteger r, out BigInteger s, out BigInteger hash)
        {
            bool res = true;
            hash = Hash(src, q);
            int bytesCount = q.GetByteCount();
            var y = MyCoolMath.ModPow(g, x, p);

            // Вычисление r и s 
            r = BigInteger.Remainder(MyCoolMath.ModPow(g, k, p), q);
            s = BigInteger.Remainder(BigInteger.Multiply(MyCoolMath.ModPow(k, q - 2, q), BigInteger.Add(hash, BigInteger.Multiply(x, r))), q);
            
            // Обработка ошибочной ситуации, когда r или s = 0
            if (r == 0 || s == 0)
            {
                res = false;
            }
            else
            {
                // запись подписанного файла в папку signatures под именем имяфайла_SIGNATURE.txt
                // текстовый формат для упрощения тестирования
                string signatureFileName = Path.Combine("signatures", Path.GetFileNameWithoutExtension(src) + "_SIGNATURE.txt");
                File.Copy(src, signatureFileName, true);
                using var fw = new FileStream(signatureFileName, FileMode.Append, FileAccess.Write);

                // В конец файда дописывается подпись и y, т.к. он является открытым параметром
                var bytes = r.ToByteArray();
                fw.Write(bytes, 0, bytes.Length);
                fw.Write(new byte[bytesCount - bytes.Length]);

                bytes = s.ToByteArray();
                fw.Write(bytes, 0, bytes.Length);
                fw.Write(new byte[bytesCount - bytes.Length]);

                bytesCount = p.GetByteCount();
                bytes = new byte[bytesCount];
                bytes = y.ToByteArray();
                fw.Write(bytes, 0, bytes.Length);
                fw.Write(new byte[bytesCount - bytes.Length]);
            }

            return res;
        }

        public static bool CheckSignature(BigInteger p, BigInteger q, BigInteger g, string src, string signature, out CheckSign check)
        {
            bool res = false;
            BigInteger hash = Hash(src, q);
            BigInteger v, u1, u2, w, r, s;
            v = u1 = u2 = w = r = s = BigInteger.Zero;

            int bytesCount = q.GetByteCount();
            var buffer = new byte[bytesCount];

            FileInfo srcInfo = new(src);
            FileInfo signatureInfo = new(signature);
            if (signatureInfo.Length == srcInfo.Length + bytesCount * 2 + p.GetByteCount())
            {
                // Чтение r s y из подписанного файла
                using var fr = new FileStream(signature, FileMode.Open, FileAccess.Read);
                fr.Seek(srcInfo.Length, SeekOrigin.Begin);

                fr.Read(buffer, 0, bytesCount);
                r = new BigInteger(buffer);

                fr.Read(buffer, 0, bytesCount);
                s = new BigInteger(buffer);

                bytesCount = p.GetByteCount();
                buffer = new byte[bytesCount];
                fr.Read(buffer, 0, bytesCount);
                var y = new BigInteger(buffer);

                // Проверка подписи
                w = MyCoolMath.ModPow(s, q - 2, q);
                u1 = BigInteger.Remainder(BigInteger.Multiply(hash, w), q);
                u2 = BigInteger.Remainder(BigInteger.Multiply(r, w), q);
                v = BigInteger.Remainder(BigInteger.Remainder(BigInteger.Multiply(MyCoolMath.ModPow(g, u1, p), MyCoolMath.ModPow(y, u2, p)), p), q);

                // Проверка полученной подписи с рассчитанной
                if (BigInteger.Compare(r, v) == 0)
                {
                    res = true;
                }
            }
            check = new CheckSign(u1, u2, w, v, hash, r, s);

            return res;
        }
    }
}
