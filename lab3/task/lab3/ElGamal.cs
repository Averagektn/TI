using System.Numerics;

namespace lab3
{
    public static class ElGamal
    {
        public static void Encrypt(BigInteger p, BigInteger x, BigInteger k, BigInteger g, string src, string dst)
        {
            var byteCount = p.GetByteCount();

            var y = MyCoolMath.ModPow(g, x, p);
            var a = MyCoolMath.ModPow(g, k, p);

            var m = new byte[1];

            using var fw = new FileStream(dst, FileMode.Create, FileAccess.Write);
            using var fr = new FileStream(src, FileMode.Open, FileAccess.Read);
            byte[] aBytes = a.ToByteArray();
            var aCount = a.GetByteCount();
            while (fr.Read(m, 0, m.Length) > 0)
            {
                var b = MyCoolMath.ModPow(y, k, p);
                b = BigInteger.Multiply(m[0], b);
                b = BigInteger.Remainder(b, p);
                byte[] bBytes = b.ToByteArray();

                fw.Write(aBytes, 0, aCount);
                fw.Write(new byte[byteCount - aCount], 0, byteCount - aCount);

                fw.Write(bBytes, 0, bBytes.Length);
                fw.Write(new byte[byteCount - b.GetByteCount()], 0, byteCount - b.GetByteCount());
            }
        }

        public static void Decrypt(BigInteger p, BigInteger x, string src, string dst)
        {
            var byteCount = p.GetByteCount();
            var aBytes = new byte[byteCount];
            var bBytes = new byte[byteCount];

            using var fr = new FileStream(src, FileMode.Open, FileAccess.Read);
            using var fw = new FileStream(dst, FileMode.Create, FileAccess.Write);
            while (fr.Read(aBytes, 0, aBytes.Length) > 0)
            {
                fr.Read(bBytes, 0, aBytes.Length);
                var a = new BigInteger(aBytes);
                var b = new BigInteger(bBytes);
                var inv = MyCoolMath.ModPow(a, p - 1 - x, p);
                var m = (b * inv) % p;
                var mBytes = m.ToByteArray();

                fw.WriteByte(mBytes[0]);
            }
        }
    }
}
